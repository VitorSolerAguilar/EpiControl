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
	public class FornecedorDAO
	{
		private MySqlConnection conexao;

		public FornecedorDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		public void cadastrarFornecedor(Fornecedor fornecedor, Endereco endereco, Contato contato)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlFornecedor = "INSERT INTO tb_fornecedor (nome, cnpj, observacoes) VALUES (@nome, @cnpj, @observacoes)";

				MySqlCommand cmdFornecedor = new MySqlCommand(sqlFornecedor, conexao, transaction);

				cmdFornecedor.Parameters.AddWithValue("@nome", fornecedor.nome);
				cmdFornecedor.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
				cmdFornecedor.Parameters.AddWithValue("@observacoes", fornecedor.observacoes);

				cmdFornecedor.ExecuteNonQuery();
				int idFornecedor = (int)cmdFornecedor.LastInsertedId;


				string sqlEndereco = @"INSERT INTO tb_endereco (cep, cidade, uf, rua, numero, logradouro, tipo, complemento, fk_fornecedor) 
					VALUES (@cep, @cidade, @uf, @rua, @numero, @logradouro, @tipo, @complemento, @fk_fornecedor)";

				MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conexao, transaction);

				cmdEndereco.Parameters.AddWithValue("@cep", endereco.cep);
				cmdEndereco.Parameters.AddWithValue("@cidade", endereco.cidade);
				cmdEndereco.Parameters.AddWithValue("@uf", endereco.uf);
				cmdEndereco.Parameters.AddWithValue("@rua", endereco.rua);
				cmdEndereco.Parameters.AddWithValue("@numero", endereco.numero);
				cmdEndereco.Parameters.AddWithValue("@logradouro", endereco.logradouro);
				cmdEndereco.Parameters.AddWithValue("@tipo", endereco.tipo);
				cmdEndereco.Parameters.AddWithValue("@complemento", endereco.complemento);
				cmdEndereco.Parameters.AddWithValue("@fk_fornecedor", idFornecedor);

				cmdEndereco.ExecuteNonQuery();


				string sqlContato = @"INSERT INTO tb_contato (telefone, celular, email, email_corporativo, fk_fornecedor) VALUES (@telefone, @celular, @email, @email_corporativo, @fk_fornecedor)";

				MySqlCommand cmdContato = new MySqlCommand(sqlContato, conexao, transaction);

				cmdContato.Parameters.AddWithValue("@telefone", contato.telefone);
				cmdContato.Parameters.AddWithValue("@celular", contato.celular);
				cmdContato.Parameters.AddWithValue("@email", contato.emailPessoal);
				cmdContato.Parameters.AddWithValue("@email_corporativo", contato.emailCorporativo);
				cmdContato.Parameters.AddWithValue("@fk_fornecedor", idFornecedor);

				cmdContato.ExecuteNonQuery();
				transaction.Commit();

			}catch(Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao cadastrar fornecedor: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public DataTable listarFornecedor()
		{
			try
			{
				DataTable tabelaFornecedor = new DataTable();

				string sql = @"SELECT f.id_fornecedor, f.nome, f.cnpj, f.observacoes, c.id_contato AS id_contato, c.telefone, c.celular, c.email, c.email_corporativo, e.id_endereco AS id_endereco, e.cep, e.rua, e.numero,
				e.logradouro, e.complemento, e.cidade, e.tipo, e.uf FROM tb_fornecedor f LEFT JOIN tb_contato c ON c.fk_fornecedor = f.id_fornecedor LEFT JOIN tb_endereco e ON e.fk_fornecedor = f.id_fornecedor ORDER BY f.nome;";

				MySqlCommand cmd = new MySqlCommand(sql, conexao);
				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				da.Fill(tabelaFornecedor);

				return tabelaFornecedor;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar fornecedores: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public DataTable buscarFornecedorId(int idFornecedor)
		{
			try
			{
				DataTable tabelaFornecedor = new DataTable();

				string sql = "SELECT " +
					"f.id_fornecedor, " +
					"f.nome, " +
					"f.cnpj," +
					"f.observacoes," +					
					"" +
					"c.id_contato," +
					"c.telefone, " +
					"c.celular, " +
					"c.email, " +
					"c.email_corporativo, " +
					"" +
					"e.id_endereco," +
					"e.cep, " +
					"e.rua, " +
					"e.numero, " +
					"e.complemento, " +
					"e.logradouro, " +
					"e.cidade, " +
					"e.tipo," +
					"e.uf " +
					"FROM tb_fornecedor f LEFT JOIN tb_contato c ON c.fk_fornecedor = f.id_fornecedor LEFT JOIN tb_endereco e ON e.fk_fornecedor = f.id_fornecedor ORDER BY f.nome;";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@id", idFornecedor);

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaFornecedor);

				return tabelaFornecedor;
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

		public void editarFornecedor(Fornecedor fornecedor, Endereco endereco, Contato contato)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlFornecedor = @"UPDATE tb_fornecedor SET nome=@nome, cnpj=@cnpj, observacoes=@observacoes WHERE id_fornecedor=@id_fornecedor";

				MySqlCommand cmdFornecedor = new MySqlCommand(sqlFornecedor, conexao, transaction);

				cmdFornecedor.Parameters.AddWithValue("@nome", fornecedor.nome);
				cmdFornecedor.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
				cmdFornecedor.Parameters.AddWithValue("@observacoes", fornecedor.observacoes);
				cmdFornecedor.Parameters.AddWithValue("@id_fornecedor", fornecedor.id);

				cmdFornecedor.ExecuteNonQuery();

				string sqlEndereco = @"UPDATE tb_endereco SET cep=@cep, cidade=@cidade, uf=@uf, rua=@rua, numero=@numero, logradouro=@logradouro, tipo=@tipo, complemento=@complemento WHERE id_endereco=@id_endereco";

				MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conexao, transaction);

				cmdEndereco.Parameters.AddWithValue("@cep", endereco.cep);
				cmdEndereco.Parameters.AddWithValue("@cidade", endereco.cidade);
				cmdEndereco.Parameters.AddWithValue("@uf", endereco.uf);
				cmdEndereco.Parameters.AddWithValue("@rua", endereco.rua);
				cmdEndereco.Parameters.AddWithValue("@numero", endereco.numero);
				cmdEndereco.Parameters.AddWithValue("@logradouro", endereco.logradouro);
				cmdEndereco.Parameters.AddWithValue("@tipo", endereco.tipo);
				cmdEndereco.Parameters.AddWithValue("@complemento", endereco.complemento);
				cmdEndereco.Parameters.AddWithValue("@id_endereco", endereco.id);

				cmdEndereco.ExecuteNonQuery();

				string sqlContato = @"UPDATE tb_contato SET telefone=@telefone, celular=@celular, email=@email, email_corporativo=@email_corporativo WHERE id_contato=@id_contato";

				MySqlCommand cmdContato = new MySqlCommand(sqlContato, conexao, transaction);

				cmdContato.Parameters.AddWithValue("@telefone", contato.telefone);
				cmdContato.Parameters.AddWithValue("@celular", contato.celular);
				cmdContato.Parameters.AddWithValue("@email", contato.emailPessoal);
				cmdContato.Parameters.AddWithValue("@email_corporativo", contato.emailCorporativo);
				cmdContato.Parameters.AddWithValue("@id_contato", contato.id);

				cmdContato.ExecuteNonQuery();

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

		public void excluirFornecedorId(int idFornecedor)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlContato = @"DELETE FROM tb_contato WHERE fk_fornecedor = @id";

				MySqlCommand cmdContato = new MySqlCommand(sqlContato, conexao, transaction);
				cmdContato.Parameters.AddWithValue("@id", idFornecedor);
				cmdContato.ExecuteNonQuery();

				string sqlEndereco = @"DELETE FROM tb_endereco WHERE fk_fornecedor = @id";

				MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conexao, transaction);
				cmdEndereco.Parameters.AddWithValue("@id", idFornecedor);
				cmdEndereco.ExecuteNonQuery();

				string sqlFornecedor = @"DELETE FROM tb_fornecedor WHERE id_fornecedor = @id";

				MySqlCommand cmdFuncionario = new MySqlCommand(sqlFornecedor, conexao, transaction);
				cmdFuncionario.Parameters.AddWithValue("@id", idFornecedor);

				cmdFuncionario.ExecuteNonQuery();
				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao excluir fornecedor: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public List<Fornecedor> listarNomesFornecedores()
		{
			List<Fornecedor> lista = new List<Fornecedor>();

			string sql = "SELECT id_fornecedor, nome FROM tb_fornecedor ORDER BY nome";

			MySqlCommand cmd = new MySqlCommand(sql, conexao);
			conexao.Open();

			MySqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				lista.Add(new Fornecedor
				{
					id = reader.GetInt32("id_fornecedor"),
					nome = reader.GetString("nome")
				});
			}

			conexao.Close();
			return lista;
		}

		public DataTable buscarFornecedorNome(string nomeFornecedor)
		{
			try
			{
				DataTable tabelaFornecedor = new DataTable();

				string sql = "SELECT " +
					"f.id_fornecedor, " +
					"f.nome, " +
					"f.cnpj, " +
					"f.observacoes, " +

					"c.id_contato AS id_contato, " +
					"c.telefone, " +
					"c.celular, " +
					"c.email, " +
					"c.email_corporativo, " +

					"e.id_endereco AS id_endereco, " +
					"e.cep, " +
					"e.rua, " +
					"e.numero, " +
					"e.complemento, " +
					"e.logradouro, " +
					"e.cidade, " +
					"e.uf " +

					"FROM tb_fornecedor f " +
					"LEFT JOIN tb_contato c ON c.fk_fornecedor = f.id_fornecedor " +
					"LEFT JOIN tb_endereco e ON e.fk_fornecedor = f.id_fornecedor " +
					"WHERE f.nome LIKE @nome";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@nome", "%" + nomeFornecedor + "%");

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaFornecedor);

				return tabelaFornecedor;
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

