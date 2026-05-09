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
	public partial class frmCadastrarTreinamento : Form
	{
		public frmCadastrarTreinamento()
		{
			InitializeComponent();
		}
		private void btnSalvar_Click(object sender, EventArgs e)
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

                CursoDAO cursoDAO = new CursoDAO();
				cursoDAO.cadastrarCurso(curso);
				MessageBox.Show("Treinamento cadastrado!");

				limparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar treinamento: " + ex.Message);
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void limparCampos()
		{
			txtNome.Clear();
			txtCargaHoraria.Clear();
			rtbDescricao.Clear();
			mtbValidade.Clear();
		}
	}
}
