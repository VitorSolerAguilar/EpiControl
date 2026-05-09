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
			dgvCurso.DataSource = cursoDAO.listarCursos();

            if (dgvCurso.Columns.Count == 0) return;

            if (dgvCurso.Columns.Contains("id_curso"))
                dgvCurso.Columns["id_curso"].HeaderText = "ID";
            if (dgvCurso.Columns.Contains("nome"))
                dgvCurso.Columns["nome"].HeaderText = "Nome";
            if (dgvCurso.Columns.Contains("carga_horaria"))
                dgvCurso.Columns["carga_horaria"].HeaderText = "Carga Horária";
            if (dgvCurso.Columns.Contains("descricao"))
                dgvCurso.Columns["descricao"].HeaderText = "Descrição";
            if (dgvCurso.Columns.Contains("validade_meses"))
                dgvCurso.Columns["validade_meses"].HeaderText = "Validade";
        }

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			dgvCurso.DataSource = cursoDAO.buscarCurso(txtConsultaNomeTreinamento.Text);
		}

		private void dgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idCurso = Convert.ToInt32(dgvCurso.Rows[e.RowIndex].Cells["id_curso"].Value);

			frmEditarTreinamento frm = new frmEditarTreinamento(idCurso);
			frm.Show();
		}
	}
}
