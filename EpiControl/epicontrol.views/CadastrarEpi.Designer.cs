namespace EpiControl.Views
{
    partial class frmCadastrarEpi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarEpi));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            txtCodigoInterno = new TextBox();
            label5 = new Label();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            label6 = new Label();
            txtCa = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtTamanho = new TextBox();
            label9 = new Label();
            txtCor = new TextBox();
            btnVoltar = new Button();
            txtMarca = new TextBox();
            label10 = new Label();
            label11 = new Label();
            rtbDescricao = new RichTextBox();
            label12 = new Label();
            label13 = new Label();
            cbxCategoria = new ComboBox();
            cbxFornecedor = new ComboBox();
            mtbValidadeCa = new MaskedTextBox();
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
            panel1.Size = new Size(484, 46);
            panel1.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(206, 37);
            label2.TabIndex = 3;
            label2.Text = "CADASTRAR EPI";
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
            label3.Location = new Point(57, 76);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 54;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(153, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 113);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 56;
            label4.Text = "Código Interno:";
            // 
            // txtCodigoInterno
            // 
            txtCodigoInterno.Location = new Point(153, 105);
            txtCodigoInterno.Name = "txtCodigoInterno";
            txtCodigoInterno.Size = new Size(132, 23);
            txtCodigoInterno.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 329);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 58;
            label5.Text = "Status:";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(153, 327);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 59;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(212, 327);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 60;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 148);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 61;
            label6.Text = "CA:";
            // 
            // txtCa
            // 
            txtCa.Location = new Point(153, 140);
            txtCa.Name = "txtCa";
            txtCa.Size = new Size(132, 23);
            txtCa.TabIndex = 62;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 222);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 63;
            label7.Text = "Validade do CA:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 184);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 65;
            label8.Text = "Tamanho:";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(153, 176);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(132, 23);
            txtTamanho.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 297);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 67;
            label9.Text = "Cor:";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(153, 294);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(132, 23);
            txtCor.TabIndex = 68;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(281, 553);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 69;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(153, 254);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(132, 23);
            txtMarca.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(57, 257);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 71;
            label10.Text = "Marca:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(57, 444);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 73;
            label11.Text = "Descrição:";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(152, 444);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(278, 82);
            rtbDescricao.TabIndex = 74;
            rtbDescricao.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(57, 365);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 75;
            label12.Text = "Categoria:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(57, 404);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 76;
            label13.Text = "Fornecedor";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Proteção da cabeça", "Proteção dos olhos e face", "Proteção auditiva", "Proteção respiratória", "Proteção do tronco", "Proteção das mãos e braços", "Proteção de pernas e pés", "Proteção contra quedas" });
            cbxCategoria.Location = new Point(153, 357);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(179, 23);
            cbxCategoria.TabIndex = 77;
            // 
            // cbxFornecedor
            // 
            cbxFornecedor.FormattingEnabled = true;
            cbxFornecedor.Location = new Point(152, 396);
            cbxFornecedor.Name = "cbxFornecedor";
            cbxFornecedor.Size = new Size(121, 23);
            cbxFornecedor.TabIndex = 78;
            // 
            // mtbValidadeCa
            // 
            mtbValidadeCa.Location = new Point(152, 214);
            mtbValidadeCa.Mask = "00/00/0000";
            mtbValidadeCa.Name = "mtbValidadeCa";
            mtbValidadeCa.Size = new Size(100, 23);
            mtbValidadeCa.TabIndex = 79;
            mtbValidadeCa.ValidatingType = typeof(DateTime);
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(359, 553);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 40);
            btnSalvar.TabIndex = 105;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastrarEpi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 608);
            Controls.Add(btnSalvar);
            Controls.Add(mtbValidadeCa);
            Controls.Add(cbxFornecedor);
            Controls.Add(cbxCategoria);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(rtbDescricao);
            Controls.Add(label11);
            Controls.Add(txtMarca);
            Controls.Add(label10);
            Controls.Add(btnVoltar);
            Controls.Add(txtCor);
            Controls.Add(label9);
            Controls.Add(txtTamanho);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCa);
            Controls.Add(label6);
            Controls.Add(rdbInativo);
            Controls.Add(rdbAtivo);
            Controls.Add(label5);
            Controls.Add(txtCodigoInterno);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastrarEpi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            Load += frmCadastrarEpi_Load;
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
        private TextBox txtNome;
        private Label label4;
        private TextBox txtCodigoInterno;
        private Label label5;
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
        private Label label6;
        private TextBox txtCa;
        private Label label7;
        private Label label8;
        private TextBox txtTamanho;
        private Label label9;
        private TextBox txtCor;
        private Button btnVoltar;
		private TextBox txtMarca;
		private Label label10;
		private Label label11;
		private RichTextBox rtbDescricao;
		private Label label12;
		private Label label13;
		private ComboBox cbxCategoria;
		private ComboBox cbxFornecedor;
		private MaskedTextBox mtbValidadeCa;
		private Button btnSalvar;
	}
}