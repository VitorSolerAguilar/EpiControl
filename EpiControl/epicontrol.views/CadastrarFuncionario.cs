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
using static System.Net.WebRequestMethods;

namespace EpiControl.epicontrol.views
{
	public partial class frmCadastrarFuncionario : Form
	{

		public frmCadastrarFuncionario()
		{
			InitializeComponent();
		}

		private void btnSalvarFuncionario_Click(object sender, EventArgs e)
		{
			try
			{
                mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = mtbCpf.Text;

                if (!ValidarCpf(cpf))
                {
                    MessageBox.Show("CPF inválido.");
                    mtbCpf.Focus();
                    return;
                }

                Funcionario funcionario = new Funcionario();

				funcionario.nome = txtNome.Text;
				funcionario.dataNascimento = Convert.ToDateTime(mtbDataNascimento.Text);
				funcionario.estadoCivil = cbxEstadoCivil.Text;
				funcionario.nacionalidade = txtNacionalidade.Text;
				funcionario.nomeMae = txtNomeMae.Text;
				funcionario.nomePai = txtNomePai.Text;
				funcionario.pisPasep = txtPisPasep.Text;
				funcionario.rg = mtbRg.Text;
				funcionario.cpf = mtbCpf.Text;
				funcionario.matricula = txtMatricula.Text;
				funcionario.cargo = txtCargo.Text;

				if (rdbMasculino.Checked)
					funcionario.genero = "Masculino";
				else if (rdbFeminino.Checked)
					funcionario.genero = "Feminino";
                else if (rdbFeminino.Checked)
                    funcionario.genero = "Outro";					

                if (rdbAtivo.Checked)
					funcionario.status = "Ativo";
				else if (rdbInativo.Checked)
					funcionario.status = "Inativo";


				Endereco endereco = new Endereco();

				endereco.cep = mtbCep.Text;
				endereco.cidade = txtCidade.Text;
				endereco.uf = txtUf.Text;
				endereco.rua = txtRua.Text;
				endereco.numero = txtNumero.Text;
				endereco.logradouro = txtLogradouro.Text;
				endereco.tipo = cbxTipo.Text;
				endereco.complemento = rtbComplemento.Text;


				Contato contato = new Contato();

				contato.telefone = mtbTelefone.Text;
				contato.celular = mtbCelular.Text;
				contato.emailPessoal = txtEmailPessoal.Text;
				contato.emailCorporativo = txtEmailCorporativo.Text;

				FuncionarioDAO dao = new FuncionarioDAO();
				dao.cadastrarFuncionario(funcionario, endereco, contato);

				MessageBox.Show("Funcionário cadastrado com sucesso!");
				limparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar: " + ex.Message);
			}
		}

		private void btnConsultarCep_Click(object sender, EventArgs e)
		{
			try
			{
				string cep = mtbCep.Text;
				string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

				DataSet dados = new DataSet();
				dados.ReadXml(xml);

				txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
				txtUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
				txtRua.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
				rtbComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
				txtLogradouro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao consultar cep: " + ex.Message);
			}
		}

		private void limparCampos()
		{
			txtNome.Clear();
			txtNomeMae.Clear();
			txtNomePai.Clear();
			txtCargo.Clear();
			txtMatricula.Clear();
			txtEmailPessoal.Clear();
			txtEmailCorporativo.Clear();
			txtPisPasep.Clear();
			txtNumero.Clear();
			txtUf.Clear();
			txtNacionalidade.Clear();
			txtCidade.Clear();
			txtRua.Clear();
			txtLogradouro.Clear();

			mtbCpf.Clear();
			mtbRg.Clear();
			mtbTelefone.Clear();
			mtbCelular.Clear();
			mtbCep.Clear();
			mtbDataNascimento.Clear();

			cbxEstadoCivil.SelectedIndex = -1;
			cbxTipo.SelectedIndex = -1;
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private bool ValidarCpf(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return cpf[9] - '0' == digito1 && cpf[10] - '0' == digito2;
        }
    }
}

