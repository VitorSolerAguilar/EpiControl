namespace EpiControl.epicontrol.views
{
    partial class frmCadastrarFuncionarioCurso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFuncionarioCurso));
			label3 = new Label();
			label1 = new Label();
			label2 = new Label();
			label4 = new Label();
			cbxFuncionario = new ComboBox();
			cbxCurso = new ComboBox();
			mtbInicio = new MaskedTextBox();
			mtbConclusao = new MaskedTextBox();
			btnVoltar = new Button();
			btnSalvar = new Button();
			panel1 = new Panel();
			label5 = new Label();
			label6 = new Label();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(58, 109);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 56;
			label3.Text = "Curso:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(60, 156);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 57;
			label1.Text = "Inicio:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(58, 205);
			label2.Name = "label2";
			label2.Size = new Size(66, 15);
			label2.TabIndex = 58;
			label2.Text = "Conclusão:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(58, 64);
			label4.Name = "label4";
			label4.Size = new Size(73, 15);
			label4.TabIndex = 59;
			label4.Text = "Funcionário:";
			// 
			// cbxFuncionario
			// 
			cbxFuncionario.FormattingEnabled = true;
			cbxFuncionario.Location = new Point(158, 61);
			cbxFuncionario.Name = "cbxFuncionario";
			cbxFuncionario.Size = new Size(186, 23);
			cbxFuncionario.TabIndex = 61;
			// 
			// cbxCurso
			// 
			cbxCurso.FormattingEnabled = true;
			cbxCurso.Location = new Point(158, 106);
			cbxCurso.Name = "cbxCurso";
			cbxCurso.Size = new Size(186, 23);
			cbxCurso.TabIndex = 62;
			// 
			// mtbInicio
			// 
			mtbInicio.Location = new Point(158, 153);
			mtbInicio.Mask = "00/00/0000";
			mtbInicio.Name = "mtbInicio";
			mtbInicio.Size = new Size(98, 23);
			mtbInicio.TabIndex = 74;
			mtbInicio.ValidatingType = typeof(DateTime);
			// 
			// mtbConclusao
			// 
			mtbConclusao.Location = new Point(158, 202);
			mtbConclusao.Mask = "00/00/0000";
			mtbConclusao.Name = "mtbConclusao";
			mtbConclusao.Size = new Size(98, 23);
			mtbConclusao.TabIndex = 75;
			mtbConclusao.ValidatingType = typeof(DateTime);
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.Transparent;
			btnVoltar.Location = new Point(300, 253);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(75, 40);
			btnVoltar.TabIndex = 77;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			btnVoltar.Click += btnVoltar_Click;
			// 
			// btnSalvar
			// 
			btnSalvar.BackColor = Color.FromArgb(17, 138, 254);
			btnSalvar.FlatAppearance.BorderSize = 0;
			btnSalvar.FlatStyle = FlatStyle.Flat;
			btnSalvar.ForeColor = Color.White;
			btnSalvar.Location = new Point(391, 253);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(75, 40);
			btnSalvar.TabIndex = 78;
			btnSalvar.Text = " Salvar";
			btnSalvar.UseVisualStyleBackColor = false;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(509, 46);
			panel1.TabIndex = 79;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 20F);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(57, 4);
			label5.Name = "label5";
			label5.Size = new Size(439, 37);
			label5.TabIndex = 3;
			label5.Text = "CADASTRAR FUNCIONARIO CURSO";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 15F);
			label6.Location = new Point(57, 9);
			label6.Name = "label6";
			label6.Size = new Size(130, 28);
			label6.TabIndex = 2;
			label6.Text = "EPI CONTROL";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(1, -1);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(53, 51);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// frmCadastrarFuncionarioCurso
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(509, 318);
			Controls.Add(panel1);
			Controls.Add(btnSalvar);
			Controls.Add(btnVoltar);
			Controls.Add(mtbConclusao);
			Controls.Add(mtbInicio);
			Controls.Add(cbxCurso);
			Controls.Add(cbxFuncionario);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(label3);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmCadastrarFuncionarioCurso";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += frmCadastrarFuncionarioCurso_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox cbxFuncionario;
        private ComboBox cbxCurso;
        private MaskedTextBox mtbInicio;
        private MaskedTextBox mtbConclusao;
        private Button btnVoltar;
        private Button btnSalvar;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}