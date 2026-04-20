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
	public partial class frmGerarFichaEpi : Form
	{
		private readonly EpiDAO _epiDao;
		private readonly FichaEpiPdfService _pdfService;

		public frmGerarFichaEpi()
		{
			InitializeComponent();
			_epiDao = new EpiDAO();
			_pdfService = new FichaEpiPdfService();
		}

		private void frmGerarFichaEpi_Load(object sender, EventArgs e)
		{
			FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
			cbxFuncionario.DataSource = funcionarioDAO.listarNomesFuncionarios();
			cbxFuncionario.DisplayMember = "nome";
			cbxFuncionario.ValueMember = "id";
		}

		private void btnGerarFicha_Click(object sender, EventArgs e)
		{
			if (cbxFuncionario.SelectedItem == null)
			{
				MessageBox.Show("Selecione um funcionário.");
				return;
			}

			var func = (Funcionario)cbxFuncionario.SelectedItem;

			var (funcionario, itens) = _epiDao.ObterFichaEpiFuncionario(func.id);

			if (funcionario == null)
			{
				MessageBox.Show("Funcionário não encontrado ou sem registros de EPI.");
				return;
			}

			if (itens.Count == 0)
			{
				MessageBox.Show("Este funcionário não possui EPIs cadastrados.");
				return;
			}

			using (var sfd = new SaveFileDialog())
			{
				sfd.Filter = "PDF (*.pdf)|*.pdf";
				sfd.FileName = $"Ficha_EPI_{funcionario.nome}.pdf";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					_pdfService.GerarFichaEpiPdf(funcionario, itens, sfd.FileName);
					MessageBox.Show("Ficha de EPI gerada com sucesso!");
				}
			}
		}
	}
}
