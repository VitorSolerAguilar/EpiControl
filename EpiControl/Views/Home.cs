

namespace EpiControl
{
	public partial class Home : Form
	{
		public Home()
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
	}
}
