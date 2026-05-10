using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.dao
{
	public class MovimentacaoEstoqueDAO
	{
		private MySqlConnection conexao;

		public MovimentacaoEstoqueDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

        public void cadastrarMovimentacaoEstoque(MovimentacaoEstoque movimentacao)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();

            try
            {
                bool Entrada = movimentacao.tipoMovimentacao == "Entrada de Compra" || movimentacao.tipoMovimentacao == "Entrada de Devolução" || movimentacao.tipoMovimentacao == "Ajuste Positivo";

                bool Saida = movimentacao.tipoMovimentacao == "Saida Descarte" || movimentacao.tipoMovimentacao == "Ajuste Negativo";

                if (Saida)
                {
                    string sqlVerifica = "SELECT quantidade FROM tb_estoque_epi WHERE id_estoque = @id_estoque";
                    MySqlCommand cmdVerifica = new MySqlCommand(sqlVerifica, conexao, transaction);
                    cmdVerifica.Parameters.AddWithValue("@id_estoque", movimentacao.estoqueId);

                    object resultado = cmdVerifica.ExecuteScalar();

                    if (resultado == null || resultado is DBNull)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Estoque não encontrado.");
                        return;
                    }

                    int quantidadeAtual = Convert.ToInt32(resultado);

                    if (quantidadeAtual < movimentacao.quantidade)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Estoque insuficiente. Disponível: {quantidadeAtual}, Solicitado: {movimentacao.quantidade}.");
                        return;
                    }
                }

                string sqlMovimentacao = @"INSERT INTO tb_movimentacao_estoque (tipo_movimentacao, quantidade, data_movimentacao, observacao, fk_estoque, fk_funcionario) VALUES (@tipo_movimentacao, @quantidade, @data_movimentacao, @observacao, @fk_estoque, @fk_funcionario)";

                MySqlCommand cmd = new MySqlCommand(sqlMovimentacao, conexao, transaction);
                cmd.Parameters.AddWithValue("@tipo_movimentacao", movimentacao.tipoMovimentacao);
                cmd.Parameters.AddWithValue("@quantidade", movimentacao.quantidade);
                cmd.Parameters.AddWithValue("@data_movimentacao", movimentacao.dataMovimentacao);
                cmd.Parameters.AddWithValue("@observacao", movimentacao.observacao);
                cmd.Parameters.AddWithValue("@fk_estoque", movimentacao.estoqueId);
                cmd.Parameters.AddWithValue("@fk_funcionario", movimentacao.funcionarioId);
                cmd.ExecuteNonQuery();

                string operacao = Entrada ? "+" : "-";
                string sqlEstoque = $"UPDATE tb_estoque_epi SET quantidade = quantidade {operacao} @quantidade WHERE id_estoque = @id_estoque";

                MySqlCommand cmdEstoque = new MySqlCommand(sqlEstoque, conexao, transaction);
                cmdEstoque.Parameters.AddWithValue("@quantidade", movimentacao.quantidade);
                cmdEstoque.Parameters.AddWithValue("@id_estoque", movimentacao.estoqueId);
                cmdEstoque.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar movimentação de estoque: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
