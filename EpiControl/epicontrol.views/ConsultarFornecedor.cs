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

            if(dgvFornecedor.Columns.Count == 0) return;

            if (dgvFornecedor.Columns.Contains("id_fornecedor"))
                dgvFornecedor.Columns["id_fornecedor"].HeaderText = "ID";
            if (dgvFornecedor.Columns.Contains("nome"))
                dgvFornecedor.Columns["nome"].HeaderText = "Nome";
            if (dgvFornecedor.Columns.Contains("cnpj"))
                dgvFornecedor.Columns["cnpj"].HeaderText = "Cnpj";
            if (dgvFornecedor.Columns.Contains("observacoes"))
                dgvFornecedor.Columns["observacoes"].HeaderText = "Observações";
            if (dgvFornecedor.Columns.Contains("id_contato"))
                dgvFornecedor.Columns["id_contato"].HeaderText = "ID Contato";
            if (dgvFornecedor.Columns.Contains("telefone"))
                dgvFornecedor.Columns["telefone"].HeaderText = "Telefone";
            if (dgvFornecedor.Columns.Contains("celular"))
                dgvFornecedor.Columns["celular"].HeaderText = "Celular";
            if (dgvFornecedor.Columns.Contains("email"))
                dgvFornecedor.Columns["email"].HeaderText = "Email";
            if (dgvFornecedor.Columns.Contains("email_corporativo"))
                dgvFornecedor.Columns["email_corporativo"].HeaderText = "Email Corporativo";
            if (dgvFornecedor.Columns.Contains("id_endereco"))
                dgvFornecedor.Columns["id_endereco"].HeaderText = "ID Endereço";
            if (dgvFornecedor.Columns.Contains("cep"))
                dgvFornecedor.Columns["cep"].HeaderText = "Cep";
            if (dgvFornecedor.Columns.Contains("rua"))
                dgvFornecedor.Columns["rua"].HeaderText = "Rua";
            if (dgvFornecedor.Columns.Contains("numero"))
                dgvFornecedor.Columns["numero"].HeaderText = "Número";
            if (dgvFornecedor.Columns.Contains("complemento"))
                dgvFornecedor.Columns["complemento"].HeaderText = "Complemento";
            if (dgvFornecedor.Columns.Contains("logradouro"))
                dgvFornecedor.Columns["logradouro"].HeaderText = "Logradouro";
            if (dgvFornecedor.Columns.Contains("cidade"))
                dgvFornecedor.Columns["cidade"].HeaderText = "Cidade";
            if (dgvFornecedor.Columns.Contains("tipo"))
                dgvFornecedor.Columns["tipo"].HeaderText = "Tipo";
            if (dgvFornecedor.Columns.Contains("uf"))
                dgvFornecedor.Columns["uf"].HeaderText = "Uf";
        }
		
		private void btnConsultar_Click(object sender, EventArgs e)
		{
			FornecedorDAO dao = new FornecedorDAO();

			dgvFornecedor.DataSource = dao.buscarFornecedor(txtConsultaNome.Text);
		}

		private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
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
