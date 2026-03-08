namespace EpiControl.Views.Emprestimo
{
	partial class frmCadastroEmprestimo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEmprestimo));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label3 = new Label();
			cbxFuncionario = new ComboBox();
			label4 = new Label();
			label6 = new Label();
			cbxEpi = new ComboBox();
			label8 = new Label();
			nudQuantidade = new NumericUpDown();
			btnVoltar = new Button();
			label9 = new Label();
			mtbDataEmprestimo = new MaskedTextBox();
			rtbObservacoes = new RichTextBox();
			btnSalvar = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
			SuspendLayout();
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
			panel1.TabIndex = 7;
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
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(59, 83);
			label3.Name = "label3";
			label3.Size = new Size(128, 15);
			label3.TabIndex = 8;
			label3.Text = "Nome do Funcionario*";
			// 
			// cbxFuncionario
			// 
			cbxFuncionario.FormattingEnabled = true;
			cbxFuncionario.Location = new Point(211, 80);
			cbxFuncionario.Name = "cbxFuncionario";
			cbxFuncionario.Size = new Size(249, 23);
			cbxFuncionario.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(59, 217);
			label4.Name = "label4";
			label4.Size = new Size(74, 15);
			label4.TabIndex = 10;
			label4.Text = "Quantidade*";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(59, 134);
			label6.Name = "label6";
			label6.Size = new Size(120, 15);
			label6.TabIndex = 20;
			label6.Text = "Data do Empréstimo*";
			// 
			// cbxEpi
			// 
			cbxEpi.FormattingEnabled = true;
			cbxEpi.Location = new Point(211, 173);
			cbxEpi.Name = "cbxEpi";
			cbxEpi.Size = new Size(249, 23);
			cbxEpi.TabIndex = 26;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(59, 176);
			label8.Name = "label8";
			label8.Size = new Size(28, 15);
			label8.TabIndex = 25;
			label8.Text = "EPI*";
			// 
			// nudQuantidade
			// 
			nudQuantidade.Location = new Point(211, 209);
			nudQuantidade.Name = "nudQuantidade";
			nudQuantidade.Size = new Size(50, 23);
			nudQuantidade.TabIndex = 53;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.Transparent;
			btnVoltar.Location = new Point(400, 424);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(75, 40);
			btnVoltar.TabIndex = 71;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(251, 258);
			label9.Name = "label9";
			label9.Size = new Size(74, 15);
			label9.TabIndex = 73;
			label9.Text = "Observações";
			// 
			// mtbDataEmprestimo
			// 
			mtbDataEmprestimo.Location = new Point(211, 126);
			mtbDataEmprestimo.Mask = "__/__/____";
			mtbDataEmprestimo.Name = "mtbDataEmprestimo";
			mtbDataEmprestimo.Size = new Size(132, 23);
			mtbDataEmprestimo.TabIndex = 75;
			mtbDataEmprestimo.ValidatingType = typeof(DateTime);
			// 
			// rtbObservacoes
			// 
			rtbObservacoes.Location = new Point(57, 283);
			rtbObservacoes.Name = "rtbObservacoes";
			rtbObservacoes.Size = new Size(499, 113);
			rtbObservacoes.TabIndex = 77;
			rtbObservacoes.Text = "";
			// 
			// btnSalvar
			// 
			btnSalvar.BackColor = Color.FromArgb(17, 138, 254);
			btnSalvar.FlatAppearance.BorderSize = 0;
			btnSalvar.FlatStyle = FlatStyle.Flat;
			btnSalvar.ForeColor = Color.White;
			btnSalvar.Location = new Point(481, 424);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(75, 40);
			btnSalvar.TabIndex = 222;
			btnSalvar.Text = " Salvar";
			btnSalvar.UseVisualStyleBackColor = false;
			// 
			// frmCadastroEmprestimo
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
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmCadastroEmprestimo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += CadastrarEmprestimo_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label3;
		private ComboBox cbxFuncionario;
		private Label label4;
		private Label label6;
		private ComboBox cbxEpi;
		private Label label8;
		private NumericUpDown nudQuantidade;
		private TreeView treeView1;
		private Button button2;
		private Button btnVoltar;
		private Label label9;
		private MaskedTextBox mtbDataEmprestimo;
		private RichTextBox rtbObservacoes;
		private Button btnSalvar;
	}
}