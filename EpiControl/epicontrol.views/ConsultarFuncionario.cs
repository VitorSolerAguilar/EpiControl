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
	public partial class frmConsultarFuncionario : Form
	{

        public frmConsultarFuncionario()
		{
			InitializeComponent();
        }

		private void ConsultarFuncionario_Load(object sender, EventArgs e)
		{
			FuncionarioDAO dao = new FuncionarioDAO();

			dgvFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idFuncionario = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["id_funcionario"].Value);

			int idEndereco = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["id_endereco"].Value);

			int idContato = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["id_contato"].Value);

			frmEditarFuncionario frm = new frmEditarFuncionario(idFuncionario, idEndereco, idContato);
			frm.Show();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			FuncionarioDAO dao = new FuncionarioDAO();
			dgvFuncionario.DataSource = dao.buscarFuncionario(txtConsultaNome.Text);
		}
	}
}
