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
	public partial class frmCadastrarMovimentacaoEstoque : Form
	{
		public frmCadastrarMovimentacaoEstoque()
		{
			InitializeComponent();
		}
		private void frmCadastrarMovimentacaoEstoque_Load(object sender, EventArgs e)
		{
			FuncionarioDAO dao = new FuncionarioDAO();

			cbxFuncionario.DataSource = dao.listarNomesFuncionarios();
			cbxFuncionario.DisplayMember = "nome";
			cbxFuncionario.ValueMember = "id";

			EstoqueEpiDAO estoqueDAO = new EstoqueEpiDAO();
			cbxEpi.DataSource = estoqueDAO.listarNomesEpi();
			cbxEpi.DisplayMember = "nome";
			cbxEpi.ValueMember = "id";

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
                if (cbxFuncionario.SelectedValue == null || cbxFuncionario.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo FUNCIONARIO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxFuncionario.Focus();
                    return;
                }

                if (cbxEpi.SelectedValue == null || cbxEpi.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo EPI obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxEpi.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbxTipoMovimentacao.Text))
                {
                    MessageBox.Show("Campo TIPO DE MOVIMENTAÇÃO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxTipoMovimentacao.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
                {
                    MessageBox.Show("Campo QUANTIDADE obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantidade.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtbDataEmprestimo.Text) || mtbDataEmprestimo.Text.Contains("_"))
                {
                    
                }

                MovimentacaoEstoque movimentacao = new MovimentacaoEstoque();

				movimentacao.tipoMovimentacao = cbxTipoMovimentacao.Text;
				movimentacao.quantidade = Convert.ToInt32(txtQuantidade.Text);

				if (mtbDataEmprestimo.Text.Length < 10 || mtbDataEmprestimo.Text.Contains("_"))
				{
                    MessageBox.Show("Campo DATA DE EMPRÉSTIMO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbDataEmprestimo.Focus();
                    return;
				}
				else
				{
                    movimentacao.dataMovimentacao = Convert.ToDateTime(mtbDataEmprestimo.Text);
                }

				movimentacao.observacao = rtbObservacao.Text;
				movimentacao.estoqueId = Convert.ToInt32(cbxEpi.SelectedValue);
				movimentacao.funcionarioId = Convert.ToInt32(cbxFuncionario.SelectedValue);

				MovimentacaoEstoqueDAO dao = new MovimentacaoEstoqueDAO();
				dao.cadastrarMovimentacaoEstoque(movimentacao);

				MessageBox.Show("Movimentação de estoque cadastrada com sucesso!");
				limparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar movimentação: " + ex.Message);
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void limparCampos()
		{
			txtQuantidade.Clear();
			mtbDataEmprestimo.Clear();
			rtbObservacao.Clear();
		}		

	}
}
