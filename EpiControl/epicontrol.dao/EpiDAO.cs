using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EpiControl.epicontrol.dao
{
	public class EpiDAO
	{
		private MySqlConnection conexao;

		public EpiDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		public void cadastrarEpi(Epi epi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlEpi = @"INSERT INTO tb_epi (nome, codigo_interno, ca, validade_ca, status, marca, descricao, categoria, tamanho, cor, fk_fornecedor) " +
					"VALUES(@nome, @codigo_interno, @ca, @validadeCa, @status, @marca, @descricao, @categoria, @tamanho, @cor, @fk_fornecedor)";

				MySqlCommand cmdEpi = new MySqlCommand(sqlEpi, conexao, transaction);

				cmdEpi.Parameters.AddWithValue("@nome", epi.nome);
				cmdEpi.Parameters.AddWithValue("@codigo_interno", epi.codigoInterno);
				cmdEpi.Parameters.AddWithValue("@ca", epi.ca);
				cmdEpi.Parameters.AddWithValue("@validadeCa", epi.validadeCa);
				cmdEpi.Parameters.AddWithValue("@status", epi.status);
				cmdEpi.Parameters.AddWithValue("@marca", epi.marca);
				cmdEpi.Parameters.AddWithValue("@descricao", epi.descricao);
				cmdEpi.Parameters.AddWithValue("@categoria", epi.categoria);
				cmdEpi.Parameters.AddWithValue("@tamanho", epi.tamanho);
				cmdEpi.Parameters.AddWithValue("@cor", epi.cor);
				cmdEpi.Parameters.AddWithValue("@fk_fornecedor", epi.fornecedorId);

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

		public DataTable listarEpi()
		{
			try
			{
				DataTable tabelaEpi = new DataTable();

				string sql = @"SELECT e.id_epi, e.nome, e.codigo_interno, e.ca, e.tamanho, e.validade_ca, e.status, e.marca, e.descricao, e.categoria, e.fk_fornecedor AS id_fornecedor, f.nome AS fornecedor FROM tb_epi e INNER JOIN tb_fornecedor f ON e.fk_fornecedor = f.id_fornecedor;";

				MySqlCommand cmd = new MySqlCommand(sql, conexao);
				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				da.Fill(tabelaEpi);

				return tabelaEpi;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar epi's: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public void editarEpi(Epi epi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlEpi = @"UPDATE tb_epi SET nome = @nome, codigo_interno = @codigo_interno, ca = @ca, tamanho = @tamanho, validade_ca = @validade_ca, marca = @marca, cor = @cor, status = @status, categoria = @categoria, descricao = @descricao, fk_fornecedor = @fk_fornecedor WHERE id_epi = @id_epi";

				MySqlCommand cmdEpi = new MySqlCommand(sqlEpi, conexao, transaction);
				cmdEpi.Parameters.AddWithValue("@nome", epi.nome);
				cmdEpi.Parameters.AddWithValue("@codigo_interno", epi.codigoInterno);
				cmdEpi.Parameters.AddWithValue("@ca", epi.ca);
				cmdEpi.Parameters.AddWithValue("@tamanho", epi.tamanho);
				cmdEpi.Parameters.AddWithValue("@validade_ca", epi.validadeCa);
				cmdEpi.Parameters.AddWithValue("@marca", epi.marca);
				cmdEpi.Parameters.AddWithValue("@cor", epi.cor);
				cmdEpi.Parameters.AddWithValue("@status", epi.status);
				cmdEpi.Parameters.AddWithValue("@categoria", epi.categoria);
				cmdEpi.Parameters.AddWithValue("@descricao", epi.descricao);
				cmdEpi.Parameters.AddWithValue("@fk_fornecedor", epi.fornecedorId);
				cmdEpi.Parameters.AddWithValue("@id_epi", epi.id);

				cmdEpi.ExecuteNonQuery();

				transaction.Commit();

			}
			catch
			{
				transaction.Rollback();
				throw;
			}
			finally
			{
				conexao.Close();
			}
		}

		public DataTable buscarEpiId(int idEpi)
		{
			try
			{
				DataTable tabelaEpi = new DataTable();

				string sql = @"SELECT e.id_epi, e.nome, e.codigo_interno, e.ca, e.validade_ca, e.status, e.marca, e.descricao, e.categoria, e.tamanho, e.fk_fornecedor, f.nome AS nome_fornecedor FROM tb_epi e INNER JOIN tb_fornecedor f ON e.fk_fornecedor = f.id_fornecedor WHERE e.id_epi = @id_epi";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@id_epi", idEpi);

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaEpi);

				return tabelaEpi;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao buscar epi: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public DataTable buscarEpiNome(string nomeEpi)
		{
			try
			{
				DataTable tabelaEpi = new DataTable();

				string sql = "SELECT e.id_epi, e.nome, e.codigo_interno, e.ca, e.validade_ca, e.status, e.marca, e.categoria, e.tamanho, e.fk_fornecedor AS id_fornecedor, f.nome AS fornecedor FROM tb_epi e LEFT JOIN tb_fornecedor f ON e.fk_fornecedor = f.id_fornecedor WHERE e.nome LIKE @nome";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@nome", "%" + nomeEpi + "%");

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaEpi);

				return tabelaEpi;
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

		public List<Epi> listarNomesEpi()
		{
			List<Epi> lista = new List<Epi>();

			string sql = "SELECT id_epi, nome FROM tb_epi ORDER BY nome";

			MySqlCommand cmd = new MySqlCommand(sql, conexao);
			conexao.Open();

			MySqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				lista.Add(new Epi
				{
					id = reader.GetInt32("id_epi"),
					nome = reader.GetString("nome")
				});
			}

			conexao.Close();
			return lista;
		}

		public void excluirEpiId(int idEpi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"DELETE FROM tb_epi WHERE id_epi = @id";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);
				cmd.Parameters.AddWithValue("@id", idEpi);

				cmd.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao excluir EPI: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}
	}
}
