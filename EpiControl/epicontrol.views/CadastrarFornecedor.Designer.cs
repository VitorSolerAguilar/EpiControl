namespace EpiControl.Views
{
	partial class frmCadastrarFornecedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFornecedor));
			btnVoltar = new Button();
			btnSalvar = new Button();
			label1 = new Label();
			txtNome = new TextBox();
			label2 = new Label();
			label3 = new Label();
			rtbObservacao = new RichTextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			txtEmailPessoal = new TextBox();
			label8 = new Label();
			txtEmailCorporativo = new TextBox();
			label9 = new Label();
			panel1 = new Panel();
			label17 = new Label();
			label18 = new Label();
			pictureBox1 = new PictureBox();
			lblBairro = new Label();
			txtLogradouro = new TextBox();
			btnConsultarCep = new Button();
			rtbComplemento = new RichTextBox();
			label32 = new Label();
			label31 = new Label();
			cbxTipo = new ComboBox();
			txtCidade = new TextBox();
			label27 = new Label();
			label26 = new Label();
			txtUf = new TextBox();
			label21 = new Label();
			label20 = new Label();
			txtRua = new TextBox();
			txtNumero = new TextBox();
			label10 = new Label();
			label11 = new Label();
			mtbCnpj = new MaskedTextBox();
			mtbTelefone = new MaskedTextBox();
			mtbCelular = new MaskedTextBox();
			mtbCep = new MaskedTextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.Transparent;
			btnVoltar.Location = new Point(398, 649);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(75, 40);
			btnVoltar.TabIndex = 33;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			btnVoltar.Click += btnVoltar_Click;
			// 
			// btnSalvar
			// 
			btnSalvar.BackColor = Color.FromArgb(17, 138, 254);
			btnSalvar.FlatAppearance.BorderSize = 0;
			btnSalvar.FlatStyle = FlatStyle.Flat;
			btnSalvar.ForeColor = Color.White;
			btnSalvar.Location = new Point(479, 649);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(75, 40);
			btnSalvar.TabIndex = 32;
			btnSalvar.Text = " Salvar";
			btnSalvar.UseVisualStyleBackColor = false;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(62, 111);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 34;
			label1.Text = "Nome*";
			// 
			// txtNome
			// 
			txtNome.Location = new Point(187, 104);
			txtNome.Name = "txtNome";
			txtNome.Size = new Size(231, 23);
			txtNome.TabIndex = 35;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(62, 140);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 36;
			label2.Text = "CNPJ*";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(62, 179);
			label3.Name = "label3";
			label3.Size = new Size(79, 15);
			label3.TabIndex = 38;
			label3.Text = "Observações*";
			// 
			// rtbObservacao
			// 
			rtbObservacao.Location = new Point(187, 162);
			rtbObservacao.Name = "rtbObservacao";
			rtbObservacao.Size = new Size(231, 58);
			rtbObservacao.TabIndex = 39;
			rtbObservacao.Text = "";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(235, 71);
			label4.Name = "label4";
			label4.Size = new Size(125, 21);
			label4.TabIndex = 40;
			label4.Text = "Dados Principais";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(262, 244);
			label5.Name = "label5";
			label5.Size = new Size(65, 21);
			label5.TabIndex = 41;
			label5.Text = "Contato";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(62, 278);
			label6.Name = "label6";
			label6.Size = new Size(56, 15);
			label6.TabIndex = 42;
			label6.Text = "Telefone*";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(62, 307);
			label7.Name = "label7";
			label7.Size = new Size(49, 15);
			label7.TabIndex = 44;
			label7.Text = "Celular*";
			// 
			// txtEmailPessoal
			// 
			txtEmailPessoal.Location = new Point(187, 333);
			txtEmailPessoal.Name = "txtEmailPessoal";
			txtEmailPessoal.Size = new Size(231, 23);
			txtEmailPessoal.TabIndex = 47;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(62, 336);
			label8.Name = "label8";
			label8.Size = new Size(78, 15);
			label8.TabIndex = 46;
			label8.Text = "Email Pessoal";
			// 
			// txtEmailCorporativo
			// 
			txtEmailCorporativo.Location = new Point(187, 362);
			txtEmailCorporativo.Name = "txtEmailCorporativo";
			txtEmailCorporativo.Size = new Size(231, 23);
			txtEmailCorporativo.TabIndex = 49;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(62, 365);
			label9.Name = "label9";
			label9.Size = new Size(102, 15);
			label9.TabIndex = 48;
			label9.Text = "Email Corporativo";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label17);
			panel1.Controls.Add(label18);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(588, 46);
			panel1.TabIndex = 63;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Font = new Font("Segoe UI", 20F);
			label17.ForeColor = Color.Black;
			label17.Location = new Point(57, 4);
			label17.Name = "label17";
			label17.Size = new Size(339, 37);
			label17.TabIndex = 3;
			label17.Text = "CADASTRAR FORNECEDOR";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Font = new Font("Segoe UI", 15F);
			label18.Location = new Point(57, 9);
			label18.Name = "label18";
			label18.Size = new Size(130, 28);
			label18.TabIndex = 2;
			label18.Text = "EPI CONTROL";
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
			// lblBairro
			// 
			lblBairro.AutoSize = true;
			lblBairro.Location = new Point(62, 527);
			lblBairro.Name = "lblBairro";
			lblBairro.Size = new Size(72, 15);
			lblBairro.TabIndex = 242;
			lblBairro.Text = "Logradouro:";
			// 
			// txtLogradouro
			// 
			txtLogradouro.Location = new Point(187, 519);
			txtLogradouro.Name = "txtLogradouro";
			txtLogradouro.Size = new Size(200, 23);
			txtLogradouro.TabIndex = 241;
			// 
			// btnConsultarCep
			// 
			btnConsultarCep.Location = new Point(367, 431);
			btnConsultarCep.Name = "btnConsultarCep";
			btnConsultarCep.Size = new Size(75, 23);
			btnConsultarCep.TabIndex = 240;
			btnConsultarCep.Text = "Consultar";
			btnConsultarCep.UseVisualStyleBackColor = true;
			btnConsultarCep.Click += btnConsultarCep_Click;
			// 
			// rtbComplemento
			// 
			rtbComplemento.Location = new Point(188, 548);
			rtbComplemento.Name = "rtbComplemento";
			rtbComplemento.Size = new Size(366, 80);
			rtbComplemento.TabIndex = 239;
			rtbComplemento.Text = "";
			// 
			// label32
			// 
			label32.AutoSize = true;
			label32.Location = new Point(62, 560);
			label32.Name = "label32";
			label32.Size = new Size(87, 15);
			label32.TabIndex = 238;
			label32.Text = "Complemento:";
			// 
			// label31
			// 
			label31.AutoSize = true;
			label31.Location = new Point(394, 522);
			label31.Name = "label31";
			label31.Size = new Size(33, 15);
			label31.TabIndex = 237;
			label31.Text = "Tipo:";
			// 
			// cbxTipo
			// 
			cbxTipo.FormattingEnabled = true;
			cbxTipo.Items.AddRange(new object[] { "Casa", "Apartamento", "Kitnet", "Studio", "Sobrado", "Condomínio", "Chácara", "Sítio" });
			cbxTipo.Location = new Point(433, 519);
			cbxTipo.Name = "cbxTipo";
			cbxTipo.Size = new Size(121, 23);
			cbxTipo.TabIndex = 236;
			// 
			// txtCidade
			// 
			txtCidade.Location = new Point(188, 461);
			txtCidade.Name = "txtCidade";
			txtCidade.Size = new Size(144, 23);
			txtCidade.TabIndex = 235;
			// 
			// label27
			// 
			label27.AutoSize = true;
			label27.Location = new Point(61, 469);
			label27.Name = "label27";
			label27.Size = new Size(47, 15);
			label27.TabIndex = 234;
			label27.Text = "Cidade:";
			// 
			// label26
			// 
			label26.AutoSize = true;
			label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label26.Location = new Point(262, 397);
			label26.Name = "label26";
			label26.Size = new Size(74, 21);
			label26.TabIndex = 233;
			label26.Text = "Endereço";
			// 
			// txtUf
			// 
			txtUf.Location = new Point(368, 461);
			txtUf.Name = "txtUf";
			txtUf.Size = new Size(74, 23);
			txtUf.TabIndex = 232;
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(338, 464);
			label21.Name = "label21";
			label21.Size = new Size(24, 15);
			label21.TabIndex = 231;
			label21.Text = "UF:";
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(61, 497);
			label20.Name = "label20";
			label20.Size = new Size(30, 15);
			label20.TabIndex = 230;
			label20.Text = "Rua:";
			// 
			// txtRua
			// 
			txtRua.Location = new Point(188, 490);
			txtRua.Name = "txtRua";
			txtRua.Size = new Size(283, 23);
			txtRua.TabIndex = 229;
			// 
			// txtNumero
			// 
			txtNumero.Location = new Point(507, 490);
			txtNumero.Name = "txtNumero";
			txtNumero.Size = new Size(47, 23);
			txtNumero.TabIndex = 228;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(477, 493);
			label10.Name = "label10";
			label10.Size = new Size(24, 15);
			label10.TabIndex = 227;
			label10.Text = "N°:";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(61, 440);
			label11.Name = "label11";
			label11.Size = new Size(31, 15);
			label11.TabIndex = 225;
			label11.Text = "CEP:";
			// 
			// mtbCnpj
			// 
			mtbCnpj.Location = new Point(187, 133);
			mtbCnpj.Mask = "00.000.000/0000-00";
			mtbCnpj.Name = "mtbCnpj";
			mtbCnpj.Size = new Size(192, 23);
			mtbCnpj.TabIndex = 243;
			// 
			// mtbTelefone
			// 
			mtbTelefone.Location = new Point(187, 275);
			mtbTelefone.Mask = "0000-0000";
			mtbTelefone.Name = "mtbTelefone";
			mtbTelefone.Size = new Size(140, 23);
			mtbTelefone.TabIndex = 244;
			// 
			// mtbCelular
			// 
			mtbCelular.Location = new Point(187, 304);
			mtbCelular.Mask = "(00) 00000-0000";
			mtbCelular.Name = "mtbCelular";
			mtbCelular.Size = new Size(140, 23);
			mtbCelular.TabIndex = 245;
			// 
			// mtbCep
			// 
			mtbCep.Location = new Point(188, 431);
			mtbCep.Mask = "00000-000";
			mtbCep.Name = "mtbCep";
			mtbCep.Size = new Size(144, 23);
			mtbCep.TabIndex = 246;
			// 
			// frmCadastrarFornecedor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(588, 701);
			Controls.Add(mtbCep);
			Controls.Add(mtbCelular);
			Controls.Add(mtbTelefone);
			Controls.Add(mtbCnpj);
			Controls.Add(lblBairro);
			Controls.Add(txtLogradouro);
			Controls.Add(btnConsultarCep);
			Controls.Add(rtbComplemento);
			Controls.Add(label32);
			Controls.Add(label31);
			Controls.Add(cbxTipo);
			Controls.Add(txtCidade);
			Controls.Add(label27);
			Controls.Add(label26);
			Controls.Add(txtUf);
			Controls.Add(label21);
			Controls.Add(label20);
			Controls.Add(txtRua);
			Controls.Add(txtNumero);
			Controls.Add(label10);
			Controls.Add(label11);
			Controls.Add(panel1);
			Controls.Add(txtEmailCorporativo);
			Controls.Add(label9);
			Controls.Add(txtEmailPessoal);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(rtbObservacao);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txtNome);
			Controls.Add(label1);
			Controls.Add(btnVoltar);
			Controls.Add(btnSalvar);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmCadastrarFornecedor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnVoltar;
		private Button btnSalvar;
		private Label label1;
		private TextBox txtNome;
		private Label label2;
		private Label label3;
		private RichTextBox rtbObservacao;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox txtEmailPessoal;
		private Label label8;
		private TextBox txtEmailCorporativo;
		private Label label9;
		private Panel panel1;
		private Label label17;
		private Label label18;
		private PictureBox pictureBox1;
		private Label lblBairro;
		private TextBox txtLogradouro;
		private Button btnConsultarCep;
		private RichTextBox rtbComplemento;
		private Label label32;
		private Label label31;
		private ComboBox cbxTipo;
		private TextBox txtCidade;
		private Label label27;
		private Label label26;
		private TextBox txtUf;
		private Label label21;
		private Label label20;
		private TextBox txtRua;
		private TextBox txtNumero;
		private Label label10;
		private Label label11;
		private MaskedTextBox mtbCnpj;
		private MaskedTextBox mtbTelefone;
		private MaskedTextBox mtbCelular;
		private MaskedTextBox mtbCep;
	}
}