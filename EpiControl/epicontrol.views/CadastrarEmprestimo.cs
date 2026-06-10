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
    public partial class frmCadastrarEmprestimo : Form
    {
        public frmCadastrarEmprestimo()
        {
            InitializeComponent();
        }

        private void CadastrarEmprestimo_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            EpiDAO epiDAO = new EpiDAO();

            cbxEpi.DataSource = epiDAO.listarNomesEpi();
            cbxEpi.DisplayMember = "nome";
            cbxEpi.ValueMember = "id";

            cbxFuncionario.DataSource = funcionarioDAO.listarNomesFuncionarios();
            cbxFuncionario.DisplayMember = "nome";
            cbxFuncionario.ValueMember = "id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFuncionario.SelectedValue == null || cbxFuncionario.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo FUNCIONÁRIO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxFuncionario.Focus();
                    return;
                }

                if (cbxEpi.SelectedValue == null || cbxEpi.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo EPI obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxEpi.Focus();
                    return;
                }

                if (nudQuantidade.Value <= 0)
                {
                    MessageBox.Show("Campo QUANTIDADE obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudQuantidade.Focus();
                    return;
                }

                Emprestimo emprestimo = new Emprestimo();

                emprestimo.funcionarioId = Convert.ToInt32(cbxFuncionario.SelectedValue);
                emprestimo.epiId = Convert.ToInt32(cbxEpi.SelectedValue);

                if (mtbDataEmprestimo.Text.Length < 10 || mtbDataEmprestimo.Text.Contains("_"))
                {
                    MessageBox.Show("Campo DATA EMRPRESTIMO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbDataEmprestimo.Focus();
                    return;
                }
                else
                {
                    emprestimo.dataEntrega = Convert.ToDateTime(mtbDataEmprestimo.Text);
                }

                emprestimo.quantidade = (int)nudQuantidade.Value;
                emprestimo.observacoes = rtbObservacoes.Text;

                EmprestimoDAO emprestimoDAO = new EmprestimoDAO();
                emprestimoDAO.cadastrarEmprestimo(emprestimo);

                MessageBox.Show("Emprestimo cadastrado com sucesso!");

                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limparCampos()
        {
            mtbDataEmprestimo.Clear();
            rtbObservacoes.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
