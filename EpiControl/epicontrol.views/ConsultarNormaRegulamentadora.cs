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
	public partial class frmConsultarNormaRegulamentadora : Form
	{
		public frmConsultarNormaRegulamentadora()
		{
			InitializeComponent();
		}

		private void frmConsultarNormaRegulamentadora_Load(object sender, EventArgs e)
		{
			NormaRegulamentadoraDAO dao = new NormaRegulamentadoraDAO();

			dgvNormaRegulamentadora.DataSource = dao.listarNormaRegulamentadora();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			NormaRegulamentadoraDAO dao = new NormaRegulamentadoraDAO();
			dgvNormaRegulamentadora.DataSource = dao.buscarNorma(txtConsultaNorma.Text);
		}

		private void dgvNormaRegulamentadora_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idNorma = Convert.ToInt32(dgvNormaRegulamentadora.Rows[e.RowIndex].Cells["id_norma_regulamentadora"].Value);

			frmEditarNormaRegulamentadora frm = new frmEditarNormaRegulamentadora(idNorma);
			frm.Show();
		}
	}
}
