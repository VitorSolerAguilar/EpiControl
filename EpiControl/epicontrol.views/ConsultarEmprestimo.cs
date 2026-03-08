using EpiControl.epicontrol.dao;
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
	public partial class frmConsultarEmprestimo : Form
	{
		public frmConsultarEmprestimo()
		{
			InitializeComponent();
		}

		private void dgvEmprestimo_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.RowIndex < 0) return;

			int idEmprestimo = Convert.ToInt32(dgvEmprestimo.Rows[e.RowIndex].Cells["id_emprestimo"].Value);
		}

		private void frmConsultarEmprestimo_Load(object sender, EventArgs e)
		{
			EmprestimoDAO dao = new EmprestimoDAO();

			dgvEmprestimo.DataSource = dao.listarEmprestimo();
		}
	}
}
