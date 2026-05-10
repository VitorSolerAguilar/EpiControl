using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.dao
{
	public class EmprestimoDAO
	{
		private MySqlConnection conexao;

		public EmprestimoDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

        public void cadastrarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                conexao.Open();
                MySqlTransaction transaction = conexao.BeginTransaction();

                string sqlVerifica = @"SELECT SUM(quantidade) as quantidade_total FROM tb_estoque_epi WHERE fk_epi = @fk_epi";

                MySqlCommand cmdVerifica = new MySqlCommand(sqlVerifica, conexao, transaction);
                cmdVerifica.Parameters.AddWithValue("@fk_epi", emprestimo.epiId);

                object resultado = cmdVerifica.ExecuteScalar();

                if (resultado == null || resultado is DBNull)
                {
                    transaction.Rollback();
                    conexao.Close();
                    MessageBox.Show("Nenhum estoque cadastrado para este EPI.");
                    return;
                }

                int quantidadeAtual = Convert.ToInt32(resultado);

                if (quantidadeAtual < emprestimo.quantidade)
                {
                    transaction.Rollback();
                    conexao.Close();
                    MessageBox.Show($"Estoque insuficiente. Disponível: {quantidadeAtual}, Solicitado: {emprestimo.quantidade}.");
                    return;
                }

                string sqlEmprestimo = @"INSERT INTO tb_emprestimo (quantidade, data_entrega, observacoes, fk_funcionario, fk_epi) VALUES (@quantidade, @dataEntrega, @observacoes, @fk_funcionario, @fk_epi)";

                MySqlCommand cmdEmprestimo = new MySqlCommand(sqlEmprestimo, conexao, transaction);
                cmdEmprestimo.Parameters.AddWithValue("@quantidade", emprestimo.quantidade);
                cmdEmprestimo.Parameters.AddWithValue("@dataEntrega", emprestimo.dataEntrega);
                cmdEmprestimo.Parameters.AddWithValue("@observacoes", emprestimo.observacoes);
                cmdEmprestimo.Parameters.AddWithValue("@fk_funcionario", emprestimo.funcionarioId);
                cmdEmprestimo.Parameters.AddWithValue("@fk_epi", emprestimo.epiId);

                cmdEmprestimo.ExecuteNonQuery();

                string sqlEstoque = @"UPDATE tb_estoque_epi SET quantidade = quantidade - @quantidade WHERE fk_epi = @fk_epi LIMIT 1";

                MySqlCommand cmdEstoque = new MySqlCommand(sqlEstoque, conexao, transaction);
                cmdEstoque.Parameters.AddWithValue("@quantidade", emprestimo.quantidade);
                cmdEstoque.Parameters.AddWithValue("@fk_epi", emprestimo.epiId);

                cmdEstoque.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar empréstimo de EPI: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public DataTable listarEmprestimo()
		{
			try
			{
				DataTable tabelaEmprestimo = new DataTable();

				string sql = @"SELECT em.id_emprestimo, f.nome AS funcionario, e.nome AS epi, em.quantidade, em.data_entrega, em.observacoes FROM tb_emprestimo em 
				INNER JOIN tb_funcionario f ON em.fk_funcionario = f.id_funcionario INNER JOIN tb_epi e ON em.fk_epi = e.id_epi ORDER BY em.data_entrega DESC";

				MySqlCommand cmd = new MySqlCommand(sql, conexao);

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				da.Fill(tabelaEmprestimo);

				return tabelaEmprestimo;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar empréstimos: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public DataTable buscarEmprestimo(string termoBusca)
		{
			try
			{
				DataTable tabelaEmprestimo = new DataTable();

				string sql = "SELECT " + "  e.id_emprestimo, " + "  e.quantidade, " + "  e.data_entrega, " + "  e.fk_funcionario AS id_funcionario, " + "  e.fk_epi AS id_epi, " + "  f.nome AS funcionario, " + "  epi.nome AS epi, " + "  epi.codigo_interno, " + "  epi.ca " + "FROM tb_emprestimo e " + "LEFT JOIN tb_funcionario f ON f.id_funcionario = e.fk_funcionario " + "LEFT JOIN tb_epi epi ON epi.id_epi = e.fk_epi " + "WHERE " + "      f.nome LIKE @termo " + "   OR epi.nome LIKE @termo " + "   OR epi.codigo_interno LIKE @termo " + "   OR epi.ca LIKE @termo " + "   OR CAST(e.id_emprestimo AS CHAR) LIKE @termo " + "   OR CAST(e.quantidade AS CHAR) LIKE @termo ";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaEmprestimo);

				return tabelaEmprestimo;
			}
			catch
			{
				return null;
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}
	}
}
