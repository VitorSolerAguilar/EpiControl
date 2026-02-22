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
			btn_normasRegulamentadoras = new Button();
			btn_cadastroFornecedor = new Button();
			button3 = new Button();
			button5 = new Button();
			button6 = new Button();
			pictureBox2 = new PictureBox();
			btn_sair = new Button();
			button2 = new Button();
			trasicaoMenu = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			flpContainer.SuspendLayout();
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
			flowLayoutPanel1.Dock = DockStyle.Left;
			flowLayoutPanel1.Location = new Point(0, 46);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(223, 598);
			flowLayoutPanel1.TabIndex = 3;
			// 
			// flpContainer
			// 
			flpContainer.BackColor = Color.FromArgb(0, 45, 71);
			flpContainer.BackgroundImageLayout = ImageLayout.None;
			flpContainer.Controls.Add(btnFuncionario);
			flpContainer.Controls.Add(btnCadastrarFrm);
			flpContainer.Controls.Add(btnConsultarFrm);
			flpContainer.Location = new Point(3, 3);
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
			// btn_normasRegulamentadoras
			// 
			btn_normasRegulamentadoras.BackColor = Color.FromArgb(74, 146, 247);
			btn_normasRegulamentadoras.FlatAppearance.BorderSize = 0;
			btn_normasRegulamentadoras.FlatStyle = FlatStyle.Flat;
			btn_normasRegulamentadoras.Image = (Image)resources.GetObject("btn_normasRegulamentadoras.Image");
			btn_normasRegulamentadoras.ImageAlign = ContentAlignment.MiddleLeft;
			btn_normasRegulamentadoras.Location = new Point(239, 151);
			btn_normasRegulamentadoras.Name = "btn_normasRegulamentadoras";
			btn_normasRegulamentadoras.Size = new Size(220, 54);
			btn_normasRegulamentadoras.TabIndex = 2;
			btn_normasRegulamentadoras.Text = "Normas Regulamentadoras";
			btn_normasRegulamentadoras.UseVisualStyleBackColor = false;
			btn_normasRegulamentadoras.Click += btn_normasRegulamentadoras_Click;
			// 
			// btn_cadastroFornecedor
			// 
			btn_cadastroFornecedor.BackColor = Color.FromArgb(74, 146, 247);
			btn_cadastroFornecedor.FlatAppearance.BorderSize = 0;
			btn_cadastroFornecedor.FlatStyle = FlatStyle.Flat;
			btn_cadastroFornecedor.Image = (Image)resources.GetObject("btn_cadastroFornecedor.Image");
			btn_cadastroFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
			btn_cadastroFornecedor.Location = new Point(239, 356);
			btn_cadastroFornecedor.Name = "btn_cadastroFornecedor";
			btn_cadastroFornecedor.Size = new Size(220, 54);
			btn_cadastroFornecedor.TabIndex = 2;
			btn_cadastroFornecedor.Text = "Cadastro Fonecedor";
			btn_cadastroFornecedor.UseVisualStyleBackColor = false;
			btn_cadastroFornecedor.Click += btn_cadastroFornecedor_Click;
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
			button5.Location = new Point(239, 236);
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
			button6.Location = new Point(239, 296);
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
			// btn_sair
			// 
			btn_sair.BackColor = Color.FromArgb(74, 146, 247);
			btn_sair.FlatAppearance.BorderSize = 0;
			btn_sair.FlatStyle = FlatStyle.Flat;
			btn_sair.Image = (Image)resources.GetObject("btn_sair.Image");
			btn_sair.ImageAlign = ContentAlignment.MiddleLeft;
			btn_sair.Location = new Point(239, 432);
			btn_sair.Name = "btn_sair";
			btn_sair.Size = new Size(220, 54);
			btn_sair.TabIndex = 2;
			btn_sair.Text = "Sair";
			btn_sair.UseVisualStyleBackColor = false;
			btn_sair.Click += btn_sair_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(74, 146, 247);
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(1051, 356);
			button2.Name = "button2";
			button2.Size = new Size(220, 54);
			button2.TabIndex = 2;
			button2.Text = "EPI";
			button2.UseVisualStyleBackColor = false;
			// 
			// trasicaoMenu
			// 
			trasicaoMenu.Interval = 1;
			trasicaoMenu.Tick += trasicaoMenu_Tick;
			// 
			// frmHome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(254, 253, 249);
			ClientSize = new Size(1283, 644);
			Controls.Add(btn_sair);
			Controls.Add(btn_normasRegulamentadoras);
			Controls.Add(btn_cadastroFornecedor);
			Controls.Add(button3);
			Controls.Add(button2);
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
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button btn_cadastroFornecedor;
		private Button button3;
		private Button btnFuncionario;
		private Button button5;
		private Button button6;
		private Button btn_normasRegulamentadoras;
		private PictureBox pictureBox2;
		private Button btn_sair;
		private Button button2;
		private FlowLayoutPanel flpContainer;
		private System.Windows.Forms.Timer trasicaoMenu;
		private Button btnCadastrarFrm;
		private Button btnConsultarFrm;
	}
}
