using EpiControl.epicontrol.views;
using EpiControl.views;
using EpiControl.Views;

namespace EpiControl
{
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnConsultarFrm_Click(object sender, EventArgs e)
		{
			frmConsultarFuncionario consultarFuncionario = new frmConsultarFuncionario();

			consultarFuncionario.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultarFuncionario.Show();
		}
		private void btnCadastrarFrm_Click(object sender, EventArgs e)
		{
			frmCadastrarFuncionario cadastrarFuncionario = new frmCadastrarFuncionario();

			cadastrarFuncionario.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarFuncionario.Show();
		}
		private void btnConsultarFornecedor_Click(object sender, EventArgs e)
		{
			frmConsultarFornecedor consultarFornecedor = new frmConsultarFornecedor();

			consultarFornecedor.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultarFornecedor.Show();
		}
		private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
		{
			frmCadastrarFornecedor cadastrarFornecedor = new frmCadastrarFornecedor();

			cadastrarFornecedor.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarFornecedor.Show();
		}
		private void btnCadastrarEpi_Click(object sender, EventArgs e)
		{
			frmCadastrarEpi cadastrarEpi = new frmCadastrarEpi();

			cadastrarEpi.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarEpi.Show();
		}
		private void btnConsultarEpi_Click(object sender, EventArgs e)
		{
			frmConsultarEpi consultarEpi = new frmConsultarEpi();

			consultarEpi.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultarEpi.Show();
		}
		private void btnCadastrarNormaRegulamentadora_Click(object sender, EventArgs e)
		{
			frmCadastrarNormaRegulamentadora cadastrarNorma = new frmCadastrarNormaRegulamentadora();

			cadastrarNorma.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarNorma.Show();
		}
		private void btnConsultarNormaRegulamentadora_Click(object sender, EventArgs e)
		{
			frmConsultarNormaRegulamentadora consultarNorma = new frmConsultarNormaRegulamentadora();

			consultarNorma.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultarNorma.Show();
		}
		private void btnCadastrarEmprestimo_Click(object sender, EventArgs e)
		{
			frmCadastrarEmprestimo cadastroEmprestimo = new frmCadastrarEmprestimo();

			cadastroEmprestimo.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastroEmprestimo.Show();
		}
		private void btnConsultarEmprestimo_Click(object sender, EventArgs e)
		{
			frmConsultarEmprestimo consultaEmprestimo = new frmConsultarEmprestimo();

			consultaEmprestimo.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultaEmprestimo.Show();
		}
		private void btnCadastrarEstoque_Click(object sender, EventArgs e)
		{
			frmCadastrarEstoqueEpi cadastratEstoqueEpi = new frmCadastrarEstoqueEpi();

			cadastratEstoqueEpi.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastratEstoqueEpi.Show();
		}
		private void btnConsultarEstoque_Click(object sender, EventArgs e)
		{
			frmConsultaEstoqueEpi consultaEstoqueEpi = new frmConsultaEstoqueEpi();

			consultaEstoqueEpi.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultaEstoqueEpi.Show();
		}
		private void btnMovimentacao_Click(object sender, EventArgs e)
		{
			frmCadastrarMovimentacaoEstoque cadastrarMovimentacaoEstoque = new frmCadastrarMovimentacaoEstoque();

			cadastrarMovimentacaoEstoque.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarMovimentacaoEstoque.Show();
		}
		private void btnCadastrarTreinamentos_Click(object sender, EventArgs e)
		{
			frmCadastrarTreinamento cadastrarCurso = new frmCadastrarTreinamento();

			cadastrarCurso.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarCurso.Show();
		}
		private void btnConsultarTreinamentos_Click(object sender, EventArgs e)
		{
			frmConsultarCurso consultarCurso = new frmConsultarCurso();

			consultarCurso.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultarCurso.Show();
		}
		private void btnFuncionarioCurso_Click(object sender, EventArgs e)
		{
			frmCadastrarFuncionarioCurso cadastrarFuncionarioCurso = new frmCadastrarFuncionarioCurso();

			cadastrarFuncionarioCurso.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarFuncionarioCurso.Show();
		}
		private void btnConsultarFuncionarioCurso_Click(object sender, EventArgs e)
		{
			frmConsultarFuncionarioCurso consultarFuncionarioCurso = new frmConsultarFuncionarioCurso();

			consultarFuncionarioCurso.FormClosed += (s, args) => this.Show();
			this.Hide();
			consultarFuncionarioCurso.Show();
		}


