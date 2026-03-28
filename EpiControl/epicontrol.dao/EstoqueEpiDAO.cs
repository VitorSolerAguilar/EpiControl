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
	public class EstoqueEpiDAO
	{
		private MySqlConnection conexao;

		public EstoqueEpiDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		public void cadastrarEstoqueEpi(EstoqueEpi estoqueEpi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"INSERT INTO tb_estoque_epi (quantidade, localizacao, estoque_minimo, fk_epi) VALUES (@quantidade, @localizacao, @estoque_minimo, @fk_epi)";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

				cmd.Parameters.AddWithValue("@quantidade", estoqueEpi.quantidade);
				cmd.Parameters.AddWithValue("@localizacao", estoqueEpi.localizacao);
				cmd.Parameters.AddWithValue("@estoque_minimo", estoqueEpi.estoqueMinimo);
				cmd.Parameters.AddWithValue("@fk_epi", estoqueEpi.epiId);

				cmd.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao cadastrar estoque de EPI: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public DataTable listarEstoqueEpi()
		{
			try
			{
				DataTable tabelaEstoque = new DataTable();

				string sql = @"SELECT ee.id_estoque, ee.quantidade, ee.localizacao, ee.estoque_minimo, e.id_epi, e.nome AS nome_epi FROM tb_estoque_epi ee INNER JOIN tb_epi e ON ee.fk_epi = e.id_epi
                       ORDER BY e.nome;";

				MySqlCommand cmd = new MySqlCommand(sql, conexao);

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				da.Fill(tabelaEstoque);

				return tabelaEstoque;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar estoque de EPIs: " + ex.Message);
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

			try
			{
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

				return lista;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar nomes dos EPIs: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public DataTable buscarEstoqueEpiId(int idEstoque)
		{
			try
			{
				DataTable tabelaEstoque = new DataTable();

				string sql = @"SELECT ee.id_estoque, ee.quantidade, ee.localizacao, ee.estoque_minimo, ee.fk_epi, e.id_epi, e.nome AS nome_epi FROM tb_estoque_epi ee INNER JOIN tb_epi e ON ee.fk_epi = e.id_epi WHERE ee.id_estoque = @id_estoque";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);

				executacmd.Parameters.AddWithValue("@id_estoque", idEstoque);   // ← Corrigido aqui

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaEstoque);

				return tabelaEstoque;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao buscar estoque de EPI: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public void excluirEstoqueEpiId(int idEstoque)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"DELETE FROM tb_estoque_epi WHERE id_estoque = @id";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);
				cmd.Parameters.AddWithValue("@id", idEstoque);

				cmd.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao excluir registro do estoque de EPI: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public void editarEstoqueEpi(EstoqueEpi estoqueEpi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"UPDATE tb_estoque_epi SET quantidade = @quantidade, localizacao = @localizacao, estoque_minimo = @estoque_minimo, fk_epi = @fk_epi WHERE id_estoque = @id_estoque";	

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

				cmd.Parameters.AddWithValue("@quantidade", estoqueEpi.quantidade);
				cmd.Parameters.AddWithValue("@localizacao", estoqueEpi.localizacao);
				cmd.Parameters.AddWithValue("@estoque_minimo", estoqueEpi.estoqueMinimo);
				cmd.Parameters.AddWithValue("@fk_epi", estoqueEpi.epiId);
				cmd.Parameters.AddWithValue("@id_estoque", estoqueEpi.id);

				cmd.ExecuteNonQuery();

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
	}
}
