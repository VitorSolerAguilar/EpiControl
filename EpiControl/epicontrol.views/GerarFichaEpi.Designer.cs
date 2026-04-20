namespace EpiControl.epicontrol.views
{
	partial class frmGerarFichaEpi
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarFichaEpi));
			cbxFuncionario = new ComboBox();
			btnGerarFicha = new Button();
			SuspendLayout();
			// 
			// cbxFuncionario
			// 
			cbxFuncionario.FormattingEnabled = true;
			cbxFuncionario.Location = new Point(249, 168);
			cbxFuncionario.Name = "cbxFuncionario";
			cbxFuncionario.Size = new Size(330, 23);
			cbxFuncionario.TabIndex = 0;
			// 
			// btnGerarFicha
			// 
			btnGerarFicha.Location = new Point(587, 363);
			btnGerarFicha.Name = "btnGerarFicha";
			btnGerarFicha.Size = new Size(75, 23);
			btnGerarFicha.TabIndex = 1;
			btnGerarFicha.Text = "Gerar Ficha";
			btnGerarFicha.UseVisualStyleBackColor = true;
			btnGerarFicha.Click += btnGerarFicha_Click;
			// 
			// frmGerarFichaEpi
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnGerarFicha);
			Controls.Add(cbxFuncionario);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "frmGerarFichaEpi";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += frmGerarFichaEpi_Load;
			ResumeLayout(false);
		}

		#endregion

		private ComboBox cbxFuncionario;
		private Button btnGerarFicha;
	}
}