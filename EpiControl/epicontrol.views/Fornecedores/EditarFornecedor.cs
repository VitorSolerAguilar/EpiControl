using EpiControl.epicontrol.dao;
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
			FornecedorDAO dao = new FornecedorDAO();
			DataTable dt = dao.buscarFornecedorId(_idFornecedor);

			DataRow row = dt.Rows[0];

			txtNome.Text = row["nome"].ToString();
			txtCnpj.Text = row["cnpj"].ToString();
			rtbObservacoes.Text = row["observacoes"].ToString();
			txtTelefone.Text = row["telefone"].ToString();
			txtCelular.Text = row["celular"].ToString();
			txtEmailPessoal.Text = row["email"].ToString();
			txtEmailCorporativo.Text = row["email_corporativo"].ToString();

			txtCep.Text = row["cep"].ToString();
			txtRua.Text = row["rua"].ToString();
			txtNumero.Text = row["numero"].ToString();
			txtLogradouro.Text = row["logradouro"].ToString();
			txtCidade.Text = row["cidade"].ToString();
			cbxUf.Text = row["uf"].ToString();
		}
	}
}
