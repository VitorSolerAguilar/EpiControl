namespace EpiControl.epicontrol.views
{
    partial class ConsultarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCurso));
            label = new Label();
            btnConsultar = new Button();
            txtConsultaNome = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvFuncionario = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(223, 83);
            label.Name = "label";
            label.Size = new Size(43, 15);
            label.TabIndex = 15;
            label.Text = "Nome:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(530, 79);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 24);
            btnConsultar.TabIndex = 14;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsultaNome
            // 
            txtConsultaNome.Location = new Point(298, 80);
            txtConsultaNome.Name = "txtConsultaNome";
            txtConsultaNome.Size = new Size(226, 23);
            txtConsultaNome.TabIndex = 13;
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
            // dgvFuncionario
            // 
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Location = new Point(12, 109);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.Size = new Size(776, 335);
            dgvFuncionario.TabIndex = 11;
            // 
            // ConsultarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(btnConsultar);
            Controls.Add(txtConsultaNome);
            Controls.Add(panel1);
            Controls.Add(dgvFuncionario);
            Name = "ConsultarCurso";
            Text = "ConsultarCurso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button btnConsultar;
        private TextBox txtConsultaNome;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvFuncionario;
    }
}