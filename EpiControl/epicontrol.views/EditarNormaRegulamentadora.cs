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

namespace EpiControl.Views
{
	public partial class frmEditarNormaRegulamentadora : Form
	{
		private int _idNorma;
		public frmEditarNormaRegulamentadora(int idNorma)
		{
			InitializeComponent();
			_idNorma = idNorma;

			carregarNormaRegulamentadora();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			try
			{
				NormaRegulamentadora norma = new NormaRegulamentadora();

				norma.id = _idNorma;
				norma.codigoNr = txtNumeroNr.Text; 
				norma.titulo = txtTitulo.Text;
				norma.descricao = rtbDescricao.Text;
				norma.linkMte = txtLinkMte.Text;
				norma.dataVigencia = DateTime.Parse(mtbDataVigencia.Text);


				NormaRegulamentadoraDAO dao = new NormaRegulamentadoraDAO();
				dao.editarNormaRegulamentadora(norma);

				MessageBox.Show("Norma Regulamentadora atualizada!");
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao alterar norma: " + ex.Message);
			}
		}

		public void carregarNormaRegulamentadora()
		{
			try
			{
				NormaRegulamentadoraDAO dao = new NormaRegulamentadoraDAO();
				DataTable dt = dao.buscarNormaRegulamentadoraId(_idNorma);

				DataRow row = dt.Rows[0];
				txtNumeroNr.Text = row["codigo_nr"].ToString();
				txtTitulo.Text = row["titulo"].ToString();
				rtbDescricao.Text = row["descricao"].ToString();
				txtLinkMte.Text = row["link_mte"].ToString();
				mtbDataVigencia.Text = row["data_vigencia"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar norma: " + ex);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{

			try
			{
				NormaRegulamentadoraDAO dao = new NormaRegulamentadoraDAO();
				dao.excluirNormaRegulamentadora(_idNorma);

				MessageBox.Show("Norma excluida!");
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir norma: " + ex.Message);

			}
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
