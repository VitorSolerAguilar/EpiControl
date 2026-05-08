using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
using Google.Protobuf.WellKnownTypes;
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
	public partial class frmCadastrarEpi : Form
	{
		public frmCadastrarEpi()
		{
			InitializeComponent();
		}

		private void frmCadastrarEpi_Load(object sender, EventArgs e)
		{
			FornecedorDAO fornecedorDAO = new FornecedorDAO();

			cbxFornecedor.DataSource = fornecedorDAO.listarNomesFornecedores();
			cbxFornecedor.DisplayMember = "nome";
			cbxFornecedor.ValueMember = "id";
		}
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				Epi epi = new Epi();

				epi.nome = txtNome.Text;
				epi.codigoInterno = txtCodigoInterno.Text;
				epi.ca = txtCa.Text;
				epi.tamanho = txtTamanho.Text;
				epi.validadeCa = Convert.ToDateTime(mtbValidadeCa.Text);
				epi.marca = txtMarca.Text;
				epi.cor = txtCor.Text;
				epi.valorUnitario = Convert.ToDecimal(txtValorUnitario.Text);

				if (rdbAtivo.Checked)
					epi.status = "Ativo";
				else if (rdbAtivo.Checked)
					epi.status = "Inativo";

				epi.categoria = cbxCategoria.Text;
				epi.fornecedorId = Convert.ToInt32(cbxFornecedor.SelectedValue);
				epi.descricao = rtbDescricao.Text;

				EpiDAO dao = new EpiDAO();
				dao.cadastrarEpi(epi);

				MessageBox.Show("Epi cadastrado com sucesso!");
				limparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar: " + ex.Message);
			}

		}
		private void limparCampos()
		{
			txtNome.Clear();
			txtCodigoInterno.Clear();
			txtCa.Clear();
			txtTamanho.Clear();
			mtbValidadeCa.Clear();
			txtMarca.Clear();
			txtCor.Clear();
			rtbDescricao.Clear();
			txtValorUnitario.Clear();
		}
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
