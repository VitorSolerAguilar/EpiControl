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

namespace EpiControl.epicontrol.views
{
	public partial class CadastrarFuncionario : Form
	{
		public CadastrarFuncionario()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Funcionario funcionario = new Funcionario();

			funcionario.nome = txtNome.Text;
			funcionario.rg = mtbRg.Text;
			funcionario.cpf = mtbCpf.Text;
			funcionario.pis = txtPis.Text;
			funcionario.dataNascimento = DateTime.Parse(mtmDataNascimento.Text);
			funcionario.numeroCTPS = txtNumeroCtps.Text;
			funcionario.serieCtps = txtSerieCtps.Text;
			funcionario.estadoCivil = cbxEstadoCivil.Text;
			funcionario.genero = cbxGenero.Text;
			funcionario.nomeMae = txtNomeMae.Text;
			funcionario.nomePai = txtNomePai.Text;
			funcionario.inscricaoETitulo = txtInscricaoETitutulo.Text;
			funcionario.zona = txtZona.Text;
			funcionario.secao = txtSecao.Text;
			funcionario.municipio = txtMunicipio.Text;
			funcionario.uf = cbxUf.Text;
			funcionario.dataEmissao = DateTime.Parse(mtbDataEmissao.Text);

			FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
			funcionarioDAO.cadastrarDocumentos(funcionario);
		}
	}
}
