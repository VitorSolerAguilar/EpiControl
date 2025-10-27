using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpiControl
{
	public partial class NormasRegulamentadoras : Form
	{
		public NormasRegulamentadoras()
		{
			InitializeComponent();
		}

		private void btn_voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
