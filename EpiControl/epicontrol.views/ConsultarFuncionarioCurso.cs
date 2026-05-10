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
	public partial class frmConsultarFuncionarioCurso : Form
	{
		public frmConsultarFuncionarioCurso()
		{
			InitializeComponent();
		}

        FuncionarioCursoDAO funcionarioCursoDAO = new FuncionarioCursoDAO();

        private void frmConsultarFuncionarioCurso_Load(object sender, EventArgs e)
		{
			dgvFuncionarioCurso.DataSource = funcionarioCursoDAO.listarFuncionarioCursos();

            dgvFuncionarioCurso.Columns["id_funcionario_curso"].HeaderText = "ID";
            dgvFuncionarioCurso.Columns["data_inicio"].HeaderText = "Data Início";
            dgvFuncionarioCurso.Columns["data_conclusao"].HeaderText = "Data Conclusão";
            dgvFuncionarioCurso.Columns["fk_funcionario"].HeaderText = "Funcionário";
            dgvFuncionarioCurso.Columns["fk_curso"].HeaderText = "Curso";
        }

		private void dgvFuncionarioCurso_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idFuncionarioCurso = Convert.ToInt32(dgvFuncionarioCurso.Rows[e.RowIndex].Cells["id_funcionario_curso"].Value);
			int idCurso = Convert.ToInt32(dgvFuncionarioCurso.Rows[e.RowIndex].Cells["fk_curso"].Value);
			int idFuncionario = Convert.ToInt32(dgvFuncionarioCurso.Rows[e.RowIndex].Cells["fk_funcionario"].Value);

			frmEditarFuncionarioCurso frm = new frmEditarFuncionarioCurso(idFuncionarioCurso, idCurso, idFuncionario);
            frm.ShowDialog();

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvFuncionarioCurso.DataSource = funcionarioCursoDAO.listarFuncionarioCursos();
        }
    }
}
