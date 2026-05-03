using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.dto;
using EpiControl.epicontrol.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EpiControl.epicontrol.views
{
    public partial class fmrGerarRelatorioEpi : Form
    {
        private readonly EpiDAO _relatorioDao;
        private readonly RelatorioEpiPdfService _pdfService;
        private List<RelatorioEpiDTO> _dadosAtual;

        public fmrGerarRelatorioEpi()
        {
            InitializeComponent();

            _relatorioDao = new EpiDAO();
            _pdfService = new RelatorioEpiPdfService();

            dtpFim.Value = DateTime.Today;
            dtpInicio.Value = DateTime.Today.AddDays(-30);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? dataInicio = dtpInicio.Value.Date;
                DateTime? dataFim = dtpFim.Value.Date;

                _dadosAtual = _relatorioDao.ListarUsoEpi(dataInicio, dataFim);

                dgvRelatorio.DataSource = _dadosAtual;
                AjustarColunasGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar relatório: " + ex.Message);
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dadosAtual == null || _dadosAtual.Count == 0)
                {
                    MessageBox.Show("Nenhum dado para exportar. Busque o relatório primeiro.");
                    return;
                }

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "Relatorio_Uso_EPI.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        DateTime? dataInicio = dtpInicio.Value.Date;
                        DateTime? dataFim = dtpFim.Value.Date;

                        _pdfService.GerarRelatorioUsoEpiPdf(_dadosAtual, dataInicio, dataFim, sfd.FileName);

                        MessageBox.Show("Relatório exportado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar PDF: " + ex.Message);
            }
        }

        private void AjustarColunasGrid()
        {
            if (dgvRelatorio.Columns["idEpi"] != null)
                dgvRelatorio.Columns["idEpi"].HeaderText = "ID EPI";

            if (dgvRelatorio.Columns["nomeEpi"] != null)
                dgvRelatorio.Columns["nomeEpi"].HeaderText = "Descrição do EPI";

            if (dgvRelatorio.Columns["codigoInterno"] != null)
                dgvRelatorio.Columns["codigoInterno"].HeaderText = "Código Interno";

            if (dgvRelatorio.Columns["ca"] != null)
                dgvRelatorio.Columns["ca"].HeaderText = "CA";

            if (dgvRelatorio.Columns["totalQuantidade"] != null)
                dgvRelatorio.Columns["totalQuantidade"].HeaderText = "Total Qtd.";

            if (dgvRelatorio.Columns["totalEmprestimos"] != null)
                dgvRelatorio.Columns["totalEmprestimos"].HeaderText = "Qtd. Empréstimos";

            if (dgvRelatorio.Columns["primeiraEntrega"] != null)
            {
                dgvRelatorio.Columns["primeiraEntrega"].HeaderText = "Primeira Entrega";
                dgvRelatorio.Columns["primeiraEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvRelatorio.Columns["ultimaEntrega"] != null)
            {
                dgvRelatorio.Columns["ultimaEntrega"].HeaderText = "Última Entrega";
                dgvRelatorio.Columns["ultimaEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}