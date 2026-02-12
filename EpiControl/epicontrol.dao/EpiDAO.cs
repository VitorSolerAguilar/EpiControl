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
	public class EpiDAO
	{
		private MySqlConnection conexao;

		public EpiDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion(); 
		}

		#region cadastrarEpi
		public void cadastrarEpi(Epi epi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlEpi = @"INSERT INTO tb_epi (nome, codigo_interno, ca, validade_ca, status, marca, descricao, categoria) " +
					"VALUES(@nome, @codigo_interno, @ca, @validadeCa, @status, @marca, @descricao, @categoria)";

				MySqlCommand cmdEpi = new MySqlCommand(sqlEpi, conexao, transaction);

				cmdEpi.Parameters.AddWithValue("@nome", epi.nome);
				cmdEpi.Parameters.AddWithValue("@codigo_interno", epi.codigoInterno);
				cmdEpi.Parameters.AddWithValue("@ca", epi.ca);
				cmdEpi.Parameters.AddWithValue("@validadeCa", epi.validadeCa);
				cmdEpi.Parameters.AddWithValue("@status", epi.status);
				cmdEpi.Parameters.AddWithValue("@marca", epi.marca);
				cmdEpi.Parameters.AddWithValue("@descricao", epi.descricao);
				cmdEpi.Parameters.AddWithValue("@categoria", epi.categoria);

				cmdEpi.ExecuteNonQuery();
				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao cadastrar epi: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		#endregion
	}
}
