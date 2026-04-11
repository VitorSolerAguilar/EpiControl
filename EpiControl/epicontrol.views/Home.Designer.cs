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
			flpEmprestimo = new FlowLayoutPanel();
			btnEmprestimo = new Button();
			btnCadastrarEmprestimo = new Button();
			btnConsultarEmprestimo = new Button();
			flpEstoque = new FlowLayoutPanel();
			btnEstoque = new Button();
			btnCadastrarEstoque = new Button();
			btnConsultarEstoque = new Button();
			btnMovimentacao = new Button();
			flpTreinamentos = new FlowLayoutPanel();
			btnTreinamentos = new Button();
			btnCadastrarTreinamentos = new Button();
			btnConsultarTreinamentos = new Button();
			btnSair = new Button();
			pictureBox2 = new PictureBox();
			trasicaoMenuFuncionario = new System.Windows.Forms.Timer(components);
			transicaoMenuFornecedor = new System.Windows.Forms.Timer(components);
			transicaoMenuEpi = new System.Windows.Forms.Timer(components);
			transicaoMenuNorma = new System.Windows.Forms.Timer(components);
			transicaoMenuEmprestimo = new System.Windows.Forms.Timer(components);
			transicaoMenuEstoque = new System.Windows.Forms.Timer(components);
			transicaoMenuTreinamentos = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			flpContainer.SuspendLayout();
			flpContainerFornecedor.SuspendLayout();
			flpContainerEpi.SuspendLayout();
			flpNormaRegulamentadora.SuspendLayout();
			flpEmprestimo.SuspendLayout();
			flpEstoque.SuspendLayout();
			flpTreinamentos.SuspendLayout();
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
			flowLayoutPanel1.Controls.Add(flpEmprestimo);
			flowLayoutPanel1.Controls.Add(flpEstoque);
			flowLayoutPanel1.Controls.Add(flpTreinamentos);
			flowLayoutPanel1.Controls.Add(btnSair);
			flowLayoutPanel1.Dock = DockStyle.Left;
			flowLayoutPanel1.Location = new Point(0, 46);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(221, 598);
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
			btnNormasRegulamentadoras.Text = "             Normas Regulamentadoras";
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
			// flpEmprestimo
			// 
			flpEmprestimo.BackColor = Color.FromArgb(0, 45, 71);
			flpEmprestimo.Controls.Add(btnEmprestimo);
			flpEmprestimo.Controls.Add(btnCadastrarEmprestimo);
			flpEmprestimo.Controls.Add(btnConsultarEmprestimo);
			flpEmprestimo.Location = new Point(0, 221);
			flpEmprestimo.Margin = new Padding(0, 2, 0, 0);
			flpEmprestimo.Name = "flpEmprestimo";
			flpEmprestimo.Size = new Size(264, 54);
			flpEmprestimo.TabIndex = 9;
			// 
			// btnEmprestimo
			// 
			btnEmprestimo.BackColor = Color.FromArgb(74, 146, 247);
			btnEmprestimo.FlatAppearance.BorderSize = 0;
			btnEmprestimo.FlatStyle = FlatStyle.Flat;
			btnEmprestimo.Image = (Image)resources.GetObject("btnEmprestimo.Image");
			btnEmprestimo.ImageAlign = ContentAlignment.MiddleLeft;
			btnEmprestimo.Location = new Point(0, 0);
			btnEmprestimo.Margin = new Padding(0);
			btnEmprestimo.Name = "btnEmprestimo";
			btnEmprestimo.Size = new Size(220, 54);
			btnEmprestimo.TabIndex = 2;
			btnEmprestimo.Text = "Emprestimo";
			btnEmprestimo.UseVisualStyleBackColor = false;
			btnEmprestimo.Click += btnEmprestimo_Click;
			// 
			// btnCadastrarEmprestimo
			// 
			btnCadastrarEmprestimo.BackColor = Color.FromArgb(0, 45, 71);
			btnCadastrarEmprestimo.FlatAppearance.BorderSize = 0;
			btnCadastrarEmprestimo.FlatStyle = FlatStyle.Flat;
			btnCadastrarEmprestimo.Image = (Image)resources.GetObject("btnCadastrarEmprestimo.Image");
			btnCadastrarEmprestimo.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastrarEmprestimo.Location = new Point(0, 54);
			btnCadastrarEmprestimo.Margin = new Padding(0);
			btnCadastrarEmprestimo.Name = "btnCadastrarEmprestimo";
			btnCadastrarEmprestimo.Size = new Size(220, 51);
			btnCadastrarEmprestimo.TabIndex = 6;
			btnCadastrarEmprestimo.Text = "Cadastrar";
			btnCadastrarEmprestimo.UseVisualStyleBackColor = false;
			btnCadastrarEmprestimo.Click += btnCadastrarEmprestimo_Click;
			// 
			// btnConsultarEmprestimo
			// 
			btnConsultarEmprestimo.BackColor = Color.FromArgb(0, 45, 71);
			btnConsultarEmprestimo.FlatAppearance.BorderSize = 0;
			btnConsultarEmprestimo.FlatStyle = FlatStyle.Flat;
			btnConsultarEmprestimo.Image = (Image)resources.GetObject("btnConsultarEmprestimo.Image");
			btnConsultarEmprestimo.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultarEmprestimo.Location = new Point(0, 105);
			btnConsultarEmprestimo.Margin = new Padding(0);
			btnConsultarEmprestimo.Name = "btnConsultarEmprestimo";
			btnConsultarEmprestimo.Size = new Size(220, 51);
			btnConsultarEmprestimo.TabIndex = 6;
			btnConsultarEmprestimo.Text = "Consultar";
			btnConsultarEmprestimo.UseVisualStyleBackColor = false;
			btnConsultarEmprestimo.Click += btnConsultarEmprestimo_Click;
			// 
			// flpEstoque
			// 
			flpEstoque.BackColor = Color.FromArgb(0, 45, 71);
			flpEstoque.Controls.Add(btnEstoque);
			flpEstoque.Controls.Add(btnCadastrarEstoque);
			flpEstoque.Controls.Add(btnConsultarEstoque);
			flpEstoque.Controls.Add(btnMovimentacao);
			flpEstoque.Location = new Point(0, 277);
			flpEstoque.Margin = new Padding(0, 2, 0, 0);
			flpEstoque.Name = "flpEstoque";
			flpEstoque.Size = new Size(264, 54);
			flpEstoque.TabIndex = 10;
			// 
			// btnEstoque
			// 
			btnEstoque.BackColor = Color.FromArgb(74, 146, 247);
			btnEstoque.FlatAppearance.BorderSize = 0;
			btnEstoque.FlatStyle = FlatStyle.Flat;
			btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
			btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
			btnEstoque.Location = new Point(0, 0);
			btnEstoque.Margin = new Padding(0);
			btnEstoque.Name = "btnEstoque";
			btnEstoque.Size = new Size(220, 54);
			btnEstoque.TabIndex = 2;
			btnEstoque.Text = "Estoque";
			btnEstoque.UseVisualStyleBackColor = false;
			btnEstoque.Click += btnEstoque_Click;
			// 
			// btnCadastrarEstoque
			// 
			btnCadastrarEstoque.BackColor = Color.FromArgb(0, 45, 71);
			btnCadastrarEstoque.FlatAppearance.BorderSize = 0;
			btnCadastrarEstoque.FlatStyle = FlatStyle.Flat;
			btnCadastrarEstoque.Image = (Image)resources.GetObject("btnCadastrarEstoque.Image");
			btnCadastrarEstoque.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastrarEstoque.Location = new Point(0, 54);
			btnCadastrarEstoque.Margin = new Padding(0);
			btnCadastrarEstoque.Name = "btnCadastrarEstoque";
			btnCadastrarEstoque.Size = new Size(220, 51);
			btnCadastrarEstoque.TabIndex = 6;
			btnCadastrarEstoque.Text = "Cadastrar";
			btnCadastrarEstoque.UseVisualStyleBackColor = false;
			btnCadastrarEstoque.Click += btnCadastrarEstoque_Click;
			// 
			// btnConsultarEstoque
			// 
			btnConsultarEstoque.BackColor = Color.FromArgb(0, 45, 71);
			btnConsultarEstoque.FlatAppearance.BorderSize = 0;
			btnConsultarEstoque.FlatStyle = FlatStyle.Flat;
			btnConsultarEstoque.Image = (Image)resources.GetObject("btnConsultarEstoque.Image");
			btnConsultarEstoque.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultarEstoque.Location = new Point(0, 105);
			btnConsultarEstoque.Margin = new Padding(0);
			btnConsultarEstoque.Name = "btnConsultarEstoque";
			btnConsultarEstoque.Size = new Size(220, 51);
			btnConsultarEstoque.TabIndex = 6;
			btnConsultarEstoque.Text = "Consultar";
			btnConsultarEstoque.UseVisualStyleBackColor = false;
			btnConsultarEstoque.Click += btnConsultarEstoque_Click;
			// 
			// btnMovimentacao
			// 
			btnMovimentacao.BackColor = Color.FromArgb(0, 45, 71);
			btnMovimentacao.FlatAppearance.BorderSize = 0;
			btnMovimentacao.FlatStyle = FlatStyle.Flat;
			btnMovimentacao.Image = (Image)resources.GetObject("btnMovimentacao.Image");
			btnMovimentacao.ImageAlign = ContentAlignment.MiddleLeft;
			btnMovimentacao.Location = new Point(0, 156);
			btnMovimentacao.Margin = new Padding(0);
			btnMovimentacao.Name = "btnMovimentacao";
			btnMovimentacao.Size = new Size(220, 51);
			btnMovimentacao.TabIndex = 7;
			btnMovimentacao.Text = "Movimentação";
			btnMovimentacao.UseVisualStyleBackColor = false;
			btnMovimentacao.Click += btnMovimentacao_Click;
			// 
			// flpTreinamentos
			// 
			flpTreinamentos.BackColor = Color.FromArgb(0, 45, 71);
			flpTreinamentos.Controls.Add(btnTreinamentos);
			flpTreinamentos.Controls.Add(btnCadastrarTreinamentos);
			flpTreinamentos.Controls.Add(btnConsultarTreinamentos);
			flpTreinamentos.Location = new Point(0, 333);
			flpTreinamentos.Margin = new Padding(0, 2, 0, 0);
			flpTreinamentos.Name = "flpTreinamentos";
			flpTreinamentos.Size = new Size(264, 54);
			flpTreinamentos.TabIndex = 11;
			// 
			// btnTreinamentos
			// 
			btnTreinamentos.BackColor = Color.FromArgb(74, 146, 247);
			btnTreinamentos.FlatAppearance.BorderSize = 0;
			btnTreinamentos.FlatStyle = FlatStyle.Flat;
			btnTreinamentos.Image = (Image)resources.GetObject("btnTreinamentos.Image");
			btnTreinamentos.ImageAlign = ContentAlignment.MiddleLeft;
			btnTreinamentos.Location = new Point(0, 0);
			btnTreinamentos.Margin = new Padding(0);
			btnTreinamentos.Name = "btnTreinamentos";
			btnTreinamentos.Size = new Size(220, 54);
			btnTreinamentos.TabIndex = 2;
			btnTreinamentos.Text = "Treinamentos";
			btnTreinamentos.UseVisualStyleBackColor = false;
			btnTreinamentos.Click += btnTreinamentos_Click;
			// 
			// btnCadastrarTreinamentos
			// 
			btnCadastrarTreinamentos.BackColor = Color.FromArgb(0, 45, 71);
			btnCadastrarTreinamentos.FlatAppearance.BorderSize = 0;
			btnCadastrarTreinamentos.FlatStyle = FlatStyle.Flat;
			btnCadastrarTreinamentos.Image = (Image)resources.GetObject("btnCadastrarTreinamentos.Image");
			btnCadastrarTreinamentos.ImageAlign = ContentAlignment.MiddleLeft;
			btnCadastrarTreinamentos.Location = new Point(0, 54);
			btnCadastrarTreinamentos.Margin = new Padding(0);
			btnCadastrarTreinamentos.Name = "btnCadastrarTreinamentos";
			btnCadastrarTreinamentos.Size = new Size(220, 51);
			btnCadastrarTreinamentos.TabIndex = 6;
			btnCadastrarTreinamentos.Text = "Cadastrar";
			btnCadastrarTreinamentos.UseVisualStyleBackColor = false;
			btnCadastrarTreinamentos.Click += btnCadastrarTreinamentos_Click;
			// 
			// btnConsultarTreinamentos
			// 
			btnConsultarTreinamentos.BackColor = Color.FromArgb(0, 45, 71);
			btnConsultarTreinamentos.FlatAppearance.BorderSize = 0;
			btnConsultarTreinamentos.FlatStyle = FlatStyle.Flat;
			btnConsultarTreinamentos.Image = (Image)resources.GetObject("btnConsultarTreinamentos.Image");
			btnConsultarTreinamentos.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultarTreinamentos.Location = new Point(0, 105);
			btnConsultarTreinamentos.Margin = new Padding(0);
			btnConsultarTreinamentos.Name = "btnConsultarTreinamentos";
			btnConsultarTreinamentos.Size = new Size(220, 51);
			btnConsultarTreinamentos.TabIndex = 6;
			btnConsultarTreinamentos.Text = "Consultar";
			btnConsultarTreinamentos.UseVisualStyleBackColor = false;
			btnConsultarTreinamentos.Click += btnConsultarTreinamentos_Click;
			// 
			// btnSair
			// 
			btnSair.BackColor = Color.FromArgb(74, 146, 247);
			btnSair.FlatAppearance.BorderSize = 0;
			btnSair.FlatStyle = FlatStyle.Flat;
			btnSair.Image = (Image)resources.GetObject("btnSair.Image");
			btnSair.ImageAlign = ContentAlignment.MiddleLeft;
			btnSair.Location = new Point(0, 389);
			btnSair.Margin = new Padding(0, 2, 0, 0);
			btnSair.Name = "btnSair";
			btnSair.Size = new Size(220, 54);
			btnSair.TabIndex = 2;
			btnSair.Text = "Sair";
			btnSair.UseVisualStyleBackColor = false;
			btnSair.Click += btnSair_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(424, 52);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(603, 580);
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
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
			// transicaoMenuEmprestimo
			// 
			transicaoMenuEmprestimo.Interval = 1;
			transicaoMenuEmprestimo.Tick += transicaoMenuEmprestimo_Tick;
			// 
			// transicaoMenuEstoque
			// 
			transicaoMenuEstoque.Interval = 1;
			transicaoMenuEstoque.Tick += transicaoMenuEstoque_Tick;
			// 
			// transicaoMenuTreinamentos
			// 
			transicaoMenuTreinamentos.Interval = 1;
			transicaoMenuTreinamentos.Tick += transicaoMenuTreinamentos_Tick;
			// 
			// frmHome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(254, 253, 249);
			ClientSize = new Size(1283, 644);
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
			flpEmprestimo.ResumeLayout(false);
			flpEstoque.ResumeLayout(false);
			flpTreinamentos.ResumeLayout(false);
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
		private Button btnEstoque;
		private Button btnFuncionario;
		private Button btnTreinamentos;
		private Button btnEmprestimo;
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
		private FlowLayoutPanel flpEmprestimo;
		private Button btnCadastrarEmprestimo;
		private Button btnConsultarEmprestimo;
		private System.Windows.Forms.Timer transicaoMenuEmprestimo;
		private FlowLayoutPanel flpEstoque;
		private Button btnCadastrarEstoque;
		private Button btnConsultarEstoque;
		private System.Windows.Forms.Timer transicaoMenuEstoque;
		private Button btnMovimentacao;
		private System.Windows.Forms.Timer transicaoMenuTreinamentos;
		private FlowLayoutPanel flpTreinamentos;
		private Button btnCadastrarTreinamentos;
		private Button btnConsultarTreinamentos;
	}
}
