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
	public partial class frmConsultarCurso : Form
	{
		public frmConsultarCurso()
		{
			InitializeComponent();
		}
		CursoDAO cursoDAO = new CursoDAO();

		private void frmConsultarCurso_Load(object sender, EventArgs e)
		{
			dgvTreinamento.DataSource = cursoDAO.listarCursos();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			dgvTreinamento.DataSource = cursoDAO.buscarCursoPorNome(txtConsultaNomeTreinamento.Text);
		}

		private void dgvTreinamento_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idCurso = Convert.ToInt32(dgvTreinamento.Rows[e.RowIndex].Cells["id_curso"].Value);

			frmEditarCurso frm = new frmEditarCurso(idCurso);
			frm.Show();
		}
	}
}
