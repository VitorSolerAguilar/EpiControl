namespace EpiControl.Views
{
	partial class frmEditarNormaRegulamentadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarNormaRegulamentadora));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtLinkMte = new TextBox();
            label7 = new Label();
            label6 = new Label();
            rtbDescricao = new RichTextBox();
            label5 = new Label();
            txtTitulo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            mtbDataVigencia = new MaskedTextBox();
            txtNumeroNr = new TextBox();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 46);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(145, 37);
            label2.TabIndex = 3;
            label2.Text = "EDITAR NR";
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
            // txtLinkMte
            // 
            txtLinkMte.Location = new Point(186, 284);
            txtLinkMte.Name = "txtLinkMte";
            txtLinkMte.Size = new Size(349, 23);
            txtLinkMte.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 284);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 29;
            label7.Text = "Link Oficial (MTE) *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 342);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 28;
            label6.Text = "Data de Vigência ";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(186, 194);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(349, 74);
            rtbDescricao.TabIndex = 26;
            rtbDescricao.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 197);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 25;
            label5.Text = "Descrição *";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(186, 142);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(349, 23);
            txtTitulo.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 142);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 23;
            label4.Text = "Título *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 100);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 22;
            label3.Text = "Numero da NR *";
            // 
            // mtbDataVigencia
            // 
            mtbDataVigencia.Location = new Point(186, 334);
            mtbDataVigencia.Mask = "00/00/0000";
            mtbDataVigencia.Name = "mtbDataVigencia";
            mtbDataVigencia.Size = new Size(125, 23);
            mtbDataVigencia.TabIndex = 35;
            mtbDataVigencia.ValidatingType = typeof(DateTime);
            // 
            // txtNumeroNr
            // 
            txtNumeroNr.Location = new Point(186, 92);
            txtNumeroNr.Name = "txtNumeroNr";
            txtNumeroNr.Size = new Size(84, 23);
            txtNumeroNr.TabIndex = 36;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(383, 413);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 103;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(463, 413);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(72, 40);
            btnExcluir.TabIndex = 102;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(305, 413);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 101;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmEditarNormaRegulamentadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 465);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(txtNumeroNr);
            Controls.Add(mtbDataVigencia);
            Controls.Add(txtLinkMte);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(rtbDescricao);
            Controls.Add(label5);
            Controls.Add(txtTitulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmEditarNormaRegulamentadora";
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
		private TextBox txtLinkMte;
		private Label label7;
		private Label label6;
		private RichTextBox rtbDescricao;
		private Label label5;
		private TextBox txtTitulo;
		private Label label4;
		private Label label3;
		private MaskedTextBox mtbDataVigencia;
		private TextBox txtNumeroNr;
		private Button btnEditar;
		private Button btnExcluir;
		private Button btnVoltar;
	}
}