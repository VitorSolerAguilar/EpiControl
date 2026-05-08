namespace EpiControl.epicontrol.views
{
    partial class fmrGerarRelatorioEpi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrGerarRelatorioEpi));
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            dgvRelatorio = new DataGridView();
            btnExportarPdf = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(378, 76);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(126, 23);
            dtpInicio.TabIndex = 0;
            // 
            // dtpFim
            // 
            dtpFim.Format = DateTimePickerFormat.Short;
            dtpFim.Location = new Point(378, 107);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(126, 23);
            dtpFim.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 81);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Data início *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 113);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Data fim *";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(785, 428);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 40);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Location = new Point(12, 163);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.Size = new Size(854, 259);
            dgvRelatorio.TabIndex = 6;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Image = (Image)resources.GetObject("btnExportarPdf.Image");
            btnExportarPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarPdf.Location = new Point(713, 428);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(66, 40);
            btnExportarPdf.TabIndex = 7;
            btnExportarPdf.Text = "Gerar";
            btnExportarPdf.TextAlign = ContentAlignment.MiddleRight;
            btnExportarPdf.UseVisualStyleBackColor = true;
            btnExportarPdf.Click += btnExportarPdf_Click;
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
            panel1.TabIndex = 8;
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
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(641, 428);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(66, 40);
            btnVoltar.TabIndex = 103;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // fmrGerarRelatorioEpi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 472);
            Controls.Add(btnVoltar);
            Controls.Add(panel1);
            Controls.Add(btnExportarPdf);
            Controls.Add(dgvRelatorio);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmrGerarRelatorioEpi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private DataGridView dgvRelatorio;
        private Button btnExportarPdf;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnVoltar;
    }
}