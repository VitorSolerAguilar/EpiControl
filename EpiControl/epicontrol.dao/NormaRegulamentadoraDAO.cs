using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EpiControl.epicontrol.dao
{
	public  class NormaRegulamentadoraDAO
	{
		private MySqlConnection conexao;

		public NormaRegulamentadoraDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		public void cadastrarNormaRegulamentadora(NormaRegulamentadora normaRegulamentadora)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();
			try
			{
				string sqlNormaRegulamentadora = @"INSERT INTO tb_norma_regulamentadora(codigo_nr, titulo, descricao, link_mte, data_vigencia) 
				VALUES (@codigo_nr, @titulo, @descricao, @link_mte, @data_vigencia)";

				MySqlCommand cmdNormaRegulamentadora  = new MySqlCommand(sqlNormaRegulamentadora, conexao, transaction);
				cmdNormaRegulamentadora.Parameters.AddWithValue("@codigo_nr", normaRegulamentadora.codigoNr);
				cmdNormaRegulamentadora.Parameters.AddWithValue("@titulo", normaRegulamentadora.titulo);
				cmdNormaRegulamentadora.Parameters.AddWithValue("@descricao", normaRegulamentadora.descricao);
				cmdNormaRegulamentadora.Parameters.AddWithValue("@link_mte", normaRegulamentadora.linkMte);
				cmdNormaRegulamentadora.Parameters.AddWithValue("@data_vigencia", normaRegulamentadora.dataVigencia);

				cmdNormaRegulamentadora.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao cadastrar norma: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public void excluirNormaRegulamentadora(int idNormaRegulamentadora)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlNormaRegulamentadora = @"DELETE FROM tb_norma_regulamentadora WHERE id_norma_regulamentadora = @id";

				MySqlCommand cmdNormaRegulamentadora = new MySqlCommand(sqlNormaRegulamentadora, conexao, transaction);
				cmdNormaRegulamentadora.Parameters.AddWithValue("@id", idNormaRegulamentadora);

				cmdNormaRegulamentadora.ExecuteNonQuery();
				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao excluir norma: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public DataTable listarNormaRegulamentadora()
		{
			try
			{
				DataTable tabelaNorma = new DataTable();

				string sql = @"SELECT * FROM tb_norma_regulamentadora";

				MySqlCommand cmd = new MySqlCommand(sql, conexao);
				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				da.Fill(tabelaNorma);

				return tabelaNorma;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar normas: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public DataTable buscarNormaRegulamentadoraId(int idNormaRegulamentadora)
		{
			try
			{
				DataTable tabelaNorma = new DataTable();

				string sql = @"SELECT id_norma_regulamentadora, codigo_nr, titulo, descricao, link_mte, data_vigencia FROM tb_norma_regulamentadora WHERE id_norma_regulamentadora = @id_norma";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@id_norma", idNormaRegulamentadora);

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaNorma);

				return tabelaNorma;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao buscar norma regulamentadora: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public void editarNormaRegulamentadora(NormaRegulamentadora norma)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"UPDATE tb_norma_regulamentadora SET codigo_nr = @codigo_nr, titulo = @titulo, descricao = @descricao, link_mte = @link_mte, data_vigencia = @data_vigencia WHERE id_norma_regulamentadora = @id";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

				cmd.Parameters.AddWithValue("@codigo_nr", norma.codigoNr);
				cmd.Parameters.AddWithValue("@titulo", norma.titulo);
				cmd.Parameters.AddWithValue("@descricao", norma.descricao);
				cmd.Parameters.AddWithValue("@link_mte", norma.linkMte);
				cmd.Parameters.AddWithValue("@data_vigencia", norma.dataVigencia);
				cmd.Parameters.AddWithValue("@id", norma.id);

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
