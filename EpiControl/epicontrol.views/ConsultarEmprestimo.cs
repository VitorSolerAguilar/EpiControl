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

            if (dgvEmprestimo.Columns.Count == 0) return;

            if (dgvEmprestimo.Columns.Contains("id_emprestimo"))
                dgvEmprestimo.Columns["id_emprestimo"].HeaderText = "ID";
            if (dgvEmprestimo.Columns.Contains("funcionario"))
                dgvEmprestimo.Columns["funcionario"].HeaderText = "Funcionário";
            if (dgvEmprestimo.Columns.Contains("epi"))
                dgvEmprestimo.Columns["epi"].HeaderText = "EPI";
            if (dgvEmprestimo.Columns.Contains("quantidade"))
                dgvEmprestimo.Columns["quantidade"].HeaderText = "Quantidade";
            if (dgvEmprestimo.Columns.Contains("data_entrega"))
                dgvEmprestimo.Columns["data_entrega"].HeaderText = "Data Entrega";
            if (dgvEmprestimo.Columns.Contains("observacoes"))
                dgvEmprestimo.Columns["observacoes"].HeaderText = "Observações";
            if (dgvEmprestimo.Columns.Contains("fk_funcionario"))
                dgvEmprestimo.Columns["fk_funcionario"].HeaderText = "ID Funcionário";
            if (dgvEmprestimo.Columns.Contains("fk_epi"))
                dgvEmprestimo.Columns["fk_epi"].HeaderText = "ID Epi FK";
            if (dgvEmprestimo.Columns.Contains("id_funcionario"))
                dgvEmprestimo.Columns["id_funcionario"].HeaderText = "ID Funcionário";
            if (dgvEmprestimo.Columns.Contains("id_epi"))
                dgvEmprestimo.Columns["id_epi"].HeaderText = "ID epi";
            if (dgvEmprestimo.Columns.Contains("codigo_interno"))
                dgvEmprestimo.Columns["codigo_interno"].HeaderText = "Código Interno";
            if (dgvEmprestimo.Columns.Contains("ca"))
                dgvEmprestimo.Columns["ca"].HeaderText = "Ca";
        }

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			EmprestimoDAO dao = new EmprestimoDAO();
			dgvEmprestimo.DataSource = dao.buscarEmprestimo(txtConsultaEmprestimo.Text);
		}
	}
}
