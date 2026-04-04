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
				MovimentacaoEstoque movimentacao = new MovimentacaoEstoque();

				movimentacao.tipoMovimentacao = cbxTipoMovimentacao.Text;
				movimentacao.quantidade = Convert.ToInt32(txtQuantidade.Text);
				movimentacao.dataMovimentacao = Convert.ToDateTime(mtbDataEmprestimo.Text);
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
