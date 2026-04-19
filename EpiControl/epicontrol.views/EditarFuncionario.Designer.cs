namespace EpiControl.Views
{
    partial class frmEditarFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarFuncionario));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			rtbComplemento = new RichTextBox();
			label32 = new Label();
			label31 = new Label();
			cbxTipoEndereco = new ComboBox();
			label30 = new Label();
			label29 = new Label();
			label28 = new Label();
			txtCidade = new TextBox();
			label27 = new Label();
			label26 = new Label();
			label25 = new Label();
			label24 = new Label();
			txtPisPasep = new TextBox();
			label23 = new Label();
			txtUf = new TextBox();
			label21 = new Label();
			txtLogradouro = new TextBox();
			label20 = new Label();
			txtRua = new TextBox();
			label19 = new Label();
			txtNumero = new TextBox();
			label18 = new Label();
			label17 = new Label();
			txtEmailCorporativo = new TextBox();
			label16 = new Label();
			txtEmailPessoal = new TextBox();
			label15 = new Label();
			label14 = new Label();
			label13 = new Label();
			txtNomePai = new TextBox();
			label12 = new Label();
			txtNomeMae = new TextBox();
			label11 = new Label();
			txtNacionalidade = new TextBox();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			rdbInativo = new RadioButton();
			rdbAtivo = new RadioButton();
			label6 = new Label();
			txtCargo = new TextBox();
			label5 = new Label();
			txtMatricula = new TextBox();
			label4 = new Label();
			txtNome = new TextBox();
			label3 = new Label();
			mtbDataNascimento = new MaskedTextBox();
			cbxEstadoCivil = new ComboBox();
			mtbCpf = new MaskedTextBox();
			mtbRg = new MaskedTextBox();
			mtbCep = new MaskedTextBox();
			mtbTelefone = new MaskedTextBox();
			mtbCelular = new MaskedTextBox();
			btnConsultarCep = new Button();
			rdbMasculino = new RadioButton();
			rdbFeminino = new RadioButton();
			rdbOutros = new RadioButton();
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
			panel1.Size = new Size(619, 46);
			panel1.TabIndex = 52;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(333, 37);
			label2.TabIndex = 3;
			label2.Text = "EDIÇÃO DE FUNCIONÁRIO";
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
			// rtbComplemento
			// 
			rtbComplemento.Location = new Point(185, 732);
			rtbComplemento.Name = "rtbComplemento";
			rtbComplemento.Size = new Size(366, 80);
			rtbComplemento.TabIndex = 234;
			rtbComplemento.Text = "";
			// 
			// label32
			// 
			label32.AutoSize = true;
			label32.Location = new Point(59, 744);
			label32.Name = "label32";
			label32.Size = new Size(87, 15);
			label32.TabIndex = 233;
			label32.Text = "Complemento:";
			// 
			// label31
			// 
			label31.AutoSize = true;
			label31.Location = new Point(391, 706);
			label31.Name = "label31";
			label31.Size = new Size(33, 15);
			label31.TabIndex = 232;
			label31.Text = "Tipo:";
			// 
			// cbxTipoEndereco
			// 
			cbxTipoEndereco.FormattingEnabled = true;
			cbxTipoEndereco.Location = new Point(430, 703);
			cbxTipoEndereco.Name = "cbxTipoEndereco";
			cbxTipoEndereco.Size = new Size(121, 23);
			cbxTipoEndereco.TabIndex = 231;
			// 
			// label30
			// 
			label30.AutoSize = true;
			label30.Location = new Point(58, 371);
			label30.Name = "label30";
			label30.Size = new Size(29, 15);
			label30.TabIndex = 229;
			label30.Text = "Cpf:";
			// 
			// label29
			// 
			label29.AutoSize = true;
			label29.Location = new Point(59, 342);
			label29.Name = "label29";
			label29.Size = new Size(25, 15);
			label29.TabIndex = 227;
			label29.Text = "RG:";
			// 
			// label28
			// 
			label28.AutoSize = true;
			label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label28.Location = new Point(322, 826);
			label28.Name = "label28";
			label28.Size = new Size(54, 21);
			label28.TabIndex = 226;
			label28.Text = "Gerais";
			// 
			// txtCidade
			// 
			txtCidade.Location = new Point(185, 645);
			txtCidade.Name = "txtCidade";
			txtCidade.Size = new Size(144, 23);
			txtCidade.TabIndex = 225;
			// 
			// label27
			// 
			label27.AutoSize = true;
			label27.Location = new Point(58, 653);
			label27.Name = "label27";
			label27.Size = new Size(47, 15);
			label27.TabIndex = 224;
			label27.Text = "Cidade:";
			// 
			// label26
			// 
			label26.AutoSize = true;
			label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label26.Location = new Point(322, 582);
			label26.Name = "label26";
			label26.Size = new Size(74, 21);
			label26.TabIndex = 223;
			label26.Text = "Endereço";
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label25.Location = new Point(322, 411);
			label25.Name = "label25";
			label25.Size = new Size(65, 21);
			label25.TabIndex = 222;
			label25.Text = "Contato";
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label24.Location = new Point(306, 56);
			label24.Name = "label24";
			label24.Size = new Size(125, 21);
			label24.TabIndex = 221;
			label24.Text = "Dados Principais";
			// 
			// txtPisPasep
			// 
			txtPisPasep.Location = new Point(185, 305);
			txtPisPasep.Name = "txtPisPasep";
			txtPisPasep.Size = new Size(147, 23);
			txtPisPasep.TabIndex = 218;
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new Point(58, 313);
			label23.Name = "label23";
			label23.Size = new Size(64, 15);
			label23.TabIndex = 217;
			label23.Text = "PIS/PASEP:";
			// 
			// txtUf
			// 
			txtUf.Location = new Point(365, 645);
			txtUf.Name = "txtUf";
			txtUf.Size = new Size(74, 23);
			txtUf.TabIndex = 214;
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(335, 648);
			label21.Name = "label21";
			label21.Size = new Size(24, 15);
			label21.TabIndex = 213;
			label21.Text = "UF:";
			// 
			// txtLogradouro
			// 
			txtLogradouro.Location = new Point(185, 703);
			txtLogradouro.Name = "txtLogradouro";
			txtLogradouro.Size = new Size(200, 23);
			txtLogradouro.TabIndex = 212;
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(58, 681);
			label20.Name = "label20";
			label20.Size = new Size(30, 15);
			label20.TabIndex = 211;
			label20.Text = "Rua:";
			// 
			// txtRua
			// 
			txtRua.Location = new Point(185, 674);
			txtRua.Name = "txtRua";
			txtRua.Size = new Size(283, 23);
			txtRua.TabIndex = 210;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(58, 711);
			label19.Name = "label19";
			label19.Size = new Size(72, 15);
			label19.TabIndex = 209;
			label19.Text = "Logradouro:";
			// 
			// txtNumero
			// 
			txtNumero.Location = new Point(504, 674);
			txtNumero.Name = "txtNumero";
			txtNumero.Size = new Size(74, 23);
			txtNumero.TabIndex = 208;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(474, 677);
			label18.Name = "label18";
			label18.Size = new Size(24, 15);
			label18.TabIndex = 207;
			label18.Text = "N°:";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(58, 624);
			label17.Name = "label17";
			label17.Size = new Size(31, 15);
			label17.TabIndex = 205;
			label17.Text = "CEP:";
			// 
			// txtEmailCorporativo
			// 
			txtEmailCorporativo.Location = new Point(188, 542);
			txtEmailCorporativo.Name = "txtEmailCorporativo";
			txtEmailCorporativo.Size = new Size(223, 23);
			txtEmailCorporativo.TabIndex = 204;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(61, 542);
			label16.Name = "label16";
			label16.Size = new Size(103, 15);
			label16.TabIndex = 203;
			label16.Text = "Email corporativo:";
			// 
			// txtEmailPessoal
			// 
			txtEmailPessoal.Location = new Point(188, 506);
			txtEmailPessoal.Name = "txtEmailPessoal";
			txtEmailPessoal.Size = new Size(223, 23);
			txtEmailPessoal.TabIndex = 202;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(61, 514);
			label15.Name = "label15";
			label15.Size = new Size(81, 15);
			label15.TabIndex = 201;
			label15.Text = "Email pessoal:";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(61, 485);
			label14.Name = "label14";
			label14.Size = new Size(47, 15);
			label14.TabIndex = 199;
			label14.Text = "Celular:";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(61, 456);
			label13.Name = "label13";
			label13.Size = new Size(54, 15);
			label13.TabIndex = 197;
			label13.Text = "Telefone:";
			// 
			// txtNomePai
			// 
			txtNomePai.Location = new Point(185, 276);
			txtNomePai.Name = "txtNomePai";
			txtNomePai.Size = new Size(283, 23);
			txtNomePai.TabIndex = 196;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(58, 284);
			label12.Name = "label12";
			label12.Size = new Size(79, 15);
			label12.TabIndex = 195;
			label12.Text = "Nome do pai:";
			// 
			// txtNomeMae
			// 
			txtNomeMae.Location = new Point(185, 247);
			txtNomeMae.Name = "txtNomeMae";
			txtNomeMae.Size = new Size(283, 23);
			txtNomeMae.TabIndex = 194;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(58, 250);
			label11.Name = "label11";
			label11.Size = new Size(85, 15);
			label11.TabIndex = 193;
			label11.Text = "Nome da mãe:";
			// 
			// txtNacionalidade
			// 
			txtNacionalidade.Location = new Point(185, 179);
			txtNacionalidade.Name = "txtNacionalidade";
			txtNacionalidade.Size = new Size(137, 23);
			txtNacionalidade.TabIndex = 192;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(58, 187);
			label10.Name = "label10";
			label10.Size = new Size(86, 15);
			label10.TabIndex = 191;
			label10.Text = "Nacionalidade:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(58, 158);
			label9.Name = "label9";
			label9.Size = new Size(71, 15);
			label9.TabIndex = 189;
			label9.Text = "Estado Civil:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(58, 217);
			label8.Name = "label8";
			label8.Size = new Size(48, 15);
			label8.TabIndex = 185;
			label8.Text = "Gênero:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(58, 129);
			label7.Name = "label7";
			label7.Size = new Size(117, 15);
			label7.TabIndex = 183;
			label7.Text = "Data de Nascimento:";
			// 
			// rdbInativo
			// 
			rdbInativo.AutoSize = true;
			rdbInativo.Location = new Point(247, 914);
			rdbInativo.Name = "rdbInativo";
			rdbInativo.Size = new Size(61, 19);
			rdbInativo.TabIndex = 182;
			rdbInativo.TabStop = true;
			rdbInativo.Text = "Inativo";
			rdbInativo.UseVisualStyleBackColor = true;
			// 
			// rdbAtivo
			// 
			rdbAtivo.AutoSize = true;
			rdbAtivo.Location = new Point(188, 914);
			rdbAtivo.Name = "rdbAtivo";
			rdbAtivo.Size = new Size(53, 19);
			rdbAtivo.TabIndex = 181;
			rdbAtivo.TabStop = true;
			rdbAtivo.Text = "Ativo";
			rdbAtivo.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(61, 916);
			label6.Name = "label6";
			label6.Size = new Size(42, 15);
			label6.TabIndex = 180;
			label6.Text = "Status:";
			// 
			// txtCargo
			// 
			txtCargo.Location = new Point(188, 883);
			txtCargo.Name = "txtCargo";
			txtCargo.Size = new Size(174, 23);
			txtCargo.TabIndex = 179;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(60, 891);
			label5.Name = "label5";
			label5.Size = new Size(42, 15);
			label5.TabIndex = 178;
			label5.Text = "Cargo:";
			// 
			// txtMatricula
			// 
			txtMatricula.Location = new Point(189, 854);
			txtMatricula.Name = "txtMatricula";
			txtMatricula.Size = new Size(173, 23);
			txtMatricula.TabIndex = 177;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(61, 862);
			label4.Name = "label4";
			label4.Size = new Size(60, 15);
			label4.TabIndex = 176;
			label4.Text = "Matrícula:";
			// 
			// txtNome
			// 
			txtNome.Location = new Point(186, 92);
			txtNome.Name = "txtNome";
			txtNome.Size = new Size(325, 23);
			txtNome.TabIndex = 175;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(58, 95);
			label3.Name = "label3";
			label3.Size = new Size(43, 15);
			label3.TabIndex = 174;
			label3.Text = "Nome:";
			// 
			// mtbDataNascimento
			// 
			mtbDataNascimento.Location = new Point(186, 121);
			mtbDataNascimento.Mask = "00/00/0000";
			mtbDataNascimento.Name = "mtbDataNascimento";
			mtbDataNascimento.Size = new Size(147, 23);
			mtbDataNascimento.TabIndex = 237;
			mtbDataNascimento.ValidatingType = typeof(DateTime);
			// 
			// cbxEstadoCivil
			// 
			cbxEstadoCivil.FormattingEnabled = true;
			cbxEstadoCivil.Items.AddRange(new object[] { "Solteiro(a)", "Casado(a)", "Divorciado(a)", "Viúvo(a)", "Separado(a)", "União estável" });
			cbxEstadoCivil.Location = new Point(186, 150);
			cbxEstadoCivil.Name = "cbxEstadoCivil";
			cbxEstadoCivil.Size = new Size(137, 23);
			cbxEstadoCivil.TabIndex = 238;
			// 
			// mtbCpf
			// 
			mtbCpf.Location = new Point(184, 363);
			mtbCpf.Mask = "000.000.000-00";
			mtbCpf.Name = "mtbCpf";
			mtbCpf.Size = new Size(147, 23);
			mtbCpf.TabIndex = 240;
			mtbCpf.ValidatingType = typeof(DateTime);
			// 
			// mtbRg
			// 
			mtbRg.Location = new Point(184, 334);
			mtbRg.Mask = "00.000.000-0";
			mtbRg.Name = "mtbRg";
			mtbRg.Size = new Size(147, 23);
			mtbRg.TabIndex = 239;
			mtbRg.ValidatingType = typeof(DateTime);
			// 
			// mtbCep
			// 
			mtbCep.Location = new Point(186, 616);
			mtbCep.Mask = "00000-000";
			mtbCep.Name = "mtbCep";
			mtbCep.Size = new Size(147, 23);
			mtbCep.TabIndex = 241;
			mtbCep.ValidatingType = typeof(DateTime);
			// 
			// mtbTelefone
			// 
			mtbTelefone.Location = new Point(189, 448);
			mtbTelefone.Mask = "000-0000";
			mtbTelefone.Name = "mtbTelefone";
			mtbTelefone.Size = new Size(147, 23);
			mtbTelefone.TabIndex = 243;
			// 
			// mtbCelular
			// 
			mtbCelular.Location = new Point(189, 477);
			mtbCelular.Mask = "(99) 00000-0000";
			mtbCelular.Name = "mtbCelular";
			mtbCelular.Size = new Size(147, 23);
			mtbCelular.TabIndex = 242;
			// 
			// btnConsultarCep
			// 
			btnConsultarCep.Location = new Point(364, 615);
			btnConsultarCep.Name = "btnConsultarCep";
			btnConsultarCep.Size = new Size(75, 23);
			btnConsultarCep.TabIndex = 244;
			btnConsultarCep.Text = "Consultar";
			btnConsultarCep.UseVisualStyleBackColor = true;
			btnConsultarCep.Click += btnConsultarCep_Click;
			// 
			// rdbMasculino
			// 
			rdbMasculino.AutoSize = true;
			rdbMasculino.Location = new Point(185, 215);
			rdbMasculino.Name = "rdbMasculino";
			rdbMasculino.Size = new Size(80, 19);
			rdbMasculino.TabIndex = 245;
			rdbMasculino.TabStop = true;
			rdbMasculino.Text = "Masculino";
			rdbMasculino.UseVisualStyleBackColor = true;
			// 
			// rdbFeminino
			// 
			rdbFeminino.AutoSize = true;
			rdbFeminino.Location = new Point(285, 215);
			rdbFeminino.Name = "rdbFeminino";
			rdbFeminino.Size = new Size(75, 19);
			rdbFeminino.TabIndex = 246;
			rdbFeminino.TabStop = true;
			rdbFeminino.Text = "Feminino";
			rdbFeminino.UseVisualStyleBackColor = true;
			// 
			// rdbOutros
			// 
			rdbOutros.AutoSize = true;
			rdbOutros.Location = new Point(370, 215);
			rdbOutros.Name = "rdbOutros";
			rdbOutros.Size = new Size(61, 19);
			rdbOutros.TabIndex = 247;
			rdbOutros.TabStop = true;
			rdbOutros.Text = "Outros";
			rdbOutros.UseVisualStyleBackColor = true;
			// 
			// btnEditar
			// 
			btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
			btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
			btnEditar.Location = new Point(426, 937);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(75, 40);
			btnEditar.TabIndex = 250;
			btnEditar.Text = "Editar";
			btnEditar.TextAlign = ContentAlignment.MiddleRight;
			btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			btnExcluir.BackColor = Color.Transparent;
			btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
			btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
			btnExcluir.Location = new Point(506, 937);
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Size = new Size(72, 40);
			btnExcluir.TabIndex = 249;
			btnExcluir.Text = "Excluir";
			btnExcluir.TextAlign = ContentAlignment.MiddleRight;
			btnExcluir.UseVisualStyleBackColor = false;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.Transparent;
			btnVoltar.Location = new Point(348, 937);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(72, 40);
			btnVoltar.TabIndex = 248;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			// 
			// frmEditarFuncionario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(619, 989);
			Controls.Add(btnEditar);
			Controls.Add(btnExcluir);
			Controls.Add(btnVoltar);
			Controls.Add(rdbOutros);
			Controls.Add(rdbFeminino);
			Controls.Add(rdbMasculino);
			Controls.Add(btnConsultarCep);
			Controls.Add(mtbTelefone);
			Controls.Add(mtbCelular);
			Controls.Add(mtbCep);
			Controls.Add(mtbCpf);
			Controls.Add(mtbRg);
			Controls.Add(cbxEstadoCivil);
			Controls.Add(mtbDataNascimento);
			Controls.Add(rtbComplemento);
			Controls.Add(label32);
			Controls.Add(label31);
			Controls.Add(cbxTipoEndereco);
			Controls.Add(label30);
			Controls.Add(label29);
			Controls.Add(label28);
			Controls.Add(txtCidade);
			Controls.Add(label27);
			Controls.Add(label26);
			Controls.Add(label25);
			Controls.Add(label24);
			Controls.Add(txtPisPasep);
			Controls.Add(label23);
			Controls.Add(txtUf);
			Controls.Add(label21);
			Controls.Add(txtLogradouro);
			Controls.Add(label20);
			Controls.Add(txtRua);
			Controls.Add(label19);
			Controls.Add(txtNumero);
			Controls.Add(label18);
			Controls.Add(label17);
			Controls.Add(txtEmailCorporativo);
			Controls.Add(label16);
			Controls.Add(txtEmailPessoal);
			Controls.Add(label15);
			Controls.Add(label14);
			Controls.Add(label13);
			Controls.Add(txtNomePai);
			Controls.Add(label12);
			Controls.Add(txtNomeMae);
			Controls.Add(label11);
			Controls.Add(txtNacionalidade);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(rdbInativo);
			Controls.Add(rdbAtivo);
			Controls.Add(label6);
			Controls.Add(txtCargo);
			Controls.Add(label5);
			Controls.Add(txtMatricula);
			Controls.Add(label4);
			Controls.Add(txtNome);
			Controls.Add(label3);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "frmEditarFuncionario";
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
		private RichTextBox rtbComplemento;
		private Label label32;
		private Label label31;
		private ComboBox cbxTipoEndereco;
		private Label label30;
		private Label label29;
		private Label label28;
		private TextBox txtCidade;
		private Label label27;
		private Label label26;
		private Label label25;
		private Label label24;
		private TextBox txtPisPasep;
		private Label label23;
		private TextBox txtUf;
		private Label label21;
		private TextBox txtLogradouro;
		private Label label20;
		private TextBox txtRua;
		private Label label19;
		private TextBox txtNumero;
		private Label label18;
		private Label label17;
		private TextBox txtEmailCorporativo;
		private Label label16;
		private TextBox txtEmailPessoal;
		private Label label15;
		private Label label14;
		private Label label13;
		private TextBox txtNomePai;
		private Label label12;
		private TextBox txtNomeMae;
		private Label label11;
		private TextBox txtNacionalidade;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private RadioButton rdbInativo;
		private RadioButton rdbAtivo;
		private Label label6;
		private TextBox txtCargo;
		private Label label5;
		private TextBox txtMatricula;
		private Label label4;
		private TextBox txtNome;
		private Label label3;
		private MaskedTextBox mtbDataNascimento;
		private ComboBox cbxEstadoCivil;
		private MaskedTextBox mtbCpf;
		private MaskedTextBox mtbRg;
		private MaskedTextBox mtbCep;
		private MaskedTextBox mtbTelefone;
		private MaskedTextBox mtbCelular;
		private Button btnConsultarCep;
		private RadioButton rdbMasculino;
		private RadioButton rdbFeminino;
		private RadioButton rdbOutros;
		private Button btnEditar;
		private Button btnExcluir;
		private Button btnVoltar;
	}
}