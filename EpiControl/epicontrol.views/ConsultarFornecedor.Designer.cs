namespace EpiControl.epicontrol.views
{
	partial class frmConsultarFornecedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFornecedor));
			label = new Label();
			btnConsultar = new Button();
			txtConsultaNome = new TextBox();
			dgvFornecedor = new DataGridView();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label
			// 
			label.AutoSize = true;
			label.Location = new Point(224, 85);
			label.Name = "label";
			label.Size = new Size(56, 15);
			label.TabIndex = 14;
			label.Text = "Pesquisa:";
			// 
			// btnConsultar
			// 
			btnConsultar.Location = new Point(531, 81);
			btnConsultar.Name = "btnConsultar";
			btnConsultar.Size = new Size(75, 24);
			btnConsultar.TabIndex = 13;
			btnConsultar.Text = "Consultar";
			btnConsultar.UseVisualStyleBackColor = true;
			btnConsultar.Click += btnConsultar_Click;
			// 
			// txtConsultaNome
			// 
			txtConsultaNome.Location = new Point(299, 82);
			txtConsultaNome.Name = "txtConsultaNome";
			txtConsultaNome.Size = new Size(226, 23);
			txtConsultaNome.TabIndex = 12;
			// 
			// dgvFornecedor
			// 
			dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFornecedor.Location = new Point(13, 111);
			dgvFornecedor.Name = "dgvFornecedor";
			dgvFornecedor.ReadOnly = true;
			dgvFornecedor.Size = new Size(776, 335);
			dgvFornecedor.TabIndex = 11;
			dgvFornecedor.CellClick += dgvFornecedor_CellClick;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(338, 37);
			label2.TabIndex = 3;
			label2.Text = "CONSULTAR FORNECEDOR";
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
			panel1.TabIndex = 15;
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
			// frmConsultarFornecedor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Controls.Add(label);
			Controls.Add(btnConsultar);
			Controls.Add(txtConsultaNome);
			Controls.Add(dgvFornecedor);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "frmConsultarFornecedor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += frmConsultarFornecedor_Load;
			((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label;
		private Button btnConsultar;
		private TextBox txtConsultaNome;
		private DataGridView dgvFornecedor;
		private Label label2;
		private PictureBox pictureBox1;
		private Panel panel1;
		private Label label1;
	}
}