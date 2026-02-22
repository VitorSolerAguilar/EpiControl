using EpiControl.epicontrol.views;
using EpiControl.epicontrol.views.Fornecedores;
using EpiControl.Views.Fornecedores;

namespace EpiControl
{
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();
		}

		private void btn_normasRegulamentadoras_Click(object sender, EventArgs e)
		{
			CadastrarNr normasRegulamentadoras = new CadastrarNr();

			normasRegulamentadoras.FormClosed += (s, args) => this.Show();
			this.Hide();
			normasRegulamentadoras.Show();
		}
		private void btn_sair_Click(object sender, EventArgs e)
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







		bool menuExpand = false;
		private void trasicaoMenu_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpContainer.Height += 1;

				if (flpContainer.Height >= 153)
				{
					trasicaoMenu.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpContainer.Height -= 10;
				if (flpContainer.Height <= 51)
				{
					trasicaoMenu.Stop();
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

		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			trasicaoMenu.Start();
		}

		private void btn_cadastroFornecedor_Click(object sender, EventArgs e)
		{
			transicaoMenuFornecedor.Start();
		}

	}
}
