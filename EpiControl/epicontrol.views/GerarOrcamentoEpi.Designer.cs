namespace EpiControl.epicontrol.dao
{
    partial class frmOrcamentoEpi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamentoEpi));
            btnCalcular = new Button();
            txtOrcamento = new TextBox();
            dgvResultado = new DataGridView();
            lblSaldo = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(486, 100);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtOrcamento
            // 
            txtOrcamento.Location = new Point(329, 100);
            txtOrcamento.Name = "txtOrcamento";
            txtOrcamento.Size = new Size(151, 23);
            txtOrcamento.TabIndex = 1;
            // 
            // dgvResultado
            // 
            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(12, 160);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.ReadOnly = true;
            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultado.Size = new Size(854, 300);
            dgvResultado.TabIndex = 2;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(428, 63);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 15);
            lblSaldo.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 46);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(57, 4);
            label3.Name = "label3";
            label3.Size = new Size(324, 37);
            label3.TabIndex = 3;
            label3.Text = "GERAR RELATÓRIO DE EPI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(57, 9);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 2;
            label4.Text = "EPI CONTROL";
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
            // frmOrcamentoEpi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 472);
            Controls.Add(panel1);
            Controls.Add(lblSaldo);
            Controls.Add(dgvResultado);
            Controls.Add(txtOrcamento);
            Controls.Add(btnCalcular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmOrcamentoEpi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtOrcamento;
        private DataGridView dgvResultado;
        private Label lblSaldo;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}