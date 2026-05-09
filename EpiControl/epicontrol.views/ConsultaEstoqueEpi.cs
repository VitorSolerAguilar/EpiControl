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
	public partial class frmConsultaEstoqueEpi : Form
	{
		public frmConsultaEstoqueEpi()
		{
			InitializeComponent();
		}

		private void frmConsultaEstoqueEpi_Load(object sender, EventArgs e)
		{
			EstoqueEpiDAO dao = new EstoqueEpiDAO();

			dgvEstoque.DataSource = dao.listarEstoqueEpi();
            dgvEstoque.Refresh();
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idEstoque = Convert.ToInt32(dgvEstoque.Rows[e.RowIndex].Cells["id_estoque"].Value);

			frmEditarEstoqueEpi frm = new frmEditarEstoqueEpi(idEstoque);
			frm.Show();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			EstoqueEpiDAO dao = new EstoqueEpiDAO();
			dgvEstoque.DataSource = dao.buscarEstoque(txtConsultaEstoque.Text);
		}
	}
}
