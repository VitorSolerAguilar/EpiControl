using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace EpiControl.epicontrol.views
{
	public partial class CadastrarFuncionario : Form
	{

		public CadastrarFuncionario()
		{
			InitializeComponent();
		}

		private int _idFuncionarioAtual = 0;
		private void btnSalvarFuncionario_Click_1(object sender, EventArgs e)
		{
			Funcionario funcionario = new Funcionario();

			funcionario.nome = txtNome.Text;
			funcionario.rg = mtbRg.Text;
			funcionario.cpf = mtbCpf.Text;
			funcionario.pis = txtPis.Text;
			funcionario.dataNascimento = DateTime.Parse(mtmDataNascimento.Text);
			funcionario.numeroCTPS = txtNumeroCtps.Text;
			funcionario.serieCtps = txtSerieCtps.Text;
			funcionario.estadoCivil = cbxEstadoCivil.Text;
			funcionario.genero = cbxGenero.Text;
			funcionario.nomeMae = txtNomeMae.Text;
			funcionario.nomePai = txtNomePai.Text;
			funcionario.inscricaoETitulo = txtInscricaoETitutulo.Text;
			funcionario.zona = txtZona.Text;
			funcionario.secao = txtSecao.Text;
			funcionario.municipio = txtMunicipio.Text;
			funcionario.uf = cbxUf.Text;
			funcionario.dataEmissao = DateTime.Parse(mtbDataEmissao.Text);

			FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
			_idFuncionarioAtual = funcionarioDAO.cadastrarDocumentos(funcionario);
		}

		private void tncConsultarCep_Click(object sender, EventArgs e)
		{
			try
			{
				string cep = mtbCep.Text;
				string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

				DataSet dados = new DataSet();
				dados.ReadXml(xml);

				txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
				txtLogradouro.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
				txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
				txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
				txtUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		private void btnSalvarEndereco_Click(object sender, EventArgs e)
		{
			Endereco endereco = new Endereco();

			endereco.rua = txtLogradouro.Text;
			endereco.cep = mtbCep.Text;
			endereco.bairro = txtBairro.Text;
			endereco.uf = txtUf.Text;
			endereco.cidade = txtCidade.Text;
			endereco.complemento = txtComplemento.Text;
			endereco.numero = int.Parse(txtNumero.Text);
			endereco.tipo = cbxTipo.Text;
			endereco.fkFuncionario = _idFuncionarioAtual;

			FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
			funcionarioDAO.cadastrarEndereco(endereco);
		}
		
	}
}
