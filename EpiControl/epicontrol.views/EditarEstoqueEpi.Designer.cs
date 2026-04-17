namespace EpiControl.epicontrol.views
{
	partial class frmEditarEstoqueEpi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarEstoqueEpi));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label6 = new Label();
			label5 = new Label();
			label7 = new Label();
			label8 = new Label();
			contextMenuStrip1 = new ContextMenuStrip(components);
			cbxEpi = new ComboBox();
			txtEstoqueMinimo = new TextBox();
			rtbLocalizacao = new RichTextBox();
			txtQuantidade = new TextBox();
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
			panel1.Size = new Size(479, 46);
			panel1.TabIndex = 72;
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
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(57, 84);
			label6.Name = "label6";
			label6.Size = new Size(35, 15);
			label6.TabIndex = 242;
			label6.Text = "Epi: : ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(57, 177);
			label5.Name = "label5";
			label5.Size = new Size(100, 15);
			label5.TabIndex = 241;
			label5.Text = "Estoque Mínimo: ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(57, 227);
			label7.Name = "label7";
			label7.Size = new Size(74, 15);
			label7.TabIndex = 240;
			label7.Text = "Localização: ";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(57, 125);
			label8.Name = "label8";
			label8.Size = new Size(75, 15);
			label8.TabIndex = 239;
			label8.Text = "Quantidade: ";
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// cbxEpi
			// 
			cbxEpi.FormattingEnabled = true;
			cbxEpi.Location = new Point(163, 81);
			cbxEpi.Name = "cbxEpi";
			cbxEpi.Size = new Size(248, 23);
			cbxEpi.TabIndex = 246;
			// 
			// txtEstoqueMinimo
			// 
			txtEstoqueMinimo.Location = new Point(163, 174);
			txtEstoqueMinimo.Name = "txtEstoqueMinimo";
			txtEstoqueMinimo.Size = new Size(102, 23);
			txtEstoqueMinimo.TabIndex = 245;
			// 
			// rtbLocalizacao
			// 
			rtbLocalizacao.Location = new Point(163, 227);
			rtbLocalizacao.Name = "rtbLocalizacao";
			rtbLocalizacao.Size = new Size(278, 96);
			rtbLocalizacao.TabIndex = 244;
			rtbLocalizacao.Text = "";
			// 
			// txtQuantidade
			// 
			txtQuantidade.Location = new Point(163, 122);
			txtQuantidade.Name = "txtQuantidade";
			txtQuantidade.Size = new Size(102, 23);
			txtQuantidade.TabIndex = 243;
			// 
			// btnEditar
			// 
			btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
			btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
			btnEditar.Location = new Point(286, 380);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(75, 40);
			btnEditar.TabIndex = 249;
			btnEditar.Text = "Editar";
			btnEditar.TextAlign = ContentAlignment.MiddleRight;
			btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			btnExcluir.BackColor = Color.Transparent;
			btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
			btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
			btnExcluir.Location = new Point(366, 380);
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Size = new Size(72, 40);
			btnExcluir.TabIndex = 248;
			btnExcluir.Text = "Excluir";
			btnExcluir.TextAlign = ContentAlignment.MiddleRight;
			btnExcluir.UseVisualStyleBackColor = false;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.Transparent;
			btnVoltar.Location = new Point(208, 380);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(72, 40);
			btnVoltar.TabIndex = 247;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			// 
			// frmEditarEstoqueEpi
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(479, 432);
			Controls.Add(btnEditar);
			Controls.Add(btnExcluir);
			Controls.Add(btnVoltar);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(cbxEpi);
			Controls.Add(txtEstoqueMinimo);
			Controls.Add(rtbLocalizacao);
			Controls.Add(txtQuantidade);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmEditarEstoqueEpi";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += frmEditarEstoqueEpi_Load;
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
		private Label label6;
		private Label label5;
		private Label label7;
		private Label label8;
		private ContextMenuStrip contextMenuStrip1;
		private ComboBox cbxEpi;
		private TextBox txtEstoqueMinimo;
		private RichTextBox rtbLocalizacao;
		private TextBox txtQuantidade;
		private Button btnEditar;
		private Button btnExcluir;
		private Button btnVoltar;
	}
}