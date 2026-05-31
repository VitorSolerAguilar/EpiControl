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
    public partial class frmEditarTreinamento : Form
    {

        private int _idCurso;
        public frmEditarTreinamento(int idCurso)
        {
            InitializeComponent();
            _idCurso = idCurso;
            carregarCurso();

        }
        CursoDAO dao = new CursoDAO();

        public void carregarCurso()
        {
            try
            {
                DataTable dt = dao.buscarCursoPorId(_idCurso);

                DataRow row = dt.Rows[0];

                txtNome.Text = row["nome"].ToString();
                txtCargaHoraria.Text = row["carga_horaria"].ToString();
                rtbDescricao.Text = row["descricao"].ToString();
                mtbValidade.Text = row["validade_meses"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar treinamento: " + ex);

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                CursoDAO dao = new CursoDAO();

                dao.excluirCurso(_idCurso);

                MessageBox.Show("Curso excluido");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir curso: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Campo NOME TREINAMENTO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCargaHoraria.Text))
                {
                    MessageBox.Show("Campo CARGA HORÁRIA obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCargaHoraria.Focus();
                    return;
                }

                Curso curso = new Curso();

                curso.id = _idCurso;
                curso.nome = txtNome.Text;
                curso.cargaHoraria = txtCargaHoraria.Text;
                curso.descricao = rtbDescricao.Text;

                if (mtbValidade.Text.Length < 10 || mtbValidade.Text.Contains("_"))
                {
                    MessageBox.Show("Campo VALIDADE obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbValidade.Focus();
                    return;
                }
                else
                {
                    curso.validadeMeses = Convert.ToDateTime(mtbValidade.Text);
                }

                if (dao.verificarNomeCursoExistente(curso.nome, curso.id))
                {
                    MessageBox.Show("Já existe outro treinamento cadastrado com este nome.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dao.editarCurso(curso);

                MessageBox.Show("Curso atualizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar curso: " + ex);
            }
        }
    }
}
