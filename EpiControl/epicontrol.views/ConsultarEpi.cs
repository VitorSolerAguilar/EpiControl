using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
using EpiControl.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpiControl.epicontrol.views
{
	public partial class frmConsultarEpi : Form
	{
		public frmConsultarEpi()
		{
			InitializeComponent();
		}

		private void frmConsultarEpi_Load(object sender, EventArgs e)
		{
			EpiDAO dao = new EpiDAO();
			dgvEpi.DataSource = dao.listarEpi();

            if (dgvEpi.Columns.Count == 0) return;

            if (dgvEpi.Columns.Contains("id_epi"))
                dgvEpi.Columns["id_epi"].HeaderText = "ID";
            if (dgvEpi.Columns.Contains("nome"))
                dgvEpi.Columns["nome"].HeaderText = "Nome";
            if (dgvEpi.Columns.Contains("codigo_interno"))
                dgvEpi.Columns["codigo_interno"].HeaderText = "Código Interno";
            if (dgvEpi.Columns.Contains("ca"))
                dgvEpi.Columns["ca"].HeaderText = "CA";
            if (dgvEpi.Columns.Contains("tamanho"))
                dgvEpi.Columns["tamanho"].HeaderText = "Tamanho";
            if (dgvEpi.Columns.Contains("validade_ca"))
                dgvEpi.Columns["validade_ca"].HeaderText = "Validade Ca";
            if (dgvEpi.Columns.Contains("status"))
                dgvEpi.Columns["status"].HeaderText = "Status";
            if (dgvEpi.Columns.Contains("marca"))
                dgvEpi.Columns["marca"].HeaderText = "Marca";
            if (dgvEpi.Columns.Contains("descricao"))
                dgvEpi.Columns["descricao"].HeaderText = "Descrição";
            if (dgvEpi.Columns.Contains("categoria"))
                dgvEpi.Columns["categoria"].HeaderText = "Categoria";
            if (dgvEpi.Columns.Contains("valor_unitario"))
                dgvEpi.Columns["valor_unitario"].HeaderText = "Valor Unitário";
            if (dgvEpi.Columns.Contains("id_fornecedor"))
                dgvEpi.Columns["id_fornecedor"].HeaderText = "ID Fornecedor";
            if (dgvEpi.Columns.Contains("fk_fornecedor"))
                dgvEpi.Columns["fk_fornecedor"].HeaderText = "ID Fornecedor";
            if (dgvEpi.Columns.Contains("fornecedor"))
                dgvEpi.Columns["fornecedor"].HeaderText = "Fornecedor";
            if (dgvEpi.Columns.Contains("cor"))
                dgvEpi.Columns["cor"].HeaderText = "Cor";
        }

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			EpiDAO dao = new EpiDAO();

			dgvEpi.DataSource = dao.buscarEpi(txtConsultaEpi.Text);
		}

		private void dgvEpi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idEpi = Convert.ToInt32(dgvEpi.Rows[e.RowIndex].Cells["id_epi"].Value);
			int idFornecedor = Convert.ToInt32(dgvEpi.Rows[e.RowIndex].Cells["id_fornecedor"].Value);

			frmEditarEpi frm = new frmEditarEpi(idEpi, idFornecedor);
			frm.Show();
		}
	}
}
