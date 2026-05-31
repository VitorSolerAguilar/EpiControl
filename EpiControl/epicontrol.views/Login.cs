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
    }
}
