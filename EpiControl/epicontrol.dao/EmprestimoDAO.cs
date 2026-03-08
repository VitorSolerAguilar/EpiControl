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
	}
}
