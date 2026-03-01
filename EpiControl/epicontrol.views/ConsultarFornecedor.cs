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
	public partial class frmConsultarFornecedor : Form
	{
		public frmConsultarFornecedor()
		{
			InitializeComponent();
		}

		private void frmConsultarFornecedor_Load(object sender, EventArgs e)
		{
			FornecedorDAO dao = new FornecedorDAO();

			dgvFornecedor.DataSource = dao.listarFornecedor();
		}

		private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idFornecedor = Convert.ToInt32(dgvFornecedor.Rows[e.RowIndex].Cells["id_fornecedor"].Value);

			int idEndereco = Convert.ToInt32(dgvFornecedor.Rows[e.RowIndex].Cells["id_endereco"].Value);

			int idContato = Convert.ToInt32(dgvFornecedor.Rows[e.RowIndex].Cells["id_contato"].Value);

			frmEditarFornecedor frm = new frmEditarFornecedor(idFornecedor, idEndereco, idContato);
			frm.Show();
		}
	}
}
