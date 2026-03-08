namespace EpiControl.views
{
	partial class frmCadastrarNormaRegulamentadora
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarNormaRegulamentadora));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label3 = new Label();
			txtTitulo = new TextBox();
			label4 = new Label();
			label5 = new Label();
			rtbDescricao = new RichTextBox();
			label6 = new Label();
			label7 = new Label();
			txtLinkMte = new TextBox();
			nudNumeroNr = new NumericUpDown();
			btnSalvar = new Button();
			btnVoltar = new Button();
			mtbDataVigencia = new MaskedTextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudNumeroNr).BeginInit();
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
			panel1.Size = new Size(578, 46);
			panel1.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(193, 37);
			label2.TabIndex = 3;
			label2.Text = "CADASTRO NR";
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
			label3.Location = new Point(57, 101);
			label3.Name = "label3";
			label3.Size = new Size(91, 15);
			label3.TabIndex = 8;
			label3.Text = "Numero da NR*";
			// 
			// txtTitulo
			// 
			txtTitulo.Location = new Point(187, 135);
			txtTitulo.Name = "txtTitulo";
			txtTitulo.Size = new Size(349, 23);
			txtTitulo.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(57, 143);
			label4.Name = "label4";
			label4.Size = new Size(42, 15);
			label4.TabIndex = 10;
			label4.Text = "Titulo*";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(57, 198);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 13;
			label5.Text = "Descrição*";
			// 
			// rtbDescricao
			// 
			rtbDescricao.Location = new Point(187, 195);
			rtbDescricao.Name = "rtbDescricao";
			rtbDescricao.Size = new Size(349, 74);
			rtbDescricao.TabIndex = 14;
			rtbDescricao.Text = "";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(57, 343);
			label6.Name = "label6";
			label6.Size = new Size(98, 15);
			label6.TabIndex = 16;
			label6.Text = "Data de Vigência ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(57, 285);
			label7.Name = "label7";
			label7.Size = new Size(105, 15);
			label7.TabIndex = 17;
			label7.Text = "Link Oficial (MTE)*";
			// 
			// txtLinkMte
			// 
			txtLinkMte.Location = new Point(187, 277);
			txtLinkMte.Name = "txtLinkMte";
			txtLinkMte.Size = new Size(349, 23);
			txtLinkMte.TabIndex = 18;
			// 
			// nudNumeroNr
			// 
			nudNumeroNr.Location = new Point(187, 93);
			nudNumeroNr.Name = "nudNumeroNr";
			nudNumeroNr.Size = new Size(63, 23);
			nudNumeroNr.TabIndex = 19;
			// 
			// btnSalvar
			// 
			btnSalvar.BackColor = Color.FromArgb(17, 138, 254);
			btnSalvar.FlatAppearance.BorderSize = 0;
			btnSalvar.FlatStyle = FlatStyle.Flat;
			btnSalvar.ForeColor = Color.White;
			btnSalvar.Location = new Point(461, 416);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(75, 40);
			btnSalvar.TabIndex = 20;
			btnSalvar.Text = " Salvar";
			btnSalvar.UseVisualStyleBackColor = false;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.Transparent;
			btnVoltar.Location = new Point(360, 416);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(75, 40);
			btnVoltar.TabIndex = 21;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			btnVoltar.Click += btnVoltar_Click;
			// 
			// mtbDataVigencia
			// 
			mtbDataVigencia.Location = new Point(187, 335);
			mtbDataVigencia.Mask = "00/00/0000";
			mtbDataVigencia.Name = "mtbDataVigencia";
			mtbDataVigencia.Size = new Size(125, 23);
			mtbDataVigencia.TabIndex = 22;
			mtbDataVigencia.ValidatingType = typeof(DateTime);
			// 
			// frmCadastrarNormaRegulamentadora
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(578, 478);
			Controls.Add(mtbDataVigencia);
			Controls.Add(btnVoltar);
			Controls.Add(btnSalvar);
			Controls.Add(nudNumeroNr);
			Controls.Add(txtLinkMte);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(rtbDescricao);
			Controls.Add(label5);
			Controls.Add(txtTitulo);
			Controls.Add(label4);
			Controls.Add(panel1);
			Controls.Add(label3);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmCadastrarNormaRegulamentadora";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)nudNumeroNr).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label3;
		private TextBox txtTitulo;
		private Label label4;
		private Label label5;
		private RichTextBox rtbDescricao;
		private Label label6;
		private Label label7;
		private TextBox txtLinkMte;
		private NumericUpDown nudNumeroNr;
		private Button btnSalvar;
		private Button btnVoltar;
		private MaskedTextBox mtbDataVigencia;
	}
}