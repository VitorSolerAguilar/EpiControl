using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.dto;
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

		public DataTable buscarEpi(string termoBusca)
		{
			try
			{
				DataTable tabelaEpi = new DataTable();

				string sql = @"SELECT e.id_epi, e.nome, e.codigo_interno, e.ca, e.validade_ca, e.status, e.marca, e.categoria, e.tamanho, e.fk_fornecedor AS id_fornecedor, f.nome AS fornecedor FROM tb_epi e LEFT JOIN tb_fornecedor f ON e.fk_fornecedor = f.id_fornecedor WHERE e.nome LIKE @termo OR e.codigo_interno LIKE @termo OR e.ca LIKE @termo OR e.marca LIKE @termo OR e.categoria LIKE @termo OR e.tamanho LIKE @termo OR f.nome LIKE @termo OR e.status LIKE @termo";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

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

		public (Funcionario funcionario, List<dto.FichaEpiDTO> itens) ObterFichaEpiFuncionario(int idFuncionario)
		{
			Funcionario funcionario = null;
			List<dto.FichaEpiDTO> itens = new List<dto.FichaEpiDTO>();

			try
			{
				string sql = @"SELECT f.id_funcionario, f.nome, f.data_nascimento, f.estado_civil, f.nacionalidade, f.genero, f.nome_mae, f.nome_pai, f.pis, f.rg, f.cpf, f.matricula, f.cargo, f.status, emp.id_emprestimo, emp.data_entrega, emp.quantidade, epi.id_epi, epi.nome AS descricao_epi, epi.ca AS ca, epi.codigo_interno AS codigo_interno FROM tb_funcionario f INNER JOIN tb_emprestimo emp ON emp.fk_funcionario = f.id_funcionario INNER JOIN tb_epi epi ON epi.id_epi = emp.fk_epi WHERE f.id_funcionario = @idFuncionario ORDER BY emp.data_entrega;";

				MySqlCommand cmd = new MySqlCommand(sql, conexao);
				cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);

				conexao.Open();

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						if (funcionario == null)
						{
							funcionario = new Funcionario
							{
								id = reader.GetInt32("id_funcionario"),
								nome = reader.GetString("nome"),
								dataNascimento = reader.GetDateTime("data_nascimento"),
								estadoCivil = reader["estado_civil"] != DBNull.Value ? reader["estado_civil"].ToString() : null,
								nacionalidade = reader["nacionalidade"] != DBNull.Value ? reader["nacionalidade"].ToString() : null,
								genero = reader["genero"] != DBNull.Value ? reader["genero"].ToString() : null,
								nomeMae = reader["nome_mae"] != DBNull.Value ? reader["nome_mae"].ToString() : null,
								nomePai = reader["nome_pai"] != DBNull.Value ? reader["nome_pai"].ToString() : null,
								pisPasep = reader["pis"] != DBNull.Value ? reader["pis"].ToString() : null,
								rg = reader["rg"] != DBNull.Value ? reader["rg"].ToString() : null,
								cpf = reader["cpf"] != DBNull.Value ? reader["cpf"].ToString() : null,
								matricula = reader["matricula"] != DBNull.Value ? reader["matricula"].ToString() : null,
								cargo = reader["cargo"] != DBNull.Value ? reader["cargo"].ToString() : null,
								status = reader["status"] != DBNull.Value ? reader["status"].ToString() : null
							};
						}

						var item = new dto.FichaEpiDTO
						{
							idEmprestimo = reader.GetInt32("id_emprestimo"),
							idFuncionario = reader.GetInt32("id_funcionario"),
							idEpi = reader.GetInt32("id_epi"),
							descricaoEpi = reader.GetString("descricao_epi"),
							ca = reader["ca"] != DBNull.Value ? reader["ca"].ToString() : "",
							codigoInterno = reader["codigo_interno"] != DBNull.Value ? reader["codigo_interno"].ToString() : "",
							dataEntrega = reader.GetDateTime("data_entrega"),
							quantidade = reader.GetInt32("quantidade")
						};

						itens.Add(item);
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao obter ficha de EPI: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}

			return (funcionario, itens);
		}
	}
}
