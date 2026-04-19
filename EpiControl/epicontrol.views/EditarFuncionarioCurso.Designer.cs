namespace EpiControl.epicontrol.views
{
    partial class frmEditarFuncionarioCurso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarFuncionarioCurso));
			panel1 = new Panel();
			label5 = new Label();
			label6 = new Label();
			pictureBox1 = new PictureBox();
			mtbConclusao = new MaskedTextBox();
			mtbInicio = new MaskedTextBox();
			cbxCurso = new ComboBox();
			cbxFuncionario = new ComboBox();
			label4 = new Label();
			label2 = new Label();
			label1 = new Label();
			label3 = new Label();
			btnEditar = new Button();
			btnExcluir = new Button();
			btnVoltar = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
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
			panel1.Size = new Size(458, 46);
			panel1.TabIndex = 90;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 20F);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(57, 4);
			label5.Name = "label5";
			label5.Size = new Size(378, 37);
			label5.TabIndex = 3;
			label5.Text = "EDITAR FUNCIONÁRIO CURSO";
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
			// mtbConclusao
			// 
			mtbConclusao.Location = new Point(161, 219);
			mtbConclusao.Mask = "00/00/0000";
			mtbConclusao.Name = "mtbConclusao";
			mtbConclusao.Size = new Size(98, 23);
			mtbConclusao.TabIndex = 87;
			mtbConclusao.ValidatingType = typeof(DateTime);
			// 
			// mtbInicio
			// 
			mtbInicio.Location = new Point(161, 170);
			mtbInicio.Mask = "00/00/0000";
			mtbInicio.Name = "mtbInicio";
			mtbInicio.Size = new Size(98, 23);
			mtbInicio.TabIndex = 86;
			mtbInicio.ValidatingType = typeof(DateTime);
			// 
			// cbxCurso
			// 
			cbxCurso.FormattingEnabled = true;
			cbxCurso.Location = new Point(161, 123);
			cbxCurso.Name = "cbxCurso";
			cbxCurso.Size = new Size(214, 23);
			cbxCurso.TabIndex = 85;
			// 
			// cbxFuncionario
			// 
			cbxFuncionario.FormattingEnabled = true;
			cbxFuncionario.Location = new Point(161, 78);
			cbxFuncionario.Name = "cbxFuncionario";
			cbxFuncionario.Size = new Size(214, 23);
			cbxFuncionario.TabIndex = 84;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(61, 81);
			label4.Name = "label4";
			label4.Size = new Size(73, 15);
			label4.TabIndex = 83;
			label4.Text = "Funcionário:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(61, 222);
			label2.Name = "label2";
			label2.Size = new Size(66, 15);
			label2.TabIndex = 82;
			label2.Text = "Conclusão:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(63, 173);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 81;
			label1.Text = "Inicio:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(61, 126);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 80;
			label3.Text = "Curso:";
			// 
			// btnEditar
			// 
			btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
			btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
			btnEditar.Location = new Point(283, 284);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(75, 40);
			btnEditar.TabIndex = 103;
			btnEditar.Text = "Editar";
			btnEditar.TextAlign = ContentAlignment.MiddleRight;
			btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			btnExcluir.BackColor = Color.Transparent;
			btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
			btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
			btnExcluir.Location = new Point(363, 284);
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Size = new Size(72, 40);
			btnExcluir.TabIndex = 102;
			btnExcluir.Text = "Excluir";
			btnExcluir.TextAlign = ContentAlignment.MiddleRight;
			btnExcluir.UseVisualStyleBackColor = false;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.Transparent;
			btnVoltar.Location = new Point(205, 284);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(72, 40);
			btnVoltar.TabIndex = 101;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			// 
			// frmEditarFuncionarioCurso
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(458, 336);
			Controls.Add(btnEditar);
			Controls.Add(btnExcluir);
			Controls.Add(btnVoltar);
			Controls.Add(panel1);
			Controls.Add(mtbConclusao);
			Controls.Add(mtbInicio);
			Controls.Add(cbxCurso);
			Controls.Add(cbxFuncionario);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(label3);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "frmEditarFuncionarioCurso";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += frmEditarFuncionarioCurso_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbConclusao;
        private MaskedTextBox mtbInicio;
        private ComboBox cbxCurso;
        private ComboBox cbxFuncionario;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
		private Button btnEditar;
		private Button btnExcluir;
		private Button btnVoltar;
	}
}