using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
using Mysqlx.Crud;
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
	public partial class frmEditarEpi : Form
	{
		private int _idFornecedor, _idEpi;
		public frmEditarEpi(int idEpi, int idFornecedor)
		{
			InitializeComponent();

			_idEpi = idEpi;
			_idFornecedor = idFornecedor;
			carregarEpi();
		}
		private void frmEditarEpi_Load(object sender, EventArgs e)
		{
			FornecedorDAO fornecedorDAO = new FornecedorDAO();

			cbxFornecedor.DataSource = fornecedorDAO.listarNomesFornecedores();
			cbxFornecedor.DisplayMember = "nome";
			cbxFornecedor.ValueMember = "id";
		}
		public void carregarEpi()
		{
			try
			{
				EpiDAO dao = new EpiDAO();
				DataTable dt = dao.buscarEpiId(_idEpi);

				DataRow row = dt.Rows[0];

				txtNome.Text = row["nome"].ToString();
				txtCodigoInterno.Text = row["codigo_interno"].ToString();
				txtCa.Text = row["ca"].ToString();
				txtTamanho.Text = row["tamanho"].ToString();
				mtbValidadeCa.Text = row["validade_ca"].ToString();
				txtMarca.Text = row["marca"].ToString();
				txtCor.Text = row["nome"].ToString();

				string status = row["status"].ToString();

				rdbAtivo.Checked = status == "Ativo";
				rdbInativo.Checked = status == "Inativo";

				cbxCategoria.Text = row["categoria"].ToString();
				cbxFornecedor.SelectedValue = row["fk_fornecedor"];
				rtbDescricao.Text = row["descricao"].ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar epi: " + ex);
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			try
			{
				Epi epi = new Epi();

				epi.id = _idEpi;
				epi.nome = txtNome.Text;
				epi.codigoInterno = txtCodigoInterno.Text;
				epi.ca = txtCa.Text;
				epi.tamanho = txtTamanho.Text;
				epi.validadeCa = Convert.ToDateTime(mtbValidadeCa.Text);
				epi.marca = txtMarca.Text;
				epi.cor = txtCor.Text;
				epi.categoria = cbxCategoria.Text;
				epi.descricao = rtbDescricao.Text;

				if (rdbAtivo.Checked)
					epi.status = "Ativo";
				else if (rdbInativo.Checked)
					epi.status = "Inativo";

				epi.fornecedorId = (int)cbxFornecedor.SelectedValue;

				EpiDAO dao = new EpiDAO();
				dao.editarEpi(epi);

				MessageBox.Show("EPI atualizado com sucesso!");
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao editar epi: " + ex);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				EpiDAO dao = new EpiDAO();

				dao.excluirEpiId(_idEpi);

				MessageBox.Show("Epi excluido");
				Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro ao excluir epi: " + ex.Message);
			}
		}
	}
}