		bool menuExpand = false;
		private void trasicaoMenuFuncionario_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpContainer.Height += 1;

				if (flpContainer.Height >= 261)
				{
					trasicaoMenuFuncionario.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpContainer.Height -= 14;
				if (flpContainer.Height <= 52)
				{
					trasicaoMenuFuncionario.Stop();
					menuExpand = false;
				}
			}
		}
		private void transicaoMenuFornecedor_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpContainerFornecedor.Height += 1;

				if (flpContainerFornecedor.Height >= 153)
				{
					transicaoMenuFornecedor.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpContainerFornecedor.Height -= 10;
				if (flpContainerFornecedor.Height <= 54)
				{
					transicaoMenuFornecedor.Stop();
					menuExpand = false;
				}
			}
		}
		private void transicaoMenuEpi_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpContainerEpi.Height += 1;

				if (flpContainerEpi.Height >= 153)
				{
					transicaoMenuEpi.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpContainerEpi.Height -= 13;
				if (flpContainerEpi.Height <= 51)
				{
					transicaoMenuEpi.Stop();
					menuExpand = false;
				}
			}
		}
		private void transicaoMenuNorma_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpNormaRegulamentadora.Height += 1;

				if (flpNormaRegulamentadora.Height >= 153)
				{
					transicaoMenuNorma.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpNormaRegulamentadora.Height -= 13;
				if (flpNormaRegulamentadora.Height <= 51)
				{
					transicaoMenuNorma.Stop();
					menuExpand = false;
				}
			}
		}
		private void transicaoMenuEmprestimo_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpEmprestimo.Height += 1;

				if (flpEmprestimo.Height >= 153)
				{
					transicaoMenuEmprestimo.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpEmprestimo.Height -= 13;
				if (flpEmprestimo.Height <= 51)
				{
					transicaoMenuEmprestimo.Stop();
					menuExpand = false;
				}
			}

		}
		private void transicaoMenuEstoque_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpEstoque.Height += 1;

				if (flpEstoque.Height >= 210)
				{
					transicaoMenuEstoque.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpEstoque.Height -= 13;
				if (flpEstoque.Height <= 52)
				{
					transicaoMenuEstoque.Stop();
					menuExpand = false;
				}
			}
		}
		private void transicaoMenuTreinamentos_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpTreinamentos.Height += 1;

				if (flpTreinamentos.Height >= 153)
				{
					transicaoMenuTreinamentos.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpTreinamentos.Height -= 13;
				if (flpTreinamentos.Height <= 51)
				{
					transicaoMenuTreinamentos.Stop();
					menuExpand = false;
				}
			}
		}


		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			trasicaoMenuFuncionario.Start();
		}
		private void btnCadastroFornecedor_Click(object sender, EventArgs e)
		{
			transicaoMenuFornecedor.Start();
		}
		private void btnEpi_Click(object sender, EventArgs e)
		{
			transicaoMenuEpi.Start();
		}
		private void btnNormasRegulamentadoras_Click(object sender, EventArgs e)
		{
			transicaoMenuNorma.Start();
		}
		private void btnEmprestimo_Click(object sender, EventArgs e)
		{
			transicaoMenuEmprestimo.Start();
		}
		private void btnEstoque_Click(object sender, EventArgs e)
		{
			transicaoMenuEstoque.Start();
		}
		private void btnTreinamentos_Click(object sender, EventArgs e)
		{
			transicaoMenuTreinamentos.Start();
		}

		
	}
}
