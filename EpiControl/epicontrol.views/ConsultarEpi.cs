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

			dgvEmprestimo.DataSource = dao.listarEpi();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			EpiDAO dao = new EpiDAO();

			dgvEmprestimo.DataSource = dao.buscarEpiNome(txtConsultaNome.Text);
		}

		private void dgvEpi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idEpi = Convert.ToInt32(dgvEmprestimo.Rows[e.RowIndex].Cells["id_epi"].Value);
			int idFornecedor = Convert.ToInt32(dgvEmprestimo.Rows[e.RowIndex].Cells["id_fornecedor"].Value);

			frmEditarEpi frm = new frmEditarEpi(idEpi, idFornecedor);
			frm.Show();
		}
	}
}
