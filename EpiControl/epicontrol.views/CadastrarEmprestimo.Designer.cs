namespace EpiControl.epicontrol.views
{
	partial class frmCadastrarEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarEmprestimo));
            rtbObservacoes = new RichTextBox();
            mtbDataEmprestimo = new MaskedTextBox();
            label9 = new Label();
            btnVoltar = new Button();
            nudQuantidade = new NumericUpDown();
            cbxEpi = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            cbxFuncionario = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rtbObservacoes
            // 
            rtbObservacoes.Location = new Point(57, 276);
            rtbObservacoes.Name = "rtbObservacoes";
            rtbObservacoes.Size = new Size(499, 113);
            rtbObservacoes.TabIndex = 234;
            rtbObservacoes.Text = "";
            // 
            // mtbDataEmprestimo
            // 
            mtbDataEmprestimo.Location = new Point(211, 119);
            mtbDataEmprestimo.Mask = "00/00/0000";
            mtbDataEmprestimo.Name = "mtbDataEmprestimo";
            mtbDataEmprestimo.Size = new Size(132, 23);
            mtbDataEmprestimo.TabIndex = 233;
            mtbDataEmprestimo.ValidatingType = typeof(DateTime);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(251, 251);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 232;
            label9.Text = "Observações";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(406, 417);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 231;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(211, 202);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(50, 23);
            nudQuantidade.TabIndex = 230;
            // 
            // cbxEpi
            // 
            cbxEpi.FormattingEnabled = true;
            cbxEpi.Location = new Point(211, 166);
            cbxEpi.Name = "cbxEpi";
            cbxEpi.Size = new Size(249, 23);
            cbxEpi.TabIndex = 229;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 169);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 228;
            label8.Text = "EPI *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 127);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 227;
            label6.Text = "Data do Empréstimo *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 210);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 226;
            label4.Text = "Quantidade *";
            // 
            // cbxFuncionario
            // 
            cbxFuncionario.FormattingEnabled = true;
            cbxFuncionario.Location = new Point(211, 73);
            cbxFuncionario.Name = "cbxFuncionario";
            cbxFuncionario.Size = new Size(249, 23);
            cbxFuncionario.TabIndex = 225;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 76);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 224;
            label3.Text = "Nome do Funcionario *";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 46);
            panel1.TabIndex = 223;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(359, 37);
            label2.TabIndex = 3;
            label2.Text = "CADASTRO DE EMPRÉSTIMO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 2;
            label1.Text = "EPI CONTROL";
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
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(484, 417);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 40);
            btnSalvar.TabIndex = 235;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastrarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 469);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObservacoes);
            Controls.Add(mtbDataEmprestimo);
            Controls.Add(label9);
            Controls.Add(btnVoltar);
            Controls.Add(nudQuantidade);
            Controls.Add(cbxEpi);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cbxFuncionario);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastrarEmprestimo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            Load += CadastrarEmprestimo_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbObservacoes;
		private MaskedTextBox mtbDataEmprestimo;
		private Label label9;
		private Button btnVoltar;
		private NumericUpDown nudQuantidade;
		private ComboBox cbxEpi;
		private Label label8;
		private Label label6;
		private Label label4;
		private ComboBox cbxFuncionario;
		private Label label3;
		private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Button btnSalvar;
	}
}