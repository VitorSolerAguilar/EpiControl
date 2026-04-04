using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
using EpiControl.epicontrol.service;
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
	public partial class EmitirFichaEntregaEpi : Form
	{
		public EmitirFichaEntregaEpi()
		{
			InitializeComponent();
		}
		private void EmitirFichaEntregaEpi_Load(object sender, EventArgs e)
		{
			FuncionarioDAO dao = new FuncionarioDAO();

			cbxFuncionario.DataSource = dao.listarNomesFuncionarios();
			cbxFuncionario.DisplayMember = "nome";
			cbxFuncionario.ValueMember = "id";
		}

		private void btnGerarFicha_Click(object sender, EventArgs e)
		{
			int idFuncionario = Convert.ToInt32(cbxFuncionario.SelectedValue);

			FichaEpiDAO dao = new FichaEpiDAO();
			var lista = dao.BuscarFichaPorFuncionario(idFuncionario);

			FichaEpiService service = new FichaEpiService();
			string ficha = service.MontarFicha(lista);

			MessageBox.Show(ficha);
		}

	}
}
