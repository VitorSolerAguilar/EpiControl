namespace EpiControl.epicontrol.views
{
	partial class frmCadastrarMovimentacaoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarMovimentacaoEstoque));
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtQuantidade = new TextBox();
            rtbObservacao = new RichTextBox();
            cbxFuncionario = new ComboBox();
            label2 = new Label();
            cbxEpi = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            mtbDataEmprestimo = new MaskedTextBox();
            label4 = new Label();
            cbxTipoMovimentacao = new ComboBox();
            label7 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
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
            panel1.Size = new Size(595, 46);
            panel1.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(57, 4);
            label5.Name = "label5";
            label5.Size = new Size(537, 37);
            label5.TabIndex = 3;
            label5.Text = "CADASTRAR MOVIMENTAÇÃO DE ESTOQUE";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 89);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 81;
            label1.Text = "Funcionário *";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(213, 218);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(64, 23);
            txtQuantidade.TabIndex = 82;
            // 
            // rtbObservacao
            // 
            rtbObservacao.Location = new Point(213, 311);
            rtbObservacao.Name = "rtbObservacao";
            rtbObservacao.Size = new Size(288, 96);
            rtbObservacao.TabIndex = 83;
            rtbObservacao.Text = "";
            // 
            // cbxFuncionario
            // 
            cbxFuncionario.FormattingEnabled = true;
            cbxFuncionario.Location = new Point(213, 86);
            cbxFuncionario.Name = "cbxFuncionario";
            cbxFuncionario.Size = new Size(288, 23);
            cbxFuncionario.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 133);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 85;
            label2.Text = "E.P.I *";
            // 
            // cbxEpi
            // 
            cbxEpi.FormattingEnabled = true;
            cbxEpi.Location = new Point(213, 130);
            cbxEpi.Name = "cbxEpi";
            cbxEpi.Size = new Size(288, 23);
            cbxEpi.TabIndex = 86;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 221);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 87;
            label8.Text = "Quantidade *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 263);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 88;
            label3.Text = "Data de empréstimo *";
            // 
            // mtbDataEmprestimo
            // 
            mtbDataEmprestimo.Location = new Point(213, 260);
            mtbDataEmprestimo.Mask = "00/00/0000";
            mtbDataEmprestimo.Name = "mtbDataEmprestimo";
            mtbDataEmprestimo.Size = new Size(100, 23);
            mtbDataEmprestimo.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 314);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 90;
            label4.Text = "Observações:";
            // 
            // cbxTipoMovimentacao
            // 
            cbxTipoMovimentacao.FormattingEnabled = true;
            cbxTipoMovimentacao.Items.AddRange(new object[] { "Entrada de Compra", "Entrada de Devolução", "Saida Emprestimo", "Saida Descarte", "Ajuste Positivo", "Ajuste Negativo", "Transferencia" });
            cbxTipoMovimentacao.Location = new Point(213, 175);
            cbxTipoMovimentacao.Name = "cbxTipoMovimentacao";
            cbxTipoMovimentacao.Size = new Size(260, 23);
            cbxTipoMovimentacao.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 178);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 91;
            label7.Text = "Tipo de movimentação *";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(351, 456);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 93;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(429, 456);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 40);
            btnSalvar.TabIndex = 104;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastrarMovimentacaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 513);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(cbxTipoMovimentacao);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(mtbDataEmprestimo);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(cbxEpi);
            Controls.Add(label2);
            Controls.Add(cbxFuncionario);
            Controls.Add(rtbObservacao);
            Controls.Add(txtQuantidade);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastrarMovimentacaoEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            Load += frmCadastrarMovimentacaoEstoque_Load;
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
		private Label label1;
		private TextBox txtQuantidade;
		private RichTextBox rtbObservacao;
		private ComboBox cbxFuncionario;
		private Label label2;
		private ComboBox cbxEpi;
		private Label label8;
		private Label label3;
		private MaskedTextBox mtbDataEmprestimo;
		private Label label4;
		private ComboBox cbxTipoMovimentacao;
		private Label label7;
		private Button btnVoltar;
		private Button btnSalvar;
	}
}