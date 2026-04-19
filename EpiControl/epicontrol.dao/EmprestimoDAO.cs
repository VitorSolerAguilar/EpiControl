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
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlEmprestimo = @"INSERT INTO tb_emprestimo (quantidade, data_entrega, observacoes, fk_funcionario, fk_epi)
				VALUES (@quantidade, @dataEntrega, @observacoes, @fk_funcionario, @fk_epi)";

				MySqlCommand cmdEmprestimo = new MySqlCommand(sqlEmprestimo, conexao, transaction);

				cmdEmprestimo.Parameters.AddWithValue("@quantidade", emprestimo.quantidade);
				cmdEmprestimo.Parameters.AddWithValue("@dataEntrega", emprestimo.dataEntrega);
				cmdEmprestimo.Parameters.AddWithValue("@observacoes", emprestimo.observacoes);
				cmdEmprestimo.Parameters.AddWithValue("@fk_funcionario", emprestimo.funcionarioId);
				cmdEmprestimo.Parameters.AddWithValue("@fk_epi", emprestimo.epiId);

				cmdEmprestimo.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao cadastrar empréstimo de EPI: " + ex.Message);
			}
			finally
			{
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
