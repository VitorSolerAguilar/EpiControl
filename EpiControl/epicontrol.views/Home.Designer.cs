namespace EpiControl
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			flpContainer = new FlowLayoutPanel();
			btnFuncionario = new Button();
			btnCadastrarFrm = new Button();
			btnConsultarFrm = new Button();
			flpContainerFornecedor = new FlowLayoutPanel();
			btnCadastroFornecedor = new Button();
			btnCadastrarFornecedor = new Button();
			btnConsultarFornecedor = new Button();
			flpContainerEpi = new FlowLayoutPanel();
			btnEpi = new Button();
			btnCadastrarEpi = new Button();
			btnConsultarEpi = new Button();
			flpNormaRegulamentadora = new FlowLayoutPanel();
			btnNormasRegulamentadoras = new Button();
			btnCadastrarNormaRegulamentadora = new Button();
			btnConsultarNormaRegulamentadora = new Button();
			button3 = new Button();
			button5 = new Button();
			button6 = new Button();
			pictureBox2 = new PictureBox();
			btnSair = new Button();
			trasicaoMenuFuncionario = new System.Windows.Forms.Timer(components);
			transicaoMenuFornecedor = new System.Windows.Forms.Timer(components);
			transicaoMenuEpi = new System.Windows.Forms.Timer(components);
			transicaoMenuNorma = new System.Windows.Forms.Timer(components);
			flowLayoutPanel2 = new FlowLayoutPanel();
			button2 = new Button();
			button4 = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			flpContainer.SuspendLayout();
			flpContainerFornecedor.SuspendLayout();
			flpContainerEpi.SuspendLayout();
			flpNormaRegulamentadora.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
			panel1.Size = new Size(1283, 46);
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(179, 37);
			label2.TabIndex = 3;
			label2.Text = "EPI CONTROL";
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
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = Color.FromArgb(0, 45, 71);
			flowLayoutPanel1.Controls.Add(flpContainer);
			flowLayoutPanel1.Controls.Add(flpContainerFornecedor);
			flowLayoutPanel1.Controls.Add(flpContainerEpi);
			flowLayoutPanel1.Controls.Add(flpNormaRegulamentadora);
			flowLayoutPanel1.Controls.Add(btnSair);
			flowLayoutPanel1.Dock = DockStyle.Left;
			flowLayoutPanel1.Location = new Point(0, 46);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(220, 598);
			flowLayoutPanel1.TabIndex = 3;
			// 
			// flpContainer
			// 
			flpContainer.BackColor = Color.FromArgb(0, 45, 71);
			flpContainer.BackgroundImageLayout = ImageLayout.None;
			flpContainer.Controls.Add(btnFuncionario);
			flpContainer.Controls.Add(btnCadastrarFrm);
			flpContainer.Controls.Add(btnConsultarFrm);
			flpContainer.Location = new Point(0, 0);
			flpContainer.Margin = new Padding(0);
			flpContainer.Name = "flpContainer";
			flpContainer.Size = new Size(265, 51);
			flpContainer.TabIndex = 5;
			// 
			// btnFuncionario
			// 
			btnFuncionario.BackColor = Color.FromArgb(74, 146, 247);
			btnFuncionario.FlatAppearance.BorderSize = 0;
			btnFuncionario.FlatStyle = FlatStyle.Flat;
			btnFuncionario.Image = (Image)resources.GetObject("btnFuncionario.Image");
			btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
			btnFuncionario.Location = new Point(0, 0);
			btnFuncionario.Margin = new Padding(0);
			btnFuncionario.Name = "btnFuncionario";
			btnFuncionario.Size = new Size(220, 51);
			btnFuncionario.TabIndex = 2;
			btnFuncionario.Text = "Funcionario";
			btnFuncionario.UseVisualStyleBackColor = false;
			btnFuncionario.Click += btnFuncionario_Click;
			// 
			// btnCadastrarFrm
			// 
			btnCadastrarFrm.BackColor = Color.FromArgb(0, 45, 71);
			btnCadastrarFrm.FlatAppearance.BorderSize = 0;
			btnCadastrarFrm.FlatStyle = FlatStyle.Flat;
			btnCadastrarFrm.Image = (Image)resources.GetObject("btnCadastrarFrm.Image");
			btnCadastrarFrm.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastrarFrm.Location = new Point(0, 51);
			btnCadastrarFrm.Margin = new Padding(0);
			btnCadastrarFrm.Name = "btnCadastrarFrm";
			btnCadastrarFrm.Size = new Size(220, 51);
			btnCadastrarFrm.TabIndex = 4;
			btnCadastrarFrm.Text = "Cadastrar";
			btnCadastrarFrm.UseVisualStyleBackColor = false;
			btnCadastrarFrm.Click += btnCadastrarFrm_Click;
			// 
			// btnConsultarFrm
			// 
			btnConsultarFrm.BackColor = Color.FromArgb(0, 45, 71);
			btnConsultarFrm.FlatAppearance.BorderSize = 0;
			btnConsultarFrm.FlatStyle = FlatStyle.Flat;
			btnConsultarFrm.Image = (Image)resources.GetObject("btnConsultarFrm.Image");
			btnConsultarFrm.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultarFrm.Location = new Point(0, 102);
			btnConsultarFrm.Margin = new Padding(0);
			btnConsultarFrm.Name = "btnConsultarFrm";
			btnConsultarFrm.Size = new Size(220, 51);
			btnConsultarFrm.TabIndex = 5;
			btnConsultarFrm.Text = "Consultar";
			btnConsultarFrm.UseVisualStyleBackColor = false;
			btnConsultarFrm.Click += btnConsultarFrm_Click;
			// 
			// flpContainerFornecedor
			// 
			flpContainerFornecedor.BackColor = Color.FromArgb(0, 45, 71);
			flpContainerFornecedor.Controls.Add(btnCadastroFornecedor);
			flpContainerFornecedor.Controls.Add(btnCadastrarFornecedor);
			flpContainerFornecedor.Controls.Add(btnConsultarFornecedor);
			flpContainerFornecedor.Location = new Point(0, 53);
			flpContainerFornecedor.Margin = new Padding(0, 2, 0, 0);
			flpContainerFornecedor.Name = "flpContainerFornecedor";
			flpContainerFornecedor.Size = new Size(264, 54);
			flpContainerFornecedor.TabIndex = 5;
			// 
			// btnCadastroFornecedor
			// 
			btnCadastroFornecedor.BackColor = Color.FromArgb(74, 146, 247);
			btnCadastroFornecedor.FlatAppearance.BorderSize = 0;
			btnCadastroFornecedor.FlatStyle = FlatStyle.Flat;
			btnCadastroFornecedor.Image = (Image)resources.GetObject("btnCadastroFornecedor.Image");
			btnCadastroFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastroFornecedor.Location = new Point(0, 0);
			btnCadastroFornecedor.Margin = new Padding(0);
			btnCadastroFornecedor.Name = "btnCadastroFornecedor";
			btnCadastroFornecedor.Size = new Size(220, 54);
			btnCadastroFornecedor.TabIndex = 2;
			btnCadastroFornecedor.Text = "Cadastro Fonecedor";
			btnCadastroFornecedor.UseVisualStyleBackColor = false;
			btnCadastroFornecedor.Click += btnCadastroFornecedor_Click;
			// 
			// btnCadastrarFornecedor
			// 
			btnCadastrarFornecedor.BackColor = Color.FromArgb(0, 45, 71);
			btnCadastrarFornecedor.FlatAppearance.BorderSize = 0;
			btnCadastrarFornecedor.FlatStyle = FlatStyle.Flat;
			btnCadastrarFornecedor.Image = (Image)resources.GetObject("btnCadastrarFornecedor.Image");
			btnCadastrarFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastrarFornecedor.Location = new Point(0, 54);
			btnCadastrarFornecedor.Margin = new Padding(0);
			btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
			btnCadastrarFornecedor.Size = new Size(220, 51);
			btnCadastrarFornecedor.TabIndex = 6;
			btnCadastrarFornecedor.Text = "Cadastrar";
			btnCadastrarFornecedor.UseVisualStyleBackColor = false;
			btnCadastrarFornecedor.Click += btnCadastrarFornecedor_Click;
			// 
			// btnConsultarFornecedor
			// 
			btnConsultarFornecedor.BackColor = Color.FromArgb(0, 45, 71);
			btnConsultarFornecedor.FlatAppearance.BorderSize = 0;
			btnConsultarFornecedor.FlatStyle = FlatStyle.Flat;
			btnConsultarFornecedor.Image = (Image)resources.GetObject("btnConsultarFornecedor.Image");
			btnConsultarFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultarFornecedor.Location = new Point(0, 105);
			btnConsultarFornecedor.Margin = new Padding(0);
			btnConsultarFornecedor.Name = "btnConsultarFornecedor";
			btnConsultarFornecedor.Size = new Size(220, 51);
			btnConsultarFornecedor.TabIndex = 6;
			btnConsultarFornecedor.Text = "Consultar";
			btnConsultarFornecedor.UseVisualStyleBackColor = false;
			btnConsultarFornecedor.Click += btnConsultarFornecedor_Click;
			// 
			// flpContainerEpi
			// 
			flpContainerEpi.BackColor = Color.FromArgb(0, 45, 71);
			flpContainerEpi.Controls.Add(btnEpi);
			flpContainerEpi.Controls.Add(btnCadastrarEpi);
			flpContainerEpi.Controls.Add(btnConsultarEpi);
			flpContainerEpi.Location = new Point(0, 109);
			flpContainerEpi.Margin = new Padding(0, 2, 0, 0);
			flpContainerEpi.Name = "flpContainerEpi";
			flpContainerEpi.Size = new Size(264, 54);
			flpContainerEpi.TabIndex = 7;
			// 
			// btnEpi
			// 
			btnEpi.BackColor = Color.FromArgb(74, 146, 247);
			btnEpi.FlatAppearance.BorderSize = 0;
			btnEpi.FlatStyle = FlatStyle.Flat;
			btnEpi.Image = (Image)resources.GetObject("btnEpi.Image");
			btnEpi.ImageAlign = ContentAlignment.MiddleLeft;
			btnEpi.Location = new Point(0, 0);
			btnEpi.Margin = new Padding(0);
			btnEpi.Name = "btnEpi";
			btnEpi.Size = new Size(220, 54);
			btnEpi.TabIndex = 2;
			btnEpi.Text = "E.P.I";
			btnEpi.UseVisualStyleBackColor = false;
			btnEpi.Click += btnEpi_Click;
			// 
			// btnCadastrarEpi
			// 
			btnCadastrarEpi.BackColor = Color.FromArgb(0, 45, 71);
			btnCadastrarEpi.FlatAppearance.BorderSize = 0;
			btnCadastrarEpi.FlatStyle = FlatStyle.Flat;
			btnCadastrarEpi.Image = (Image)resources.GetObject("btnCadastrarEpi.Image");
			btnCadastrarEpi.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastrarEpi.Location = new Point(0, 54);
			btnCadastrarEpi.Margin = new Padding(0);
			btnCadastrarEpi.Name = "btnCadastrarEpi";
			btnCadastrarEpi.Size = new Size(220, 51);
			btnCadastrarEpi.TabIndex = 6;
			btnCadastrarEpi.Text = "Cadastrar";
			btnCadastrarEpi.UseVisualStyleBackColor = false;
			btnCadastrarEpi.Click += btnCadastrarEpi_Click;
			// 
			// btnConsultarEpi
			// 
			btnConsultarEpi.BackColor = Color.FromArgb(0, 45, 71);
			btnConsultarEpi.FlatAppearance.BorderSize = 0;
			btnConsultarEpi.FlatStyle = FlatStyle.Flat;
			btnConsultarEpi.Image = (Image)resources.GetObject("btnConsultarEpi.Image");
			btnConsultarEpi.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultarEpi.Location = new Point(0, 105);
			btnConsultarEpi.Margin = new Padding(0);
			btnConsultarEpi.Name = "btnConsultarEpi";
			btnConsultarEpi.Size = new Size(220, 51);
			btnConsultarEpi.TabIndex = 6;
			btnConsultarEpi.Text = "Consultar";
			btnConsultarEpi.UseVisualStyleBackColor = false;
			btnConsultarEpi.Click += btnConsultarEpi_Click;
			// 
			// flpNormaRegulamentadora
			// 
			flpNormaRegulamentadora.BackColor = Color.FromArgb(0, 45, 71);
			flpNormaRegulamentadora.Controls.Add(btnNormasRegulamentadoras);
			flpNormaRegulamentadora.Controls.Add(btnCadastrarNormaRegulamentadora);
			flpNormaRegulamentadora.Controls.Add(btnConsultarNormaRegulamentadora);
			flpNormaRegulamentadora.Location = new Point(0, 165);
			flpNormaRegulamentadora.Margin = new Padding(0, 2, 0, 0);
			flpNormaRegulamentadora.Name = "flpNormaRegulamentadora";
			flpNormaRegulamentadora.Size = new Size(264, 54);
			flpNormaRegulamentadora.TabIndex = 8;
			// 
			// btnNormasRegulamentadoras
			// 
			btnNormasRegulamentadoras.BackColor = Color.FromArgb(74, 146, 247);
			btnNormasRegulamentadoras.FlatAppearance.BorderSize = 0;
			btnNormasRegulamentadoras.FlatStyle = FlatStyle.Flat;
			btnNormasRegulamentadoras.Image = (Image)resources.GetObject("btnNormasRegulamentadoras.Image");
			btnNormasRegulamentadoras.ImageAlign = ContentAlignment.MiddleLeft;
			btnNormasRegulamentadoras.Location = new Point(0, 0);
			btnNormasRegulamentadoras.Margin = new Padding(0);
			btnNormasRegulamentadoras.Name = "btnNormasRegulamentadoras";
			btnNormasRegulamentadoras.Size = new Size(220, 54);
			btnNormasRegulamentadoras.TabIndex = 2;
			btnNormasRegulamentadoras.Text = "Normas Regulamentadoras";
			btnNormasRegulamentadoras.UseVisualStyleBackColor = false;
			btnNormasRegulamentadoras.Click += btnNormasRegulamentadoras_Click;
			// 
			// btnCadastrarNormaRegulamentadora
			// 
			btnCadastrarNormaRegulamentadora.BackColor = Color.FromArgb(0, 45, 71);
			btnCadastrarNormaRegulamentadora.FlatAppearance.BorderSize = 0;
			btnCadastrarNormaRegulamentadora.FlatStyle = FlatStyle.Flat;
			btnCadastrarNormaRegulamentadora.Image = (Image)resources.GetObject("btnCadastrarNormaRegulamentadora.Image");
			btnCadastrarNormaRegulamentadora.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastrarNormaRegulamentadora.Location = new Point(0, 54);
			btnCadastrarNormaRegulamentadora.Margin = new Padding(0);
			btnCadastrarNormaRegulamentadora.Name = "btnCadastrarNormaRegulamentadora";
			btnCadastrarNormaRegulamentadora.Size = new Size(220, 51);
			btnCadastrarNormaRegulamentadora.TabIndex = 6;
			btnCadastrarNormaRegulamentadora.Text = "Cadastrar";
			btnCadastrarNormaRegulamentadora.UseVisualStyleBackColor = false;
			btnCadastrarNormaRegulamentadora.Click += btnCadastrarNormaRegulamentadora_Click;
			// 
			// btnConsultarNormaRegulamentadora
			// 
			btnConsultarNormaRegulamentadora.BackColor = Color.FromArgb(0, 45, 71);
			btnConsultarNormaRegulamentadora.FlatAppearance.BorderSize = 0;
			btnConsultarNormaRegulamentadora.FlatStyle = FlatStyle.Flat;
			btnConsultarNormaRegulamentadora.Image = (Image)resources.GetObject("btnConsultarNormaRegulamentadora.Image");
			btnConsultarNormaRegulamentadora.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultarNormaRegulamentadora.Location = new Point(0, 105);
			btnConsultarNormaRegulamentadora.Margin = new Padding(0);
			btnConsultarNormaRegulamentadora.Name = "btnConsultarNormaRegulamentadora";
			btnConsultarNormaRegulamentadora.Size = new Size(220, 51);
			btnConsultarNormaRegulamentadora.TabIndex = 6;
			btnConsultarNormaRegulamentadora.Text = "Consultar";
			btnConsultarNormaRegulamentadora.UseVisualStyleBackColor = false;
			btnConsultarNormaRegulamentadora.Click += btnConsultarNormaRegulamentadora_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(74, 146, 247);
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Image = (Image)resources.GetObject("button3.Image");
			button3.ImageAlign = ContentAlignment.MiddleLeft;
			button3.Location = new Point(1051, 416);
			button3.Name = "button3";
			button3.Size = new Size(220, 54);
			button3.TabIndex = 2;
			button3.Text = "Estoque";
			button3.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			button5.BackColor = Color.FromArgb(74, 146, 247);
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(1051, 299);
			button5.Name = "button5";
			button5.Size = new Size(220, 54);
			button5.TabIndex = 2;
			button5.Text = "Treinamentos";
			button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			button6.BackColor = Color.FromArgb(74, 146, 247);
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Image = (Image)resources.GetObject("button6.Image");
			button6.ImageAlign = ContentAlignment.MiddleLeft;
			button6.Location = new Point(509, 157);
			button6.Name = "button6";
			button6.Size = new Size(220, 54);
			button6.TabIndex = 2;
			button6.Text = "Emprestimo";
			button6.UseVisualStyleBackColor = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(465, 52);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(603, 580);
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// btnSair
			// 
			btnSair.BackColor = Color.FromArgb(74, 146, 247);
			btnSair.FlatAppearance.BorderSize = 0;
			btnSair.FlatStyle = FlatStyle.Flat;
			btnSair.Image = (Image)resources.GetObject("btnSair.Image");
			btnSair.ImageAlign = ContentAlignment.MiddleLeft;
			btnSair.Location = new Point(0, 221);
			btnSair.Margin = new Padding(0, 2, 0, 0);
			btnSair.Name = "btnSair";
			btnSair.Size = new Size(220, 54);
			btnSair.TabIndex = 2;
			btnSair.Text = "Sair";
			btnSair.UseVisualStyleBackColor = false;
			btnSair.Click += btnSair_Click;
			// 
			// trasicaoMenuFuncionario
			// 
			trasicaoMenuFuncionario.Interval = 1;
			trasicaoMenuFuncionario.Tick += trasicaoMenuFuncionario_Tick;
			// 
			// transicaoMenuFornecedor
			// 
			transicaoMenuFornecedor.Interval = 1;
			transicaoMenuFornecedor.Tick += transicaoMenuFornecedor_Tick;
			// 
			// transicaoMenuEpi
			// 
			transicaoMenuEpi.Interval = 1;
			transicaoMenuEpi.Tick += transicaoMenuEpi_Tick;
			// 
			// transicaoMenuNorma
			// 
			transicaoMenuNorma.Interval = 1;
			transicaoMenuNorma.Tick += transicaoMenuNorma_Tick;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.BackColor = Color.FromArgb(0, 45, 71);
			flowLayoutPanel2.Location = new Point(257, 402);
			flowLayoutPanel2.Margin = new Padding(0, 2, 0, 0);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(264, 54);
			flowLayoutPanel2.TabIndex = 9;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 45, 71);
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(509, 223);
			button2.Margin = new Padding(0);
			button2.Name = "button2";
			button2.Size = new Size(220, 51);
			button2.TabIndex = 6;
			button2.Text = "Cadastrar";
			button2.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			button4.BackColor = Color.FromArgb(0, 45, 71);
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Image = (Image)resources.GetObject("button4.Image");
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(509, 284);
			button4.Margin = new Padding(0);
			button4.Name = "button4";
			button4.Size = new Size(220, 51);
			button4.TabIndex = 6;
			button4.Text = "Consultar";
			button4.UseVisualStyleBackColor = false;
			// 
			// frmHome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(254, 253, 249);
			ClientSize = new Size(1283, 644);
			Controls.Add(button4);
			Controls.Add(button2);
			Controls.Add(flowLayoutPanel2);
			Controls.Add(button3);
			Controls.Add(button5);
			Controls.Add(button6);
			Controls.Add(pictureBox2);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 9F);
			ForeColor = Color.White;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmHome";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "HOME";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			flpContainer.ResumeLayout(false);
			flpContainerFornecedor.ResumeLayout(false);
			flpContainerEpi.ResumeLayout(false);
			flpNormaRegulamentadora.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button btnCadastroFornecedor;
		private Button button3;
		private Button btnFuncionario;
		private Button button5;
		private Button button6;
		private Button btnNormasRegulamentadoras;
		private PictureBox pictureBox2;
		private Button btnSair;
		private Button btnEpi;
		private FlowLayoutPanel flpContainer;
		private System.Windows.Forms.Timer trasicaoMenuFuncionario;
		private Button btnCadastrarFrm;
		private Button btnConsultarFrm;
		private FlowLayoutPanel flpContainerFornecedor;
		private Button btnCadastrarFornecedor;
		private Button btnConsultarFornecedor;
		private System.Windows.Forms.Timer transicaoMenuFornecedor;
		private FlowLayoutPanel flpContainerEpi;
		private Button btnConsultarEpi;
		private Button btnCadastrarEpi;
		private System.Windows.Forms.Timer transicaoMenuEpi;
		private FlowLayoutPanel flpNormaRegulamentadora;
		private Button btnCadastrarNormaRegulamentadora;
		private Button btnConsultarNormaRegulamentadora;
		private System.Windows.Forms.Timer transicaoMenuNorma;
		private FlowLayoutPanel flowLayoutPanel2;
		private Button button2;
		private Button button4;
	}
}
