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

namespace EpiControl.views
{
	public partial class frmCadastrarNormaRegulamentadora : Form
	{
		public frmCadastrarNormaRegulamentadora()
		{
			InitializeComponent();
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				NormaRegulamentadora normaRegulamentadora = new NormaRegulamentadora();

				normaRegulamentadora.codigoNr = txtNumeroNr.Text;
				normaRegulamentadora.titulo = txtTitulo.Text;
				normaRegulamentadora.descricao = rtbDescricao.Text;
				normaRegulamentadora.linkMte = txtLinkMte.Text;
				normaRegulamentadora.dataVigencia = Convert.ToDateTime(mtbDataVigencia.Text);

				NormaRegulamentadoraDAO dao = new NormaRegulamentadoraDAO();
				dao.cadastrarNormaRegulamentadora(normaRegulamentadora);

                MessageBox.Show("Norma regulamentadora cadastrada com sucesso!");

                limparCampos();
			}catch(Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar nr: " + ex.Message);
			}
		}

		public void limparCampos()
		{
			txtNumeroNr.Clear();
			txtTitulo.Clear();
			rtbDescricao.Clear();
			txtLinkMte.Clear();
			mtbDataVigencia.Clear();
		}
	}
}
