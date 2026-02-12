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

namespace EpiControl.Views.EPI
{
	public partial class CadastrarEpi : Form
	{
		public CadastrarEpi()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				Epi epi = new Epi();

				epi.nome = txtNome.Text;
				epi.codigoInterno = txtNome.Text;
				epi.ca = txtNome.Text;
				epi.tamanho = txtNome.Text;
				epi.validadeCa = dtpValidadeCa.Value;
				epi.marca = txtNome.Text;
				epi.cor = txtNome.Text;
				epi.descricao = txtNome.Text;

				if (rdbAtivo.Checked)
				{
					epi.status = "Ativo";
				}
				else if (rdbInativo.Checked)
				{
					epi.status = "Inativo";
				}

				EpiDAO dao = new EpiDAO();
				dao.cadastrarEpi(epi);

				MessageBox.Show("Epi cadastrado com sucesso!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar: " + ex.Message);
			}

		}
	}
}
