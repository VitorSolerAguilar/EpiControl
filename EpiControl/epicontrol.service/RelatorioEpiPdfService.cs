using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EpiControl.epicontrol.dto;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace EpiControl.epicontrol.service
{
    public class RelatorioEpiPdfService
    {
        public void GerarRelatorioUsoEpiPdf(List<RelatorioEpiDTO> dados,DateTime? dataInicio,DateTime? dataFim,string caminhoArquivo)
        {
            using (var writer = new PdfWriter(caminhoArquivo))
            using (var pdf = new PdfDocument(writer))
            using (var doc = new Document(pdf))
            {
                doc.SetMargins(40, 40, 40, 40);

                doc.Add(new Paragraph("RELATÓRIO DE UTILIZAÇÃO DE EPIs").SetTextAlignment(TextAlignment.CENTER).SetFontSize(14));

                string periodo = "Período: ";
                periodo += dataInicio.HasValue ? dataInicio.Value.ToString("dd/MM/yyyy") : "início";
                periodo += " até ";
                periodo += dataFim.HasValue ? dataFim.Value.ToString("dd/MM/yyyy") : "hoje";

                doc.Add(new Paragraph(periodo).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10));

                doc.Add(new Paragraph("\n"));

                var colunas = new float[] { 1, 4, 2, 2, 2, 2, 2, 2 };
                var tabela = new Table(UnitValue.CreatePercentArray(colunas)).UseAllAvailableWidth();

                tabela.AddHeaderCell(CelulaHeader("ID"));
                tabela.AddHeaderCell(CelulaHeader("Descrição do EPI"));
                tabela.AddHeaderCell(CelulaHeader("Código Interno"));
                tabela.AddHeaderCell(CelulaHeader("CA"));
                tabela.AddHeaderCell(CelulaHeader("Total Qtd."));
                tabela.AddHeaderCell(CelulaHeader("Qtd. Empréstimos"));
                tabela.AddHeaderCell(CelulaHeader("Primeira Entrega"));
                tabela.AddHeaderCell(CelulaHeader("Última Entrega"));

                if (dados != null)
                {
                    foreach (var item in dados)
                    {
                        tabela.AddCell(CelulaTexto(item.idEpi.ToString()));
                        tabela.AddCell(CelulaTexto(item.nomeEpi));
                        tabela.AddCell(CelulaTexto(item.codigoInterno));
                        tabela.AddCell(CelulaTexto(item.ca));
                        tabela.AddCell(CelulaTexto(item.totalQuantidade.ToString()));
                        tabela.AddCell(CelulaTexto(item.totalEmprestimos.ToString()));
                        tabela.AddCell(CelulaTexto(item.primeiraEntrega?.ToString("dd/MM/yyyy") ?? ""));
                        tabela.AddCell(CelulaTexto(item.ultimaEntrega?.ToString("dd/MM/yyyy") ?? ""));
                    }
                }
                doc.Add(tabela);
            }
        }

        private Cell CelulaHeader(string texto)
        {
            return new Cell().Add(new Paragraph(texto)).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.CENTER).SetFontSize(9);
        }

        private Cell CelulaTexto(string texto)
        {
            return new Cell().Add(new Paragraph(texto ?? string.Empty)).SetFontSize(8);
        }
    }
}