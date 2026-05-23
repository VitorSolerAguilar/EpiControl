using Xceed.Words.NET;
using System;
using System.IO;
using System.Globalization;

namespace EpiControl.epicontrol.service
{
    public class CertificadoCursoService
    {
        public void GerarCertificado(
            string nomeFuncionario,
            string nomeCurso,
            string descricaoCurso,
            string cargaHoraria,
            int validadeMeses,
            DateTime dataConclusao,
            string caminhoSaida)
        {

            string caminhoTemplate = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                 "epicontrol.resources",
                 "Teamplate",
                 "teamplateCertificado.docx"
            );

            if (!File.Exists(caminhoTemplate))
                throw new Exception("Template do certificado não encontrado em: " + caminhoTemplate);

            using (DocX doc = DocX.Load(caminhoTemplate))
            {
                doc.ReplaceText("{{NOME_FUNCIONARIO}}", nomeFuncionario.ToUpper());
                doc.ReplaceText("{{NOME_CURSO}}", nomeCurso.ToUpper());
                doc.ReplaceText("{{DESCRICAO_CURSO}}", descricaoCurso);
                doc.ReplaceText("{{CARGA_HORARIA}}", cargaHoraria);
                doc.ReplaceText("{{VALIDADE_MESES}}", validadeMeses + " meses");
                doc.ReplaceText("{{DATA_CONCLUSAO}}", dataConclusao.ToString(
                    "dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));

                doc.SaveAs(caminhoSaida);
            }
        }
    }
}