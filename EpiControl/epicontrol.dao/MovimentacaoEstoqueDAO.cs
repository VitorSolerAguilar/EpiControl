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
				string sql = @"INSERT INTO tb_movimentacao_estoque (tipo_movimentacao, quantidade, data_movimentacao, observacao, fk_estoque, fk_funcionario) VALUES (@tipo_movimentacao, @quantidade, @data_movimentacao, @observacao, @fk_estoque, @fk_funcionario)";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

				cmd.Parameters.AddWithValue("@tipo_movimentacao", movimentacao.tipoMovimentacao);
				cmd.Parameters.AddWithValue("@quantidade", movimentacao.quantidade);
				cmd.Parameters.AddWithValue("@data_movimentacao", movimentacao.dataMovimentacao);
				cmd.Parameters.AddWithValue("@observacao", movimentacao.observacao);
				cmd.Parameters.AddWithValue("@fk_estoque", movimentacao.estoqueId);
				cmd.Parameters.AddWithValue("@fk_funcionario", movimentacao.funcionarioId);

				cmd.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao cadastrar movimentação de estoque: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}	
		}

	}
}
