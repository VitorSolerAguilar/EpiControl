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
	public class FuncionarioDAO
	{
		private MySqlConnection conexao;

		public FuncionarioDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		#region cadastrarDocumentos
		public int cadastrarDocumentos(Funcionario funcionario)
		{
			try
			{
				string sql = "INSERT INTO tb_funcionario(nome, rg, cpf, pis, data_nascimento, numero_ctps, serie_ctps, estado_civil, genero, nome_mae, nome_pai, inscricao_titulo_eleitor, zona, secao, municipio, uf, data_emissao)" +
					"VALUES(@nome, @rg, @cpf, @pis, @dataNascimento, @numeroCTPS, @serieCtps, @estadoCivil, @genero, @nomeMae, @nomePai, @inscricaoETitulo, @zona, @secao, @municipio, @uf, @dataEmissao); SELECT LAST_INSERT_ID();";

				MySqlCommand mySqlCommand = new MySqlCommand(sql, conexao);

				mySqlCommand.Parameters.AddWithValue("@nome", funcionario.nome);
				mySqlCommand.Parameters.AddWithValue("@rg", funcionario.rg);
				mySqlCommand.Parameters.AddWithValue("@cpf", funcionario.cpf);
				mySqlCommand.Parameters.AddWithValue("@pis", funcionario.pis);
				mySqlCommand.Parameters.AddWithValue("@dataNascimento", funcionario.dataNascimento);
				mySqlCommand.Parameters.AddWithValue("@numeroCTPS", funcionario.numeroCTPS);
				mySqlCommand.Parameters.AddWithValue("@serieCtps", funcionario.serieCtps);
				mySqlCommand.Parameters.AddWithValue("@estadoCivil", funcionario.estadoCivil);
				mySqlCommand.Parameters.AddWithValue("@genero", funcionario.genero);
				mySqlCommand.Parameters.AddWithValue("@nomeMae", funcionario.nomeMae);
				mySqlCommand.Parameters.AddWithValue("@nomePai", funcionario.nomePai);
				mySqlCommand.Parameters.AddWithValue("@inscricaoETitulo", funcionario.inscricaoETitulo);
				mySqlCommand.Parameters.AddWithValue("@zona", funcionario.zona);
				mySqlCommand.Parameters.AddWithValue("@secao", funcionario.secao);
				mySqlCommand.Parameters.AddWithValue("@municipio", funcionario.municipio);
				mySqlCommand.Parameters.AddWithValue("@uf", funcionario.uf);
				mySqlCommand.Parameters.AddWithValue("@dataEmissao", funcionario.dataEmissao);

				conexao.Open();
				int idFuncionario = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				MessageBox.Show("Funcionario cadastrado com sucesso");
				return idFuncionario;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex);
				return 0;
			}
		}
		#endregion

		#region cadastrarEndereco
		public void cadastrarEndereco(Endereco endereco)
		{
			try
			{
				string sql = "INSERT INTO tb_endereco(cep, rua, numero, logradouro, cidade, uf, bairro, tipo, complemento, fk_funcionario) " +
					"VALUES(@cep, @rua, @numero, @logradouro, @cidade, @uf, @bairro, @tipo, @complemento, @fk_funcionario) ";

				MySqlCommand mySqlCommand = new MySqlCommand(sql, conexao);

				mySqlCommand.Parameters.AddWithValue("@cep", endereco.cep);
				mySqlCommand.Parameters.AddWithValue("@rua", endereco.rua);
				mySqlCommand.Parameters.AddWithValue("@numero", endereco.numero);
				mySqlCommand.Parameters.AddWithValue("@logradouro", endereco.logradouro);
				mySqlCommand.Parameters.AddWithValue("@cidade", endereco.cidade);
				mySqlCommand.Parameters.AddWithValue("@uf", endereco.uf);
				mySqlCommand.Parameters.AddWithValue("@bairro", endereco.bairro);
				mySqlCommand.Parameters.AddWithValue("@tipo", endereco.tipo);
				mySqlCommand.Parameters.AddWithValue("@complemento", endereco.complemento);
				mySqlCommand.Parameters.AddWithValue("@fk_funcionario", endereco.fkFuncionario);

				conexao.Open();
				MessageBox.Show("ID FUNCIONARIO: " + endereco.fkFuncionario);
				mySqlCommand.ExecuteNonQuery();

				MessageBox.Show("Endereço cadastrado com sucesso");
			}
			catch (Exception ex)
			{
				MessageBox.Show("erro " + ex);
			}
		}
		#endregion
	}
}
