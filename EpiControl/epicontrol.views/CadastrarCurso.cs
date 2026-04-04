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
	public partial class frmCadastrarCurso : Form
	{
		public frmCadastrarCurso()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				Curso curso = new Curso();

<<<<<<< HEAD
				curso.nome = txtNome.Text;
				curso.cargaHoraria = txtCargaHoraria.Text;
				curso.descricao = rtbDescricao.Text;
				curso.validadeMeses = Convert.ToDateTime(mtbValidade.Text);

				CursoDAO cursoDAO = new CursoDAO();
				cursoDAO.cadastrarCurso(curso);

				limparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar curso: " + ex.Message);
			}

		}
		public void limparCampos()
		{
			txtNome.Clear();
			txtCargaHoraria.Clear();
			rtbDescricao.Clear();
			mtbValidade.Clear();
		}
	}
=======
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
>>>>>>> 86d21b56990a58794fbdcc6195eccea2369abbd0
}
