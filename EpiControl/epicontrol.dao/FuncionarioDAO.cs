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
		public void cadastrarDocumentos(Funcionario funcionario)
		{
			try
			{
				string sql = "INSERT INTO tb_funcionario(nome, rg, cpf, pis, dataNascimento, numeroCTPS, serieCtps, estadoCivil, genero, nomeMae, nomePai, inscricaoETitulo, zona, secao, municipio, uf, dataEmissao)" +
					"VALUES(@nome, @rg, @cpf, @pis, @dataNascimento, @numeroCTPS, @serieCtps, @estadoCivil, @genero, @nomeMae, @nomePai, @inscricaoETitulo, @zona, @secao, @municipio, @uf, @dataEmissao)";

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
				mySqlCommand.ExecuteNonQuery();

				MessageBox.Show("Funcionario cadastrado com sucesso");


			}
			catch (Exception ex)
			{

				MessageBox.Show("Erro: " + ex);
			}
		}
		#endregion

	}
}
