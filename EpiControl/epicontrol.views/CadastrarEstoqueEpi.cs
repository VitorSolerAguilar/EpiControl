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
    public partial class frmCadastrarEstoqueEpi : Form
    {
        public frmCadastrarEstoqueEpi()
        {
            InitializeComponent();
        }

        private void frmCadastrarEstoqueEpi_Load(object sender, EventArgs e)
        {
            EstoqueEpiDAO estoqueEpiDAO = new EstoqueEpiDAO();

            cbxEpi.DataSource = estoqueEpiDAO.listarNomesEpi();
            cbxEpi.DisplayMember = "nome";
            cbxEpi.ValueMember = "id";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxEpi.SelectedValue == null || cbxEpi.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo EPI obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxEpi.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
                {
                    MessageBox.Show("Campo QUANTIDADE obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantidade.Focus();
                    return;
                }

                int epiSelecionado = Convert.ToInt32(cbxEpi.SelectedValue);

                EstoqueEpiDAO estoqueEpiDAO = new EstoqueEpiDAO();

                if (estoqueEpiDAO.epiJaCadastrado(epiSelecionado))
                {
                    MessageBox.Show("Este EPI já possui um estoque cadastrado. Use a opção de edição para alterar a quantidade.", "EPI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxEpi.Focus();
                    return;
                }

                EstoqueEpi estoqueEpi = new EstoqueEpi();

                estoqueEpi.epiId = Convert.ToInt32(cbxEpi.SelectedValue);
                estoqueEpi.quantidade = Convert.ToInt32(txtQuantidade.Text);
                estoqueEpi.estoqueMinimo = string.IsNullOrWhiteSpace(txtEstoqueMinimo.Text) ? 0 : Convert.ToInt32(txtEstoqueMinimo.Text);
                estoqueEpi.localizacao = rtbLocalizacao.Text;

                estoqueEpiDAO.cadastrarEstoqueEpi(estoqueEpi);

                MessageBox.Show("Estoque cadastrado com sucesso!");
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar Estoque: " + ex.Message);
            }
        }

        private void limparCampos()
        {
            txtQuantidade.Clear();
            txtEstoqueMinimo.Clear();
            rtbLocalizacao.Clear();
        }
    }
}
