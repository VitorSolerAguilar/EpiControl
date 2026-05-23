using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.dao
{
	public class FuncionarioDAO
	{
		private MySqlConnection conexao;

		public FuncionarioDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		public void cadastrarFuncionario(Funcionario funcionario, Endereco endereco, Contato contato)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlFuncionario = @"INSERT INTO tb_funcionario (nome, data_nascimento, estado_civil, nacionalidade, genero, nome_mae, nome_pai, pis, rg, cpf, matricula, cargo, status)
					 VALUES (@nome, @data_nascimento, @estado_civil, @nacionalidade, @genero, @nome_mae, @nome_pai, @pis, @rg, @cpf, @matricula, @cargo, @status)";

				MySqlCommand cmdFuncionario = new MySqlCommand(sqlFuncionario, conexao, transaction);

				cmdFuncionario.Parameters.AddWithValue("@nome", funcionario.nome);
				cmdFuncionario.Parameters.AddWithValue("@data_nascimento", funcionario.dataNascimento);
				cmdFuncionario.Parameters.AddWithValue("@estado_civil", funcionario.estadoCivil);
				cmdFuncionario.Parameters.AddWithValue("@nacionalidade", funcionario.nacionalidade);
				cmdFuncionario.Parameters.AddWithValue("@genero", funcionario.genero);
				cmdFuncionario.Parameters.AddWithValue("@nome_mae", funcionario.nomeMae);
				cmdFuncionario.Parameters.AddWithValue("@nome_pai", funcionario.nomePai);
				cmdFuncionario.Parameters.AddWithValue("@pis", funcionario.pisPasep);
				cmdFuncionario.Parameters.AddWithValue("@rg", funcionario.rg);
				cmdFuncionario.Parameters.AddWithValue("@cpf", funcionario.cpf);
				cmdFuncionario.Parameters.AddWithValue("@matricula", funcionario.matricula);
				cmdFuncionario.Parameters.AddWithValue("@cargo", funcionario.cargo);
				cmdFuncionario.Parameters.AddWithValue("@status", funcionario.status);
				cmdFuncionario.ExecuteNonQuery();

				int idFuncionario = (int)cmdFuncionario.LastInsertedId;

				
				string sqlEndereco = @"INSERT INTO tb_endereco (cep, cidade, uf, rua, numero, logradouro, tipo, complemento, fk_funcionario)
					VALUES (@cep, @cidade, @uf, @rua, @numero, @logradouro, @tipo, @complemento, @fk_funcionario)";

				MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conexao, transaction);

				cmdEndereco.Parameters.AddWithValue("@cep", endereco.cep);
				cmdEndereco.Parameters.AddWithValue("@cidade", endereco.cidade);
				cmdEndereco.Parameters.AddWithValue("@uf", endereco.uf);
				cmdEndereco.Parameters.AddWithValue("@rua", endereco.rua);
				cmdEndereco.Parameters.AddWithValue("@numero", endereco.numero);
				cmdEndereco.Parameters.AddWithValue("@logradouro", endereco.logradouro);
				cmdEndereco.Parameters.AddWithValue("@tipo", endereco.tipo);
				cmdEndereco.Parameters.AddWithValue("@complemento", endereco.complemento);
				cmdEndereco.Parameters.AddWithValue("@fk_funcionario", idFuncionario);

				cmdEndereco.ExecuteNonQuery();

				string sqlContato = @"INSERT INTO tb_contato (telefone, celular, email, email_corporativo, fk_funcionario) VALUES (@telefone, @celular, @email, @email_corporativo, @fk_funcionario)";

				MySqlCommand cmdContato = new MySqlCommand(sqlContato, conexao, transaction);

				cmdContato.Parameters.AddWithValue("@telefone", contato.telefone);
				cmdContato.Parameters.AddWithValue("@celular", contato.celular);
				cmdContato.Parameters.AddWithValue("@email", contato.emailPessoal);
				cmdContato.Parameters.AddWithValue("@email_corporativo", contato.emailCorporativo);
				cmdContato.Parameters.AddWithValue("@fk_funcionario", idFuncionario);

				cmdContato.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				MessageBox.Show("Erro ao cadastrar funcionario: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public void excluirFuncionarioId(int idFuncionario)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlContato = @"DELETE FROM tb_contato WHERE fk_funcionario = @id";

				MySqlCommand cmdContato = new MySqlCommand(sqlContato, conexao, transaction);
				cmdContato.Parameters.AddWithValue("@id", idFuncionario);
				cmdContato.ExecuteNonQuery();

				string sqlEndereco = @"DELETE FROM tb_endereco WHERE fk_funcionario = @id";

				MySqlCommand cmdEndereco = new MySqlCommand(sqlEndereco, conexao, transaction);
				cmdEndereco.Parameters.AddWithValue("@id", idFuncionario);
				cmdEndereco.ExecuteNonQuery();

				string sqlFuncionario = @"DELETE FROM tb_funcionario WHERE id_funcionario = @id";

				MySqlCommand cmdFuncionario = new MySqlCommand(sqlFuncionario, conexao, transaction);
				cmdFuncionario.Parameters.AddWithValue("@id", idFuncionario);

				cmdFuncionario.ExecuteNonQuery();
				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				MessageBox.Show("Erro ao excluir funcionario: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

        public DataTable listarFuncionarios()
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();

                string sql = "SELECT " +
                    "f.id_funcionario, " +
                    "f.nome, " +
                    "f.data_nascimento," +
                    "f.pis," +
                    "f.nome_mae," +
                    "f.nome_pai," +
                    "f.nacionalidade," +
                    "f.matricula," +
                    "f.status," +
                    "f.estado_civil," +
                    "f.rg," +
                    "f.cpf, " +
                    "f.cargo, " +
                    "f.genero," +
                    "c.id_contato," +
                    "c.telefone, " +
                    "c.celular, " +
                    "c.email, " +
                    "c.email_corporativo, " +
                    "e.id_endereco," +
                    "e.cep, " +
                    "e.rua, " +
                    "e.numero, " +
                    "e.logradouro," +
                    "e.complemento, " +
                    "e.cidade, " +
                    "e.tipo," +
                    "e.uf " +
                    "FROM tb_funcionario f " +
                    "LEFT JOIN tb_contato c ON c.fk_funcionario = f.id_funcionario " +
                    "LEFT JOIN tb_endereco e ON e.fk_funcionario = f.id_funcionario " +
                    "WHERE f.status = 'Ativo' " +
                    "ORDER BY f.nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                return tabelaFuncionario;
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

        public DataTable buscarFuncionarioId(int idFuncionario)
		{
			try
			{
				DataTable tabelaFuncionario = new DataTable();

				string sql = "SELECT " +
					"f.id_funcionario, " +
					"f.nome, " +
					"f.estado_civil," +
					"f.data_nascimento," +
					"f.nacionalidade," +
					"f.cpf, " +
					"f.pis," +
					"f.nome_pai," +
					"f.nome_mae," +
					"f.genero," +
					"f.cargo, " +
					"f.status, " +
					"f.matricula," +
					"f.rg," +
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
					"FROM tb_funcionario f " +
					"LEFT JOIN tb_contato c ON c.fk_funcionario = f.id_funcionario " +
					"LEFT JOIN tb_endereco e ON e.fk_funcionario = f.id_funcionario " +
					"WHERE f.id_funcionario = @id;";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@id", idFuncionario);

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaFuncionario);

				return tabelaFuncionario;
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

        public DataTable buscarFuncionario(string termoBusca)
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();

                bool buscandoInativo = termoBusca.Trim().ToLower() == "inativo";

                string filtroStatus = buscandoInativo
                    ? "f.status = 'Inativo'"
                    : "f.status = 'Ativo'";

                string filtroBusca = buscandoInativo
                    ? ""
                    : "AND (f.nome LIKE @termo " +
                      "   OR f.cpf LIKE @termo " +
                      "   OR f.cargo LIKE @termo " +
                      "   OR c.telefone LIKE @termo " +
                      "   OR c.celular LIKE @termo " +
                      "   OR c.email LIKE @termo " +
                      "   OR c.email_corporativo LIKE @termo " +
                      "   OR e.cep LIKE @termo " +
                      "   OR e.rua LIKE @termo " +
                      "   OR e.numero LIKE @termo " +
                      "   OR e.complemento LIKE @termo " +
                      "   OR e.logradouro LIKE @termo " +
                      "   OR e.cidade LIKE @termo " +
                      "   OR e.uf LIKE @termo)";

                string sql = "SELECT " +
                    "f.id_funcionario, " +
                    "f.nome, " +
                    "f.cpf, " +
                    "f.cargo, " +
                    "f.status, " +
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
                    "FROM tb_funcionario f " +
                    "LEFT JOIN tb_contato c ON c.fk_funcionario = f.id_funcionario " +
                    "LEFT JOIN tb_endereco e ON e.fk_funcionario = f.id_funcionario " +
                    $"WHERE {filtroStatus} {filtroBusca};";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                if (!buscandoInativo)
                    executacmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                return tabelaFuncionario;
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

        public void editarFuncionario(Funcionario funcionario, Endereco endereco, Contato contato)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlFuncionario = @"UPDATE tb_funcionario SET nome=@nome, data_nascimento=@data_nascimento, estado_civil=@estado_civil, nacionalidade=@nacionalidade, genero=@genero, nome_mae=@nome_mae,
				nome_pai=@nome_pai, pis=@pis, rg=@rg, cpf=@cpf, matricula=@matricula, cargo=@cargo, status=@status WHERE id_funcionario=@id_funcionario";

				MySqlCommand cmdFuncionario = new MySqlCommand(sqlFuncionario, conexao, transaction);

				cmdFuncionario.Parameters.AddWithValue("@nome", funcionario.nome);
				cmdFuncionario.Parameters.AddWithValue("@data_nascimento", funcionario.dataNascimento);
				cmdFuncionario.Parameters.AddWithValue("@estado_civil", funcionario.estadoCivil);
				cmdFuncionario.Parameters.AddWithValue("@nacionalidade", funcionario.nacionalidade);
				cmdFuncionario.Parameters.AddWithValue("@genero", funcionario.genero);
				cmdFuncionario.Parameters.AddWithValue("@nome_mae", funcionario.nomeMae);
				cmdFuncionario.Parameters.AddWithValue("@nome_pai", funcionario.nomePai);
				cmdFuncionario.Parameters.AddWithValue("@pis", funcionario.pisPasep);
				cmdFuncionario.Parameters.AddWithValue("@rg", funcionario.rg);
				cmdFuncionario.Parameters.AddWithValue("@cpf", funcionario.cpf);
				cmdFuncionario.Parameters.AddWithValue("@matricula", funcionario.matricula);
				cmdFuncionario.Parameters.AddWithValue("@cargo", funcionario.cargo);
				cmdFuncionario.Parameters.AddWithValue("@status", funcionario.status);
				cmdFuncionario.Parameters.AddWithValue("@id_funcionario", funcionario.id);

				cmdFuncionario.ExecuteNonQuery();

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

        public List<Funcionario> listarNomesFuncionarios()
        {
            List<Funcionario> lista = new List<Funcionario>();

            string sql = "SELECT id_funcionario, nome FROM tb_funcionario WHERE status = 'Ativo' ORDER BY nome";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Funcionario
                {
                    id = reader.GetInt32("id_funcionario"),
                    nome = reader.GetString("nome")
                });
            }

            conexao.Close();
            return lista;
        }
    }
}
