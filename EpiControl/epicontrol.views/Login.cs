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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool senhaVisivel = false;

        private string pastaIcons = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "epicontrol.resources", "Icons");

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(Path.Combine(pastaIcons, "olho-fechado-20px.png"));
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioCorreto = "admin";
            string senhaCorreta = "1234";

            if (txtUsuario.Text == usuarioCorreto && txtSenha.Text == senhaCorreta)
            {
                frmHome home = new frmHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            if (senhaVisivel)
            {
                txtSenha.PasswordChar = '\0';
                pictureBox3.Image = Image.FromFile(Path.Combine(pastaIcons, "olho-aberto-20px.png"));
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pictureBox3.Image = Image.FromFile(Path.Combine(pastaIcons, "olho-fechado-20px.png"));
            }
        }
    }
}
