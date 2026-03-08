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

namespace EpiControl.Views
{
	public partial class frmEditarFornecedor : Form
	{
		private int _idFornecedor, _idEndereco, _idContato;
		public frmEditarFornecedor(int idFornecedor, int idEndereco, int idContato)
		{
			InitializeComponent();

			_idFornecedor = idFornecedor;
			_idEndereco = idEndereco;
			_idContato = idContato;
			carregarFornecedor();
		}

		public void carregarFornecedor()
		{
			try
			{
				FornecedorDAO dao = new FornecedorDAO();
				DataTable dt = dao.buscarFornecedorId(_idFornecedor);

				DataRow row = dt.Rows[0];

				txtNome.Text = row["nome"].ToString();
				mtbCnpj.Text = row["cnpj"].ToString();
				rtbObservacoes.Text = row["observacoes"].ToString();
				mtbTelefone.Text = row["telefone"].ToString();
				mtbCelular.Text = row["celular"].ToString();
				txtEmailPessoal.Text = row["email"].ToString();
				txtEmailCorporativo.Text = row["email_corporativo"].ToString();

				mtbCep.Text = row["cep"].ToString();
				txtRua.Text = row["rua"].ToString();
				txtNumero.Text = row["numero"].ToString();
				txtLogradouro.Text = row["logradouro"].ToString();
				txtCidade.Text = row["cidade"].ToString();
				txtUf.Text = row["uf"].ToString();
				cbxTipo.Text = row["tipo"].ToString();
				rtbComplemento.Text = row["complemento"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar fornecedores: " + ex);
			}
		}

		private void btn_voltar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				FornecedorDAO dao = new FornecedorDAO();
				dao.excluirFornecedorId(_idFornecedor);

				MessageBox.Show("Fornecedor excluido!");
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir: " + ex.Message);

			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			try
			{
				Fornecedor fornecedor = new Fornecedor();
				fornecedor.nome = txtNome.Text;
				fornecedor.cnpj = mtbCnpj.Text;
				fornecedor.observacoes = rtbObservacoes.Text;

				Endereco endereco = new Endereco();
				endereco.id = _idEndereco;
				endereco.cep = mtbCep.Text;
				endereco.cidade = txtCidade.Text.Trim();
				endereco.uf = txtUf.Text;
				endereco.rua = txtRua.Text.Trim();
				endereco.numero = txtNumero.Text.Trim();
				endereco.logradouro = txtLogradouro.Text.Trim();
				endereco.tipo = cbxTipo.Text;
				endereco.complemento = rtbComplemento.Text.Trim();

				Contato contato = new Contato();
				contato.id = _idContato;
				contato.telefone = mtbTelefone.Text;
				contato.celular = mtbCelular.Text;
				contato.emailPessoal = txtEmailPessoal.Text.Trim();
				contato.emailCorporativo = txtEmailCorporativo.Text.Trim();

				FornecedorDAO dao = new FornecedorDAO();
				dao.editarFornecedor(fornecedor, endereco, contato);

				MessageBox.Show("Fornecedor atualizado!");
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao alterar fornecedor: " + ex);
			}
		}

		private void frmEditarFornecedor_Load(object sender, EventArgs e)
		{

		}
	}
}
