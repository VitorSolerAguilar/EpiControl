namespace EpiControl.epicontrol.views
{
	partial class frmConsultarEpi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEpi));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label = new Label();
			btnConsultar = new Button();
			txtConsultaEpi = new TextBox();
			dgvEmprestimo = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvEmprestimo).BeginInit();
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
			panel1.Size = new Size(800, 46);
			panel1.TabIndex = 16;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(205, 37);
			label2.TabIndex = 3;
			label2.Text = "CONSULTAR EPI";
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
			label.Location = new Point(223, 77);
			label.Name = "label";
			label.Size = new Size(56, 15);
			label.TabIndex = 20;
			label.Text = "Pesquisa:";
			// 
			// btnConsultar
			// 
			btnConsultar.Location = new Point(530, 73);
			btnConsultar.Name = "btnConsultar";
			btnConsultar.Size = new Size(75, 24);
			btnConsultar.TabIndex = 19;
			btnConsultar.Text = "Consultar";
			btnConsultar.UseVisualStyleBackColor = true;
			btnConsultar.Click += btnConsultar_Click;
			// 
			// txtConsultaEpi
			// 
			txtConsultaEpi.Location = new Point(298, 74);
			txtConsultaEpi.Name = "txtConsultaEpi";
			txtConsultaEpi.Size = new Size(226, 23);
			txtConsultaEpi.TabIndex = 18;
			// 
			// dgvEmprestimo
			// 
			dgvEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvEmprestimo.Location = new Point(12, 103);
			dgvEmprestimo.Name = "dgvEmprestimo";
			dgvEmprestimo.ReadOnly = true;
			dgvEmprestimo.Size = new Size(776, 335);
			dgvEmprestimo.TabIndex = 17;
			dgvEmprestimo.CellClick += dgvEpi_CellClick;
			// 
			// frmConsultarEpi
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label);
			Controls.Add(btnConsultar);
			Controls.Add(txtConsultaEpi);
			Controls.Add(dgvEmprestimo);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "frmConsultarEpi";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += frmConsultarEpi_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvEmprestimo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label;
		private Button btnConsultar;
		private TextBox txtConsultaEpi;
		private DataGridView dgvEmprestimo;
	}
}