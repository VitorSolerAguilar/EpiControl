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
	public class FuncionarioDAO
	{
		private MySqlConnection conexao;

		public FuncionarioDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		#region cadastrarFuncionario
		public void cadastrarFuncionario(Funcionario funcionario, Endereco endereco, Contato contato)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sqlFuncionario = @"INSERT INTO tb_funcionario (nome, data_nascimento, estado_civil, nacionalidade, genero, nome_mae, nome_pai, numero_titulo_eleitor, pis, rg, cpf, matricula, cargo, status)
					 VALUES (@nome, @data_nascimento, @estado_civil, @nacionalidade, @genero, @nome_mae, @nome_pai, @numero_titulo_eleitor, @pis, @rg, @cpf, @matricula, @cargo, @status)";

				MySqlCommand cmdFuncionario = new MySqlCommand(sqlFuncionario, conexao, transaction);

				cmdFuncionario.Parameters.AddWithValue("@nome", funcionario.nome);
				cmdFuncionario.Parameters.AddWithValue("@data_nascimento", funcionario.dataNascimento);
				cmdFuncionario.Parameters.AddWithValue("@estado_civil", funcionario.estadoCivil);
				cmdFuncionario.Parameters.AddWithValue("@nacionalidade", funcionario.nacionalidade);
				cmdFuncionario.Parameters.AddWithValue("@genero", funcionario.genero);
				cmdFuncionario.Parameters.AddWithValue("@nome_mae", funcionario.nomeMae);
				cmdFuncionario.Parameters.AddWithValue("@nome_pai", funcionario.nomePai);
				cmdFuncionario.Parameters.AddWithValue("@numero_titulo_eleitor", funcionario.tituloEleitor);
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
				throw new Exception("Erro ao cadastrar funcionário completo: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}
		#endregion
		
	}
}
