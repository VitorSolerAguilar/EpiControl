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
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Campo Nome obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNomeMae.Text))
                {
                    MessageBox.Show("Campo NOME DA MÃE obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeMae.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtbCep.Text))
                {
                    MessageBox.Show("Campo CEP obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbCep.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCidade.Text))
                {
                    MessageBox.Show("Campo CIDADE obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCidade.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUf.Text))
                {
                    MessageBox.Show("Campo UF obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUf.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRua.Text))
                {
                    MessageBox.Show("Campo RUA obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRua.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("Campo Nº obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
                {
                    MessageBox.Show("Campo LOGRADOURO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogradouro.Focus();
                    return;
                }
                if (cbxTipo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbxTipo.Text))
                {
                    MessageBox.Show("Campo Tipo obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxTipo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMatricula.Text))
                {
                    MessageBox.Show("Campo MATRÍCULA obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatricula.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCargo.Text))
                {
                    MessageBox.Show("Campo CARGO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCargo.Focus();
                    return;
                }

                if (!rdbAtivo.Checked && !rdbInativo.Checked)
                {
                    MessageBox.Show("Campo STATUS obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = mtbCpf.Text;

                if (!ValidarCpf(cpf))
                {
                    MessageBox.Show("CPF invalido!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbCpf.Focus();
                    return;
                }

                Funcionario funcionario = new Funcionario();

                funcionario.nome = txtNome.Text;

                if (mtbDataNascimento.Text.Length < 10 || mtbDataNascimento.Text.Contains("_"))
                {
                    MessageBox.Show("Campo DATA DE NASCIMENTO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbDataNascimento.Focus();
                    return;
                }
                else
                {
                    funcionario.dataNascimento = Convert.ToDateTime(mtbDataNascimento.Text);
                }


                funcionario.estadoCivil = cbxEstadoCivil.Text;
                funcionario.nacionalidade = txtNacionalidade.Text;
                funcionario.nomeMae = txtNomeMae.Text;
                funcionario.nomePai = txtNomePai.Text;
                funcionario.pisPasep = txtPisPasep.Text;

                mtbRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                funcionario.rg = mtbRg.Text;
                mtbRg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                funcionario.cpf = mtbCpf.Text;
                mtbCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

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

                if (dao.verificarRgCpfMatriculaExistente(funcionario.rg, funcionario.cpf, funcionario.matricula))
                {
                    MessageBox.Show("Já existe um funcionário cadastrado com este RG, matricula ou CPF.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

        private void mtbDataNascimento_Validating(object sender, CancelEventArgs e)
        {
            string texto = mtbDataNascimento.Text;
            DateTime dataLimite = new DateTime(2026, 1, 1);

            if (DateTime.TryParseExact(texto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataSelecionada))
            {
                if (dataSelecionada > dataLimite)
                {
                    e.Cancel = true; 
                    MessageBox.Show($"A data não pode ser maior que {dataLimite:dd/MM/yyyy}.", "Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbDataNascimento.Clear();
                }
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Digite uma data válida no formato dd/MM/yyyy.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDataNascimento.Clear();
            }
        }
    }
}

