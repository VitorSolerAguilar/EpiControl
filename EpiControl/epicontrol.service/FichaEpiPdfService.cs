using System;
using System.Collections.Generic;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using EpiControl.epicontrol.model;
using EpiControl.epicontrol.dto;

namespace EpiControl.epicontrol.service
{
	public class FichaEpiPdfService
	{
		public void GerarFichaEpiPdf(Funcionario func, List<FichaEpiDTO> epis, string caminhoArquivo)
		{
			using (var writer = new PdfWriter(caminhoArquivo))
			using (var pdf = new PdfDocument(writer))
			using (var doc = new Document(pdf))
			{
				doc.SetMargins(40, 40, 40, 40);

				doc.Add(new Paragraph("Documento Revisado em: 19/04/2026").SetFontSize(8).SetTextAlignment(TextAlignment.LEFT));

				doc.Add(new Paragraph("FICHA DE CONTROLE DE EQUIPAMENTOS DE PROTEÇÃO INDIVIDUAL").SetTextAlignment(TextAlignment.CENTER).SetFontSize(12));

				doc.Add(new Paragraph("EQUIPAMENTO DE PROTEÇÃO INDIVIDUAL").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10));

				doc.Add(new Paragraph("\n"));

				var tblFuncionario = new Table(UnitValue.CreatePercentArray(new float[] { 1, 3 })).UseAllAvailableWidth();

				tblFuncionario.AddCell(CelulaLabel("Nome:"));
				tblFuncionario.AddCell(CelulaTexto(func.nome));
				tblFuncionario.AddCell(CelulaLabel("Função:"));
				tblFuncionario.AddCell(CelulaTexto(func.cargo));

				tblFuncionario.AddCell(CelulaLabel("Matrícula:"));
				tblFuncionario.AddCell(CelulaTexto(func.matricula));

				doc.Add(tblFuncionario);

				doc.Add(new Paragraph("\n"));

				var colunas = new float[] { 4, 2, 2, 1, 2, 2, 3 };
				var tblEpi = new Table(UnitValue.CreatePercentArray(colunas)).UseAllAvailableWidth();

				tblEpi.AddHeaderCell(CelulaHeader("Descrição do EPI"));
				tblEpi.AddHeaderCell(CelulaHeader("CA"));
				tblEpi.AddHeaderCell(CelulaHeader("Data"));
				tblEpi.AddHeaderCell(CelulaHeader("Quant."));
				tblEpi.AddHeaderCell(CelulaHeader("Código Interno"));
				tblEpi.AddHeaderCell(CelulaHeader("Subst."));
				tblEpi.AddHeaderCell(CelulaHeader("Assinatura"));

				foreach (var item in epis)
				{
					tblEpi.AddCell(CelulaTexto(item.descricaoEpi));
					tblEpi.AddCell(CelulaTexto(item.ca));
					tblEpi.AddCell(CelulaTexto(item.dataEntrega.ToString("dd/MM/yyyy")));
					tblEpi.AddCell(CelulaTexto(item.quantidade.ToString()));
					tblEpi.AddCell(CelulaTexto(item.codigoInterno));
					tblEpi.AddCell(CelulaTexto(""));
					tblEpi.AddCell(CelulaTexto("")); 
				}

				doc.Add(tblEpi);

				doc.Add(new Paragraph("\n"));
				doc.Add(new Paragraph("TERMO DE RESPONSABILIDADE:").SetFontSize(9));

				string termo1 = "Declaro neste ato ter recebido da empresa, a título gratuito e para utilização nas dependências da companhia, em conformidade com o artigo 166 da Lei 6514/77 e NR-6 da Portaria 3214/78 do MTE previstos na legislação brasileira, os Equipamento(s) de Proteção Individual conforme relacionado no quadro anexo.";

				string termo2 = "Declaro ter recebido orientações e treinamento em relação ao uso, guarda e conservação e comprometo-me a utilizá-los durante todo o trabalho e mediante ainda os agentes agressivos a que estiver exposto.";

				string termo3 = "Declaro-me ciente de que a não utilização dos EPI´s e/ou a recusa injustificada constituirá ato faltoso nos termos do artigo 158 da CLT e da Lei 6514/77, além de implicar em descumprimento de normas internas, sendo passíveis de advertências ou outras medidas disciplinares necessárias assim entendidas pela empresa. No ato do desligamento, o departamento de Gente e Gestão deverá solicitar ao colaborador que devolva os EPIs/Uniformes que foram fornecidos e registrados na Ficha de Recebimento de EPI, efetuando, se necessário, o desconto do EPI quando este não for devolvido no ato da assinatura da rescisão do contrato do colaborador.";

				doc.Add(new Paragraph(termo1).SetFontSize(8).SetTextAlignment(TextAlignment.JUSTIFIED));
				doc.Add(new Paragraph("\n"));
				doc.Add(new Paragraph(termo2).SetFontSize(8).SetTextAlignment(TextAlignment.JUSTIFIED));
				doc.Add(new Paragraph("\n"));
				doc.Add(new Paragraph(termo3).SetFontSize(8).SetTextAlignment(TextAlignment.JUSTIFIED));

				doc.Add(new Paragraph("\n\n"));

				doc.Add(new Paragraph("Local: ________________________________").SetFontSize(9));
				doc.Add(new Paragraph("Data:  ____/____/______").SetFontSize(9));

				doc.Add(new Paragraph("\n\n"));

				var assinatura = new Paragraph("______________________________________________\nassinatura do empregado").SetTextAlignment(TextAlignment.CENTER).SetFontSize(9);
				doc.Add(assinatura);

				doc.Add(new Paragraph("\n"));

				string legenda1 = "Código Substituição: PE - Perda/Extravio   SP - Substituído vida útil   DT - Danificado no trabalho";
				string legenda2 = "IU - Impróprio p/ uso   AD - Apresenta defeito   Outros   CA - Certificado de aprovação";

				doc.Add(new Paragraph(legenda1).SetFontSize(7));
				doc.Add(new Paragraph(legenda2).SetFontSize(7));
			}
		}

		private Cell CelulaHeader(string texto)
		{
			return new Cell().Add(new Paragraph(texto)).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.CENTER).SetFontSize(8);
		}

		private Cell CelulaLabel(string texto)
		{
			return new Cell().Add(new Paragraph(texto)).SetFontSize(9);
		}

		private Cell CelulaTexto(string texto)
		{
			return new Cell().Add(new Paragraph(texto ?? string.Empty)).SetFontSize(8);
		}
	}
}
