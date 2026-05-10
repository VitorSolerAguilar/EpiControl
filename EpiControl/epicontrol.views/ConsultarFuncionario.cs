using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.model;
using EpiControl.Views;
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
    public partial class frmConsultarFuncionario : Form
    {

        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }

        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

        private void frmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = funcionarioDAO.listarFuncionarios();

            if (dgvFuncionario.Columns.Count == 0) return;

            if (dgvFuncionario.Columns.Contains("id_funcionario"))
                dgvFuncionario.Columns["id_funcionario"].HeaderText = "ID";
            if (dgvFuncionario.Columns.Contains("nome"))
                dgvFuncionario.Columns["nome"].HeaderText = "Nome";
            if (dgvFuncionario.Columns.Contains("data_nascimento"))
                dgvFuncionario.Columns["data_nascimento"].HeaderText = "Data Nascimento";
            if (dgvFuncionario.Columns.Contains("estado_civil"))
                dgvFuncionario.Columns["estado_civil"].HeaderText = "Estado Civil";
            if (dgvFuncionario.Columns.Contains("nacionalidade"))
                dgvFuncionario.Columns["nacionalidade"].HeaderText = "Nacionalidade";
            if (dgvFuncionario.Columns.Contains("genero"))
                dgvFuncionario.Columns["genero"].HeaderText = "Gênero";
            if (dgvFuncionario.Columns.Contains("nome_mae"))
                dgvFuncionario.Columns["nome_mae"].HeaderText = "Nome Mãe";
            if (dgvFuncionario.Columns.Contains("nome_pai"))
                dgvFuncionario.Columns["nome_pai"].HeaderText = "Nome Pai";
            if (dgvFuncionario.Columns.Contains("titulo_eleitor"))
                dgvFuncionario.Columns["titulo_eleitor"].HeaderText = "Título Eleitor";
            if (dgvFuncionario.Columns.Contains("pis"))
                dgvFuncionario.Columns["pis"].HeaderText = "PIS/PASEP";
            if (dgvFuncionario.Columns.Contains("rg"))
                dgvFuncionario.Columns["rg"].HeaderText = "RG";
            if (dgvFuncionario.Columns.Contains("cpf"))
                dgvFuncionario.Columns["cpf"].HeaderText = "CPF";
            if (dgvFuncionario.Columns.Contains("matricula"))
                dgvFuncionario.Columns["matricula"].HeaderText = "Matrícula";
            if (dgvFuncionario.Columns.Contains("cargo"))
                dgvFuncionario.Columns["cargo"].HeaderText = "Cargo";
            if (dgvFuncionario.Columns.Contains("status"))
                dgvFuncionario.Columns["status"].HeaderText = "Status";
            if (dgvFuncionario.Columns.Contains("id_endereco"))
                dgvFuncionario.Columns["id_endereco"].HeaderText = "Endereço";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["id_contato"].HeaderText = "Contato";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["telefone"].HeaderText = "Telefone";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["celular"].HeaderText = "Celular";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["email"].HeaderText = "Email";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["email_corporativo"].HeaderText = "Email Corporativo";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["cep"].HeaderText = "Cep";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["rua"].HeaderText = "Rua";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["numero"].HeaderText = "Numero";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["logradouro"].HeaderText = "Logradouro";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["complemento"].HeaderText = "Complemento";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["cidade"].HeaderText = "Cidade";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["tipo"].HeaderText = "Tipo";
            if (dgvFuncionario.Columns.Contains("id_contato"))
                dgvFuncionario.Columns["uf"].HeaderText = "Uf";

        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idFuncionario = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["id_funcionario"].Value);

            int idEndereco = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["id_endereco"].Value);

            int idContato = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["id_contato"].Value);

            frmEditarFuncionario frm = new frmEditarFuncionario(idFuncionario, idEndereco, idContato);
            frm.ShowDialog();

            AtualizarGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = funcionarioDAO.buscarFuncionario(txtConsultaNome.Text);
        }

        private void AtualizarGrid()
        {
            dgvFuncionario.DataSource = funcionarioDAO.listarFuncionarios();
        }
    }
}
