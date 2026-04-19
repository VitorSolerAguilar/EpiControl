namespace EpiControl.epicontrol.views
{
    partial class frmConsultarCurso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCurso));
			label = new Label();
			btnConsultar = new Button();
			txtConsultaNomeTreinamento = new TextBox();
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			dgvTreinamento = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvTreinamento).BeginInit();
			SuspendLayout();
			// 
			// label
			// 
			label.AutoSize = true;
			label.Location = new Point(223, 83);
			label.Name = "label";
			label.Size = new Size(56, 15);
			label.TabIndex = 15;
			label.Text = "Pesquisa:";
			// 
			// btnConsultar
			// 
			btnConsultar.Location = new Point(530, 79);
			btnConsultar.Name = "btnConsultar";
			btnConsultar.Size = new Size(75, 24);
			btnConsultar.TabIndex = 14;
			btnConsultar.Text = "Consultar";
			btnConsultar.UseVisualStyleBackColor = true;
			btnConsultar.Click += btnConsultar_Click;
			// 
			// txtConsultaNomeTreinamento
			// 
			txtConsultaNomeTreinamento.Location = new Point(298, 80);
			txtConsultaNomeTreinamento.Name = "txtConsultaNomeTreinamento";
			txtConsultaNomeTreinamento.Size = new Size(226, 23);
			txtConsultaNomeTreinamento.TabIndex = 13;
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
			panel1.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(255, 37);
			label2.TabIndex = 3;
			label2.Text = "CONSULTAR CURSO";
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
			// dgvTreinamento
			// 
			dgvTreinamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvTreinamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTreinamento.Location = new Point(12, 109);
			dgvTreinamento.Name = "dgvTreinamento";
			dgvTreinamento.ReadOnly = true;
			dgvTreinamento.Size = new Size(776, 335);
			dgvTreinamento.TabIndex = 11;
			dgvTreinamento.CellClick += dgvTreinamento_CellClick;
			// 
			// frmConsultarCurso
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label);
			Controls.Add(btnConsultar);
			Controls.Add(txtConsultaNomeTreinamento);
			Controls.Add(panel1);
			Controls.Add(dgvTreinamento);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "frmConsultarCurso";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EPICONTROL";
			Load += frmConsultarCurso_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvTreinamento).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label;
        private Button btnConsultar;
        private TextBox txtConsultaNomeTreinamento;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvTreinamento;
    }
}