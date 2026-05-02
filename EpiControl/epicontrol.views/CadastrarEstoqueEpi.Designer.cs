namespace EpiControl.epicontrol.views
{
	partial class frmCadastrarEstoqueEpi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarEstoqueEpi));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtQuantidade = new TextBox();
            rtbLocalizacao = new RichTextBox();
            txtEstoqueMinimo = new TextBox();
            cbxEpi = new ComboBox();
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
            panel1.Size = new Size(479, 46);
            panel1.TabIndex = 224;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(354, 37);
            label2.TabIndex = 3;
            label2.Text = "CADASTRO ESTOQUE DE EPI";
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
            label3.Location = new Point(57, 136);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 225;
            label3.Text = "Quantidade: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 238);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 226;
            label4.Text = "Localização: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 188);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 227;
            label5.Text = "Estoque Minimo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 95);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 228;
            label6.Text = "Epi: : ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(163, 133);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(102, 23);
            txtQuantidade.TabIndex = 230;
            // 
            // rtbLocalizacao
            // 
            rtbLocalizacao.Location = new Point(163, 238);
            rtbLocalizacao.Name = "rtbLocalizacao";
            rtbLocalizacao.Size = new Size(278, 96);
            rtbLocalizacao.TabIndex = 231;
            rtbLocalizacao.Text = "";
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(163, 185);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(102, 23);
            txtEstoqueMinimo.TabIndex = 232;
            // 
            // cbxEpi
            // 
            cbxEpi.FormattingEnabled = true;
            cbxEpi.Location = new Point(163, 92);
            cbxEpi.Name = "cbxEpi";
            cbxEpi.Size = new Size(248, 23);
            cbxEpi.TabIndex = 233;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(291, 373);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 236;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(369, 373);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 40);
            btnSalvar.TabIndex = 237;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastrarEstoqueEpi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 431);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(cbxEpi);
            Controls.Add(txtEstoqueMinimo);
            Controls.Add(rtbLocalizacao);
            Controls.Add(txtQuantidade);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastrarEstoqueEpi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            Load += frmCadastrarEstoqueEpi_Load;
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
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private ContextMenuStrip contextMenuStrip1;
		private TextBox txtQuantidade;
		private RichTextBox rtbLocalizacao;
		private TextBox txtEstoqueMinimo;
		private ComboBox cbxEpi;
		private Button btnVoltar;
		private Button btnSalvar;
	}
}