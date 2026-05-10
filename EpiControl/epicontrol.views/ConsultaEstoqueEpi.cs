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
	public partial class frmConsultaEstoqueEpi : Form
	{
		public frmConsultaEstoqueEpi()
		{
			InitializeComponent();
		}

        EstoqueEpiDAO estoqueEpiDAO = new EstoqueEpiDAO();

        private void frmConsultaEstoqueEpi_Load(object sender, EventArgs e)
		{
			dgvEstoque.DataSource = estoqueEpiDAO.listarEstoqueEpi();

            if (dgvEstoque.Columns.Contains("id_estoque"))
                dgvEstoque.Columns["id_estoque"].HeaderText = "ID";
            if (dgvEstoque.Columns.Contains("nome_epi"))
                dgvEstoque.Columns["nome_epi"].HeaderText = "Epi";
            if (dgvEstoque.Columns.Contains("epi"))
                dgvEstoque.Columns["epi"].HeaderText = "Epi";
            if (dgvEstoque.Columns.Contains("quantidade"))
                dgvEstoque.Columns["quantidade"].HeaderText = "Quantidade";
            if (dgvEstoque.Columns.Contains("estoque_minimo"))
                dgvEstoque.Columns["estoque_minimo"].HeaderText = "Estoque Mínimo";
            if (dgvEstoque.Columns.Contains("localizacao"))
                dgvEstoque.Columns["localizacao"].HeaderText = "Localização";
            if (dgvEstoque.Columns.Contains("id_epi"))
                dgvEstoque.Columns["id_epi"].HeaderText = "Epi Id";
            if (dgvEstoque.Columns.Contains("fk_epi"))
                dgvEstoque.Columns["fk_epi"].HeaderText = "Epi Fk";
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int idEstoque = Convert.ToInt32(dgvEstoque.Rows[e.RowIndex].Cells["id_estoque"].Value);

			frmEditarEstoqueEpi frm = new frmEditarEstoqueEpi(idEstoque);
            frm.ShowDialog();

            AtualizarGrid();
        }

		private void btnConsultar_Click(object sender, EventArgs e)
		{			
			dgvEstoque.DataSource = estoqueEpiDAO.buscarEstoque(txtConsultaEstoque.Text);
		}

        private void AtualizarGrid()
        {
            dgvEstoque.DataSource = estoqueEpiDAO.listarEstoqueEpi();
        }
    }
}
