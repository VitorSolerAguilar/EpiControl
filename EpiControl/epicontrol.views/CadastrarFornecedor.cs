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
    public partial class frmCadastrarFornecedor : Form
    {
        public frmCadastrarFornecedor()
        {
            InitializeComponent();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Campo NOME obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mtbTelefone.Text))
                {
                    MessageBox.Show("Campo TELEFONE obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbTelefone.Focus();
                    return;
                }

                mtbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cnpj = mtbCnpj.Text;

                if (!ValidarCnpj(cnpj))
                {
                    MessageBox.Show("Campo CNPJ obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbCnpj.Focus();
                    return;
                }

                Fornecedor fornecedor = new Fornecedor();

                fornecedor.nome = txtNome.Text;

                mtbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                fornecedor.cnpj = mtbCnpj.Text;
                mtbCnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                fornecedor.observacoes = rtbObservacao.Text;

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
                contato.emailCorporativo = txtEmailPessoal.Text;

                FornecedorDAO dao = new FornecedorDAO();

                if (dao.verificarCnpjNomeExistente(fornecedor.cnpj))
                {
                    MessageBox.Show("Já existe um fornecedor cadastrado com este CNPJ ou NOME.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dao.cadastrarFornecedor(fornecedor, endereco, contato);

                MessageBox.Show("Fornecedor cadastrado com sucesso!");

                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            mtbCnpj.Clear();
            rtbObservacao.Clear();
            mtbTelefone.Clear();
            txtEmailCorporativo.Clear();
            txtEmailPessoal.Clear();
            mtbCelular.Clear();
            mtbCep.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtLogradouro.Clear();
            rtbComplemento.Clear();
        }

        private bool ValidarCnpj(string cnpj)
        {
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                return false;

            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return cnpj[12] - '0' == digito1 && cnpj[13] - '0' == digito2;
        }
    }
}
