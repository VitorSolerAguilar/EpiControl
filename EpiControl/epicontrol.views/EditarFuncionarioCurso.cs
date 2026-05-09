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
	public partial class frmEditarFuncionarioCurso : Form
	{
		private int _idFuncionarioCurso, _idCurso, _idFuncionario;
		public frmEditarFuncionarioCurso(int idFuncionarioCurso, int idCurso, int idFuncionario)
		{
			InitializeComponent();

			_idCurso = idCurso;
			_idFuncionario = idFuncionario;
			_idFuncionarioCurso = idFuncionarioCurso;
		}
		private void frmEditarFuncionarioCurso_Load(object sender, EventArgs e)
		{
			FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
			CursoDAO cursoDAO = new CursoDAO();

			cbxFuncionario.DataSource = funcionarioDAO.listarNomesFuncionarios();
			cbxFuncionario.DisplayMember = "nome";
			cbxFuncionario.ValueMember = "id";

			cbxCurso.DataSource = cursoDAO.listarCursos();
			cbxCurso.DisplayMember = "nome";
			cbxCurso.ValueMember = "id_curso";

			carregarFuncionarioCurso();
		}

		public void carregarFuncionarioCurso()
		{
			try
			{
				FuncionarioCursoDAO dao = new FuncionarioCursoDAO();
				DataTable dt = dao.buscarFuncionarioCursoPorId(_idFuncionarioCurso);

				DataRow row = dt.Rows[0];
				cbxFuncionario.SelectedValue = Convert.ToInt32(row["fk_funcionario"]);
				cbxCurso.SelectedValue = Convert.ToInt32(row["fk_curso"]);
				mtbInicio.Text = row["data_inicio"].ToString();
				mtbConclusao.Text = row["data_conclusao"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar funcionario curso: " + ex);
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
				FuncionarioCursoDAO dao = new FuncionarioCursoDAO();
				dao.excluirFuncionarioCurso(_idFuncionarioCurso);

				MessageBox.Show("Registro excluído com sucesso!");

				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir registro: " + ex.Message);
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
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

				funcionarioCurso.id = _idFuncionarioCurso;
				funcionarioCurso.cursoId = Convert.ToInt32(cbxCurso.SelectedValue);
				funcionarioCurso.funcionarioId = Convert.ToInt32(cbxFuncionario.SelectedValue);
				funcionarioCurso.inicio = Convert.ToDateTime(mtbInicio.Text);

                if (mtbInicio.Text.Length < 10 || mtbInicio.Text.Contains("_"))
                {
                    MessageBox.Show("Campo INÍCIO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    funcionarioCurso.inicio = Convert.ToDateTime(mtbInicio.Text);
                }

                if (mtbConclusao.Text.Length < 10 || mtbConclusao.Text.Contains("_"))
                {
                    MessageBox.Show("Campo INÍCIO obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    funcionarioCurso.conclusao = null;
                }
                else
                {
                    funcionarioCurso.conclusao = Convert.ToDateTime(mtbConclusao.Text);
                }

                FuncionarioCursoDAO dao = new FuncionarioCursoDAO();
				dao.editarFuncionarioCurso(funcionarioCurso);

				MessageBox.Show("Funcionario curso atualizado com sucesso!");

				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar funcionario curso: " + ex.Message);
			}
		}
	}
}
