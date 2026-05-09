namespace EpiControl.epicontrol.views
{
	partial class frmConsultaEstoqueEpi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEstoqueEpi));
            dgvEstoque = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label = new Label();
            btnConsultar = new Button();
            txtConsultaEstoque = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvEstoque
            // 
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(12, 104);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.Size = new Size(776, 374);
            dgvEstoque.TabIndex = 27;
            dgvEstoque.CellClick += dgvEstoque_CellClick;
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
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(326, 37);
            label2.TabIndex = 3;
            label2.Text = "CONSULTAR ESTOQUE EPI";
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
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(207, 78);
            label.Name = "label";
            label.Size = new Size(56, 15);
            label.TabIndex = 30;
            label.Text = "Pesquisa:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(514, 74);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 24);
            btnConsultar.TabIndex = 29;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtConsultaEstoque
            // 
            txtConsultaEstoque.Location = new Point(282, 75);
            txtConsultaEstoque.Name = "txtConsultaEstoque";
            txtConsultaEstoque.Size = new Size(226, 23);
            txtConsultaEstoque.TabIndex = 28;
            // 
            // frmConsultaEstoqueEpi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(label);
            Controls.Add(btnConsultar);
            Controls.Add(txtConsultaEstoque);
            Controls.Add(dgvEstoque);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConsultaEstoqueEpi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            Load += frmConsultaEstoqueEpi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvEstoque;
		private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label;
		private Button btnConsultar;
		private TextBox txtConsultaEstoque;
	}
}