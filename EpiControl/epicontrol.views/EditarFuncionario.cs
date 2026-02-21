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

namespace EpiControl.Views
{
	public partial class frmEditarFuncionario : Form
	{
		private int _idFuncionario;

		public frmEditarFuncionario(int idFuncionario)
		{
			InitializeComponent();

			_idFuncionario = idFuncionario;
			CarregarFuncionario();
		}

		private void CarregarFuncionario()
		{
			FuncionarioDAO dao = new FuncionarioDAO();
			DataTable dt = dao.buscarFuncionarioId(_idFuncionario);

			if (dt == null || dt.Rows.Count == 0)
			{
				MessageBox.Show("Funcionário não encontrado.");
				return;
			}

			DataRow row = dt.Rows[0];

			txtNome.Text = row["nome"].ToString();
			txtCpf.Text = row["cpf"].ToString();
			txtCargo.Text = row["cargo"].ToString();

			rdbAtivo.Checked = row["status"].ToString() == "Ativo";
			rdbInativo.Checked = row["status"].ToString() == "Inativo";

			txtTelefone.Text = row["telefone"].ToString();
			txtCelular.Text = row["celular"].ToString();
			txtEmailPessoal.Text = row["email"].ToString();
			txtEmailCorporativo.Text = row["email_corporativo"].ToString();

			txtCep.Text = row["cep"].ToString();
			txtRua.Text = row["rua"].ToString();
			txtNumero.Text = row["numero"].ToString();
			rtbComplemento.Text = row["complemento"].ToString();
			txtLogradouro.Text = row["bairro"].ToString();
			txtCidade.Text = row["cidade"].ToString();
			txtUf.Text = row["uf"].ToString();
		}

	}
}
