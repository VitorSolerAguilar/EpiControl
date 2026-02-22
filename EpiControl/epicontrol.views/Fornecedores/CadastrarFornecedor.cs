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

namespace EpiControl.Views.Fornecedores
{
	public partial class frmCadastrarFornecedor : Form
	{
		public frmCadastrarFornecedor()
		{
			InitializeComponent();
		}

		private void btnConsultarCep_Click(object sender, EventArgs e)
		{
			try
			{
				string cep = mtbCep.Text;
				string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

				DataSet dados = new DataSet();
				dados.ReadXml(xml);

				txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
				txtUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
				txtRua.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
				rtbComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
				txtLogradouro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao consultar cep: " + ex.Message);
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				Fornecedor fornecedor = new Fornecedor();

				fornecedor.nome = txtNome.Text;
				fornecedor.cnpj = mtbCnpj.Text;
				fornecedor.observacoes = rtbObservacao.Text;

				Endereco endereco = new Endereco();

				endereco.cep = mtbCep.Text;
				endereco.cidade = txtCidade.Text;
				endereco.uf = txtUf.Text;
				endereco.rua = txtRua.Text;
				endereco.numero = txtNumero.Text;
				endereco.logradouro = txtLogradouro.Text;
				endereco.tipo = cbxTipo.Text;
				endereco.complemento = rtbComplemento.Text;


				Contato contato = new Contato();

				contato.telefone = mtbTelefone.Text;
				contato.celular = mtbCelular.Text;
				contato.emailPessoal = txtEmailPessoal.Text;
				contato.emailCorporativo = txtEmailPessoal.Text;

				FornecedorDAO dao = new FornecedorDAO();
				dao.cadastrarFornecedor(fornecedor, endereco, contato);

				MessageBox.Show("Fornecedor cadastrado com sucesso!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar: " + ex.Message);
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
