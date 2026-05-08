using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
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
    public partial class frmEditarEstoqueEpi : Form
    {
        private int _idEstoqueEpi;
        public frmEditarEstoqueEpi(int idEstoque)
        {
            InitializeComponent();

            _idEstoqueEpi = idEstoque;
            carregarEstoque();
        }

        private void frmEditarEstoqueEpi_Load(object sender, EventArgs e)
        {
            EstoqueEpiDAO estoqueEpiDAO = new EstoqueEpiDAO();

            cbxEpi.DataSource = estoqueEpiDAO.listarNomesEpi();
            cbxEpi.DisplayMember = "nome";
            cbxEpi.ValueMember = "id";
        }

        public void carregarEstoque()
        {
            try
            {
                EstoqueEpiDAO dao = new EstoqueEpiDAO();
                DataTable dt = dao.buscarEstoqueEpiId(_idEstoqueEpi);

                DataRow row = dt.Rows[0];

                txtQuantidade.Text = row["quantidade"].ToString();
                rtbLocalizacao.Text = row["localizacao"].ToString();
                txtEstoqueMinimo.Text = row["estoque_minimo"].ToString();

                cbxEpi.SelectedValue = Convert.ToInt32(row["id_epi"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estoque: " + ex);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                EstoqueEpiDAO dao = new EstoqueEpiDAO();
                dao.excluirEstoqueEpiId(_idEstoqueEpi);

                MessageBox.Show("Registro excluído com sucesso!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir registro: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueEpi estoque = new EstoqueEpi();

                estoque.id = _idEstoqueEpi;
                estoque.quantidade = Convert.ToInt32(txtQuantidade.Text);
                estoque.localizacao = rtbLocalizacao.Text;
                estoque.estoqueMinimo = Convert.ToInt32(txtEstoqueMinimo.Text);
                estoque.epiId = Convert.ToInt32(cbxEpi.SelectedValue);

                EstoqueEpiDAO dao = new EstoqueEpiDAO();
                dao.editarEstoqueEpi(estoque);

                MessageBox.Show("Estoque atualizado com sucesso!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar estoque: " + ex.Message);
            }
        }
    }
}
