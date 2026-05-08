using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
using EpiControl.epicontrol.views;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class frmEditarFuncionario : Form
    {
        private int _idFuncionario, _idEndereco, _idContato;

        public frmEditarFuncionario(int idFuncionario, int idEndereco, int idContato)
        {
            InitializeComponent();

            _idFuncionario = idFuncionario;
            _idEndereco = idEndereco;
            _idContato = idContato;
            carregarFuncionario();
        }

        private void carregarFuncionario()
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                DataTable dt = dao.buscarFuncionarioId(_idFuncionario);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Funcionário não encontrado.");
                    return;
                }

                DataRow row = dt.Rows[0];

                txtNome.Text = row["Nome"].ToString();
                txtEmailPessoal.Text = row["email"].ToString();
                txtEmailCorporativo.Text = row["email_corporativo"].ToString();
                txtCargo.Text = row["cargo"].ToString();
                txtNomeMae.Text = row["nome_mae"].ToString();
                txtRua.Text = row["rua"].ToString();
                txtNumero.Text = row["numero"].ToString();
                txtLogradouro.Text = row["logradouro"].ToString();
                txtCidade.Text = row["cidade"].ToString();
                txtUf.Text = row["uf"].ToString();
                txtNomePai.Text = row["nome_pai"].ToString();
                txtMatricula.Text = row["matricula"].ToString();
                txtNacionalidade.Text = row["nacionalidade"].ToString();
                txtPisPasep.Text = row["pis"].ToString();

                string genero = row["genero"].ToString();
                string status = row["status"].ToString();

                rdbMasculino.Checked = genero == "Masculino";
                rdbFeminino.Checked = genero == "Feminino";
                rdbOutro.Checked = genero == "Outro";

                rdbAtivo.Checked = status == "Ativo";
                rdbInativo.Checked = status == "Inativo";


                mtbDataNascimento.Text = row["data_nascimento"].ToString();
                mtbRg.Text = row["rg"].ToString();
                mtbCpf.Text = row["cpf"].ToString();
                mtbTelefone.Text = row["telefone"].ToString();
                mtbCelular.Text = row["celular"].ToString();
                mtbCep.Text = row["cep"].ToString();

                rtbComplemento.Text = row["complemento"].ToString();

                cbxTipoEndereco.Text = row["tipo"].ToString();
                cbxEstadoCivil.Text = row["estado_civil"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionario: " + ex);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                dao.excluirFuncionarioId(_idFuncionario);

                MessageBox.Show("Funcionario excluido!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.id = _idFuncionario;
                funcionario.nome = txtNome.Text.Trim();
                funcionario.dataNascimento = Convert.ToDateTime(mtbDataNascimento.Text);
                funcionario.estadoCivil = cbxEstadoCivil.Text;
                funcionario.nacionalidade = txtNacionalidade.Text.Trim();

                if (rdbMasculino.Checked)
                    funcionario.genero = "Masculino";
                else if (rdbFeminino.Checked)
                    funcionario.genero = "Feminino";

                funcionario.nomeMae = txtNomeMae.Text.Trim();
                funcionario.nomePai = txtNomePai.Text.Trim();
                funcionario.pisPasep = txtPisPasep.Text;

                funcionario.rg = mtbRg.Text.Trim();

                mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                funcionario.cpf = mtbCpf.Text;

                funcionario.matricula = txtMatricula.Text.Trim();
                funcionario.cargo = txtCargo.Text.Trim();

                if (rdbAtivo.Checked)
                    funcionario.status = "Ativo";
                else if (rdbInativo.Checked)
                    funcionario.status = "Inativo";

                Endereco endereco = new Endereco();
                endereco.id = _idEndereco;
                endereco.cep = mtbCep.Text;
                endereco.cidade = txtCidade.Text.Trim();
                endereco.uf = txtUf.Text;
                endereco.rua = txtRua.Text.Trim();
                endereco.numero = txtNumero.Text.Trim();
                endereco.logradouro = txtLogradouro.Text.Trim();
                endereco.tipo = cbxTipoEndereco.Text;
                endereco.complemento = rtbComplemento.Text.Trim();

                Contato contato = new Contato();
                contato.id = _idContato;
                contato.telefone = mtbTelefone.Text;
                contato.celular = mtbCelular.Text;
                contato.emailPessoal = txtEmailPessoal.Text.Trim();
                contato.emailCorporativo = txtEmailCorporativo.Text.Trim();

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.editarFuncionario(funcionario, endereco, contato);

                MessageBox.Show("Funcionário atualizado!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar funcionário: " + ex.Message);
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

        
    }
}
