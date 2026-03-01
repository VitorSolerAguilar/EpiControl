using EpiControl.epicontrol.views;
using EpiControl.Views;

namespace EpiControl
{
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();
		}

		private void btnNormasRegulamentadoras_Click(object sender, EventArgs e)
		{
			CadastrarNr normasRegulamentadoras = new CadastrarNr();

			normasRegulamentadoras.FormClosed += (s, args) => this.Show();
			this.Hide();
			normasRegulamentadoras.Show();
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





		bool menuExpand = false;
		private void trasicaoMenuFuncionario_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpContainer.Height += 1;

				if (flpContainer.Height >= 153)
				{
					trasicaoMenuFuncionario.Stop();
					menuExpand = true;

				}
			}
			else
			{
				flpContainer.Height -= 10;
				if (flpContainer.Height <= 51)
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
				flpContainerEpi.Height -= 10;
				if (flpContainerEpi.Height <= 51)
				{
					transicaoMenuEpi.Stop();
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
	}
}
