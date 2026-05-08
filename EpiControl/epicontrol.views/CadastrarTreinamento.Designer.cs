namespace EpiControl.epicontrol.views
{
	partial class frmCadastrarTreinamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarTreinamento));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNome = new TextBox();
            txtCargaHoraria = new TextBox();
            rtbDescricao = new RichTextBox();
            mtbValidade = new MaskedTextBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(489, 46);
            panel1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(349, 37);
            label2.TabIndex = 3;
            label2.Text = "CADASTRAR TREINAMENTO";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 85);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 29;
            label4.Text = "Nome treinamento *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 130);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 30;
            label5.Text = "Carga horária *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 226);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 31;
            label6.Text = "Descricao:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 176);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 32;
            label7.Text = "Validade *";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(177, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(265, 23);
            txtNome.TabIndex = 33;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(177, 122);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(100, 23);
            txtCargaHoraria.TabIndex = 34;
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(177, 226);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(265, 96);
            rtbDescricao.TabIndex = 35;
            rtbDescricao.Text = "";
            // 
            // mtbValidade
            // 
            mtbValidade.Location = new Point(177, 168);
            mtbValidade.Mask = "00/00/0000";
            mtbValidade.Name = "mtbValidade";
            mtbValidade.Size = new Size(100, 23);
            mtbValidade.TabIndex = 36;
            mtbValidade.ValidatingType = typeof(DateTime);
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(327, 354);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 95;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(405, 354);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 40);
            btnSalvar.TabIndex = 103;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastrarTreinamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(489, 406);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(mtbValidade);
            Controls.Add(rtbDescricao);
            Controls.Add(txtCargaHoraria);
            Controls.Add(txtNome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastrarTreinamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox txtNome;
		private TextBox txtCargaHoraria;
		private RichTextBox rtbDescricao;
		private MaskedTextBox mtbValidade;
		private Button btnVoltar;
		private Button btnSalvar;
	}
}