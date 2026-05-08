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
            txtUf = new TextBox();
            mtbTelefone = new MaskedTextBox();
            mtbCep = new MaskedTextBox();
            mtbCelular = new MaskedTextBox();
            mtbDataNascimento = new MaskedTextBox();
            mtbCpf = new MaskedTextBox();
            mtbRg = new MaskedTextBox();
            cbxEstadoCivil = new ComboBox();
            lblBairro = new Label();
            txtLogradouro = new TextBox();
            btnConsultarCep = new Button();
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
            label21 = new Label();
            label20 = new Label();
            txtRua = new TextBox();
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
            label6 = new Label();
            txtCargo = new TextBox();
            label5 = new Label();
            txtMatricula = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            groupBox1 = new GroupBox();
            rdbOutro = new RadioButton();
            rdbMasculino = new RadioButton();
            rdbFeminino = new RadioButton();
            groupBox2 = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Size = new Size(1054, 46);
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
            // txtUf
            // 
            txtUf.Location = new Point(360, 522);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(74, 23);
            txtUf.TabIndex = 290;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(781, 98);
            mtbTelefone.Mask = "000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(147, 23);
            mtbTelefone.TabIndex = 289;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(178, 494);
            mtbCep.Mask = "00000-000";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(147, 23);
            mtbCep.TabIndex = 288;
            mtbCep.ValidatingType = typeof(DateTime);
            // 
            // mtbCelular
            // 
            mtbCelular.Location = new Point(781, 129);
            mtbCelular.Mask = "(99) 00000-0000";
            mtbCelular.Name = "mtbCelular";
            mtbCelular.Size = new Size(147, 23);
            mtbCelular.TabIndex = 287;
            // 
            // mtbDataNascimento
            // 
            mtbDataNascimento.Location = new Point(178, 124);
            mtbDataNascimento.Mask = "00/00/0000";
            mtbDataNascimento.Name = "mtbDataNascimento";
            mtbDataNascimento.Size = new Size(147, 23);
            mtbDataNascimento.TabIndex = 286;
            mtbDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(178, 370);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.ReadOnly = true;
            mtbCpf.Size = new Size(147, 23);
            mtbCpf.TabIndex = 285;
            mtbCpf.ValidatingType = typeof(DateTime);
            // 
            // mtbRg
            // 
            mtbRg.Location = new Point(178, 341);
            mtbRg.Mask = "00.000.000-0";
            mtbRg.Name = "mtbRg";
            mtbRg.Size = new Size(147, 23);
            mtbRg.TabIndex = 284;
            mtbRg.ValidatingType = typeof(DateTime);
            // 
            // cbxEstadoCivil
            // 
            cbxEstadoCivil.FormattingEnabled = true;
            cbxEstadoCivil.Items.AddRange(new object[] { "Solteiro(a)", "Casado(a)", "Divorciado(a)", "Viúvo(a)", "Separado(a)", "União estável" });
            cbxEstadoCivil.Location = new Point(178, 153);
            cbxEstadoCivil.Name = "cbxEstadoCivil";
            cbxEstadoCivil.Size = new Size(137, 23);
            cbxEstadoCivil.TabIndex = 283;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(55, 589);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(69, 15);
            lblBairro.TabIndex = 282;
            lblBairro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(178, 581);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(200, 23);
            txtLogradouro.TabIndex = 281;
            // 
            // btnConsultarCep
            // 
            btnConsultarCep.Location = new Point(360, 493);
            btnConsultarCep.Name = "btnConsultarCep";
            btnConsultarCep.Size = new Size(75, 23);
            btnConsultarCep.TabIndex = 280;
            btnConsultarCep.Text = "Consultar";
            btnConsultarCep.UseVisualStyleBackColor = true;
            // 
            // rtbComplemento
            // 
            rtbComplemento.Location = new Point(178, 610);
            rtbComplemento.Name = "rtbComplemento";
            rtbComplemento.Size = new Size(366, 80);
            rtbComplemento.TabIndex = 279;
            rtbComplemento.Text = "";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(55, 622);
            label32.Name = "label32";
            label32.Size = new Size(84, 15);
            label32.TabIndex = 278;
            label32.Text = "Complemento";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(387, 584);
            label31.Name = "label31";
            label31.Size = new Size(30, 15);
            label31.TabIndex = 277;
            label31.Text = "Tipo";
            // 
            // cbxTipoEndereco
            // 
            cbxTipoEndereco.FormattingEnabled = true;
            cbxTipoEndereco.Items.AddRange(new object[] { "Casa", "Apartamento", "Kitnet", "Studio", "Sobrado", "Condomínio", "Chácara", "Sítio" });
            cbxTipoEndereco.Location = new Point(426, 581);
            cbxTipoEndereco.Name = "cbxTipoEndereco";
            cbxTipoEndereco.Size = new Size(121, 23);
            cbxTipoEndereco.TabIndex = 276;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(51, 378);
            label30.Name = "label30";
            label30.Size = new Size(36, 15);
            label30.TabIndex = 275;
            label30.Text = "CPF *";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(52, 349);
            label29.Name = "label29";
            label29.Size = new Size(22, 15);
            label29.TabIndex = 274;
            label29.Text = "RG";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(829, 459);
            label28.Name = "label28";
            label28.Size = new Size(54, 21);
            label28.TabIndex = 273;
            label28.Text = "Gerais";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(178, 522);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(144, 23);
            txtCidade.TabIndex = 272;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(54, 531);
            label27.Name = "label27";
            label27.Size = new Size(44, 15);
            label27.TabIndex = 271;
            label27.Text = "Cidade";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(315, 459);
            label26.Name = "label26";
            label26.Size = new Size(74, 21);
            label26.TabIndex = 270;
            label26.Text = "Endereço";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(818, 60);
            label25.Name = "label25";
            label25.Size = new Size(65, 21);
            label25.TabIndex = 269;
            label25.Text = "Contato";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(279, 60);
            label24.Name = "label24";
            label24.Size = new Size(125, 21);
            label24.TabIndex = 268;
            label24.Text = "Dados Principais";
            // 
            // txtPisPasep
            // 
            txtPisPasep.Location = new Point(178, 312);
            txtPisPasep.MaxLength = 11;
            txtPisPasep.Name = "txtPisPasep";
            txtPisPasep.Size = new Size(147, 23);
            txtPisPasep.TabIndex = 267;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(51, 320);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 266;
            label23.Text = "PIS/PASEP";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(331, 526);
            label21.Name = "label21";
            label21.Size = new Size(21, 15);
            label21.TabIndex = 265;
            label21.Text = "UF";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(54, 559);
            label20.Name = "label20";
            label20.Size = new Size(27, 15);
            label20.TabIndex = 264;
            label20.Text = "Rua";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(178, 552);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(283, 23);
            txtRua.TabIndex = 263;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(500, 552);
            txtNumero.MaxLength = 10;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(55, 23);
            txtNumero.TabIndex = 262;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(470, 555);
            label18.Name = "label18";
            label18.Size = new Size(21, 15);
            label18.TabIndex = 261;
            label18.Text = "N°";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(54, 502);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 260;
            label17.Text = "CEP *";
            // 
            // txtEmailCorporativo
            // 
            txtEmailCorporativo.Location = new Point(781, 193);
            txtEmailCorporativo.Name = "txtEmailCorporativo";
            txtEmailCorporativo.Size = new Size(223, 23);
            txtEmailCorporativo.TabIndex = 259;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(654, 201);
            label16.Name = "label16";
            label16.Size = new Size(103, 15);
            label16.TabIndex = 258;
            label16.Text = "Email corporativo:";
            // 
            // txtEmailPessoal
            // 
            txtEmailPessoal.Location = new Point(781, 161);
            txtEmailPessoal.MaxLength = 255;
            txtEmailPessoal.Name = "txtEmailPessoal";
            txtEmailPessoal.Size = new Size(223, 23);
            txtEmailPessoal.TabIndex = 257;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(654, 169);
            label15.Name = "label15";
            label15.Size = new Size(81, 15);
            label15.TabIndex = 256;
            label15.Text = "Email pessoal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(653, 137);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 255;
            label14.Text = "Celular:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(653, 106);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 254;
            label13.Text = "Telefone:";
            // 
            // txtNomePai
            // 
            txtNomePai.Location = new Point(179, 279);
            txtNomePai.MaxLength = 255;
            txtNomePai.Name = "txtNomePai";
            txtNomePai.Size = new Size(283, 23);
            txtNomePai.TabIndex = 253;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 287);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 252;
            label12.Text = "Nome do pai";
            // 
            // txtNomeMae
            // 
            txtNomeMae.Location = new Point(179, 250);
            txtNomeMae.MaxLength = 255;
            txtNomeMae.Name = "txtNomeMae";
            txtNomeMae.Size = new Size(283, 23);
            txtNomeMae.TabIndex = 251;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 253);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 250;
            label11.Text = "Nome da mãe *";
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(178, 182);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(137, 23);
            txtNacionalidade.TabIndex = 249;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 190);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 248;
            label10.Text = "Nacionalidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 161);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 247;
            label9.Text = "Estado Civil";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 220);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 243;
            label8.Text = "Gênero";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 132);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 242;
            label7.Text = "Data de Nascimento *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(654, 584);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 239;
            label6.Text = "Status *";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(781, 540);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(174, 23);
            txtCargo.TabIndex = 238;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 548);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 237;
            label5.Text = "Cargo *";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(781, 511);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(173, 23);
            txtMatricula.TabIndex = 236;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(653, 519);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 235;
            label4.Text = "Matrícula *";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(178, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(325, 23);
            txtNome.TabIndex = 234;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 98);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 233;
            label3.Text = "Nome *";
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(890, 650);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 293;
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
            btnExcluir.Location = new Point(970, 650);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(72, 40);
            btnExcluir.TabIndex = 292;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(812, 650);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 291;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbOutro);
            groupBox1.Controls.Add(rdbMasculino);
            groupBox1.Controls.Add(rdbFeminino);
            groupBox1.Location = new Point(178, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 34);
            groupBox1.TabIndex = 294;
            groupBox1.TabStop = false;
            // 
            // rdbOutro
            // 
            rdbOutro.AutoSize = true;
            rdbOutro.Location = new Point(170, 11);
            rdbOutro.Name = "rdbOutro";
            rdbOutro.Size = new Size(56, 19);
            rdbOutro.TabIndex = 127;
            rdbOutro.TabStop = true;
            rdbOutro.Text = "Outro";
            rdbOutro.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(3, 11);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 125;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(89, 11);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 126;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbInativo);
            groupBox2.Controls.Add(rdbAtivo);
            groupBox2.Location = new Point(781, 564);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(118, 41);
            groupBox2.TabIndex = 295;
            groupBox2.TabStop = false;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(59, 16);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 121;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(0, 16);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 120;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // frmEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 704);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(txtUf);
            Controls.Add(mtbTelefone);
            Controls.Add(mtbCep);
            Controls.Add(mtbCelular);
            Controls.Add(mtbDataNascimento);
            Controls.Add(mtbCpf);
            Controls.Add(mtbRg);
            Controls.Add(cbxEstadoCivil);
            Controls.Add(lblBairro);
            Controls.Add(txtLogradouro);
            Controls.Add(btnConsultarCep);
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
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(txtRua);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUf;
        private MaskedTextBox mtbTelefone;
        private MaskedTextBox mtbCep;
        private MaskedTextBox mtbCelular;
        private MaskedTextBox mtbDataNascimento;
        private MaskedTextBox mtbCpf;
        private MaskedTextBox mtbRg;
        private ComboBox cbxEstadoCivil;
        private Label lblBairro;
        private TextBox txtLogradouro;
        private Button btnConsultarCep;
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
        private Label label21;
        private Label label20;
        private TextBox txtRua;
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
        private Label label6;
        private TextBox txtCargo;
        private Label label5;
        private TextBox txtMatricula;
        private Label label4;
        private TextBox txtNome;
        private Label label3;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnVoltar;
        private GroupBox groupBox1;
        private RadioButton rdbOutro;
        private RadioButton rdbMasculino;
        private RadioButton rdbFeminino;
        private GroupBox groupBox2;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
    }
}