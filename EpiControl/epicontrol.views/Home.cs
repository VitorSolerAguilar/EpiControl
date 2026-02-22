using EpiControl.epicontrol.views;
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
		private void btn_cadastroFornecedor_Click(object sender, EventArgs e)
		{
			CadastrarFornecedor cadastrarFornecedor = new CadastrarFornecedor();

			cadastrarFornecedor.FormClosed += (s, args) => this.Show();
			this.Hide();
			cadastrarFornecedor.Show();
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







		bool menuExpand = false;
		private void trasicaoMenu_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				flpContainer.Height += 1;

				if (flpContainer.Height >= 178)
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

		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			trasicaoMenu.Start();
		}
				
	}
}
