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

namespace EpiControl.Views.Emprestimo
{
	public partial class frmCadastroEmprestimo : Form
	{
		public frmCadastroEmprestimo()
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
	}
}
