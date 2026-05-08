namespace EpiControl.Views
{
    partial class frmEditarEpi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarEpi));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mtbValidadeCa = new MaskedTextBox();
            cbxFornecedor = new ComboBox();
            cbxCategoria = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            rtbDescricao = new RichTextBox();
            label11 = new Label();
            txtMarca = new TextBox();
            label10 = new Label();
            txtCor = new TextBox();
            label9 = new Label();
            txtTamanho = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtCa = new TextBox();
            label6 = new Label();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            label5 = new Label();
            txtCodigoInterno = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 46);
            panel1.TabIndex = 71;
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
            label2.Text = "EDITAR EPI";
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
            // mtbValidadeCa
            // 
            mtbValidadeCa.Location = new Point(150, 209);
            mtbValidadeCa.Mask = "00/00/0000";
            mtbValidadeCa.Name = "mtbValidadeCa";
            mtbValidadeCa.Size = new Size(100, 23);
            mtbValidadeCa.TabIndex = 104;
            mtbValidadeCa.ValidatingType = typeof(DateTime);
            // 
            // cbxFornecedor
            // 
            cbxFornecedor.FormattingEnabled = true;
            cbxFornecedor.Location = new Point(150, 391);
            cbxFornecedor.Name = "cbxFornecedor";
            cbxFornecedor.Size = new Size(121, 23);
            cbxFornecedor.TabIndex = 103;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Proteção da cabeça", "Proteção dos olhos e face", "Proteção auditiva", "Proteção respiratória", "Proteção do tronco", "Proteção das mãos e braços", "Proteção de pernas e pés", "Proteção contra quedas" });
            cbxCategoria.Location = new Point(151, 352);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(179, 23);
            cbxCategoria.TabIndex = 102;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(55, 399);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 101;
            label13.Text = "Fornecedor *";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(55, 360);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 100;
            label12.Text = "Categoria";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(150, 439);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(278, 82);
            rtbDescricao.TabIndex = 99;
            rtbDescricao.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 439);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 98;
            label11.Text = "Descrição";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(151, 249);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(132, 23);
            txtMarca.TabIndex = 97;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 252);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 96;
            label10.Text = "Marca";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(151, 289);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(132, 23);
            txtCor.TabIndex = 93;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 292);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 92;
            label9.Text = "Cor";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(151, 171);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(132, 23);
            txtTamanho.TabIndex = 91;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 179);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 90;
            label8.Text = "Tamanho *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 217);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 89;
            label7.Text = "Validade do CA *";
            // 
            // txtCa
            // 
            txtCa.Location = new Point(151, 135);
            txtCa.MaxLength = 11;
            txtCa.Name = "txtCa";
            txtCa.Size = new Size(132, 23);
            txtCa.TabIndex = 88;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 143);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 87;
            label6.Text = "CA *";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(210, 322);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 86;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(151, 322);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 85;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 324);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 84;
            label5.Text = "Status *";
            // 
            // txtCodigoInterno
            // 
            txtCodigoInterno.Location = new Point(151, 100);
            txtCodigoInterno.Name = "txtCodigoInterno";
            txtCodigoInterno.Size = new Size(132, 23);
            txtCodigoInterno.TabIndex = 83;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 108);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 82;
            label4.Text = "Código Interno";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(151, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 81;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 71);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 80;
            label3.Text = "Nome *";
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(310, 556);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 107;
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
            btnExcluir.Location = new Point(390, 556);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(72, 40);
            btnExcluir.TabIndex = 106;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(232, 556);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 105;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmEditarEpi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 608);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(mtbValidadeCa);
            Controls.Add(cbxFornecedor);
            Controls.Add(cbxCategoria);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(rtbDescricao);
            Controls.Add(label11);
            Controls.Add(txtMarca);
            Controls.Add(label10);
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
            Name = "frmEditarEpi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            Load += frmEditarEpi_Load;
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
		private MaskedTextBox mtbValidadeCa;
		private ComboBox cbxFornecedor;
		private ComboBox cbxCategoria;
		private Label label13;
		private Label label12;
		private RichTextBox rtbDescricao;
		private Label label11;
		private TextBox txtMarca;
		private Label label10;
		private TextBox txtCor;
		private Label label9;
		private TextBox txtTamanho;
		private Label label8;
		private Label label7;
		private TextBox txtCa;
		private Label label6;
		private RadioButton rdbInativo;
		private RadioButton rdbAtivo;
		private Label label5;
		private TextBox txtCodigoInterno;
		private Label label4;
		private TextBox txtNome;
		private Label label3;
		private Button btnEditar;
		private Button btnExcluir;
		private Button btnVoltar;
	}
}