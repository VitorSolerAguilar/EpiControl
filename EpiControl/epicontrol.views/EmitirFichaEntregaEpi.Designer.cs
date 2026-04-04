namespace EpiControl.epicontrol.views
{
	partial class EmitirFichaEntregaEpi
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
			cbxFuncionario = new ComboBox();
			btnGerarFicha = new Button();
			SuspendLayout();
			// 
			// cbxFuncionario
			// 
			cbxFuncionario.FormattingEnabled = true;
			cbxFuncionario.Location = new Point(181, 55);
			cbxFuncionario.Name = "cbxFuncionario";
			cbxFuncionario.Size = new Size(288, 23);
			cbxFuncionario.TabIndex = 0;
			// 
			// btnGerarFicha
			// 
			btnGerarFicha.Location = new Point(394, 256);
			btnGerarFicha.Name = "btnGerarFicha";
			btnGerarFicha.Size = new Size(75, 23);
			btnGerarFicha.TabIndex = 1;
			btnGerarFicha.Text = "button1";
			btnGerarFicha.UseVisualStyleBackColor = true;
			btnGerarFicha.Click += btnGerarFicha_Click;
			// 
			// EmitirFichaEntregaEpi
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnGerarFicha);
			Controls.Add(cbxFuncionario);
			Name = "EmitirFichaEntregaEpi";
			Text = "EmitirFichaEntregaEpi";
			Load += EmitirFichaEntregaEpi_Load;
			ResumeLayout(false);
		}

		#endregion

		private ComboBox cbxFuncionario;
		private Button btnGerarFicha;
	}
}