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
	public partial class frmCadastrarFuncionarioCurso : Form
	{
		public frmCadastrarFuncionarioCurso()
		{
			InitializeComponent();
		}
		private void frmCadastrarFuncionarioCurso_Load(object sender, EventArgs e)
		{
			FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
			CursoDAO cursoDAO = new CursoDAO();

			cbxFuncionario.DataSource = funcionarioDAO.listarNomesFuncionarios();
			cbxFuncionario.DisplayMember = "nome";
			cbxFuncionario.ValueMember = "id";

			cbxCurso.DataSource = cursoDAO.listarCursos();
			cbxCurso.DisplayMember = "nome";
			cbxCurso.ValueMember = "id_curso";
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
                if (cbxFuncionario.SelectedValue == null || cbxFuncionario.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo FUNCIONÁRIO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxFuncionario.Focus();
                    return;
                }

                if (cbxCurso.SelectedValue == null || cbxCurso.SelectedIndex == -1)
                {
                    MessageBox.Show("Campo CURSO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxCurso.Focus();
                    return;
                }

                FuncionarioCurso funcionarioCurso = new FuncionarioCurso();

				funcionarioCurso.funcionarioId = Convert.ToInt32(cbxFuncionario.SelectedValue);
				funcionarioCurso.cursoId = Convert.ToInt32(cbxCurso.SelectedValue);
                funcionarioCurso.conclusao = Convert.ToDateTime(mtbConclusao.Text);


                if (mtbInicio.Text.Length < 7 || mtbInicio.Text.Contains("_"))
				{
                    MessageBox.Show("Campo INÍCIO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
				{
                    funcionarioCurso.inicio = Convert.ToDateTime(mtbInicio.Text);
                }

                FuncionarioCursoDAO funcionarioCursoDAO = new FuncionarioCursoDAO();

                if (funcionarioCursoDAO.verificarFuncionarioCursoExistente(funcionarioCurso.funcionarioId, funcionarioCurso.cursoId))
                {
                    MessageBox.Show("Este funcionário já está associado a este curso.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                funcionarioCursoDAO.cadastrarFuncionarioCurso(funcionarioCurso);

				limparCampos();

				MessageBox.Show("Associacao de funcionario ao curso realizada!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao associar funcionario ao curso: " + ex);
			}
		}

		private void limparCampos()
		{
			mtbConclusao.Clear();
			mtbInicio.Clear();
		}
	}
}
