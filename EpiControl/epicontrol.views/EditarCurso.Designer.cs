namespace EpiControl.epicontrol.views
{
    partial class frmEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarCurso));
            mtbValidade = new MaskedTextBox();
            btnVoltar = new Button();
            label6 = new Label();
            rtbDescricao = new RichTextBox();
            label5 = new Label();
            txtCargaHoraria = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            label3 = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mtbValidade
            // 
            mtbValidade.Location = new Point(151, 295);
            mtbValidade.Mask = "00/00/0000";
            mtbValidade.Name = "mtbValidade";
            mtbValidade.Size = new Size(100, 23);
            mtbValidade.TabIndex = 83;
            mtbValidade.ValidatingType = typeof(DateTime);
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(279, 376);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 81;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 298);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 80;
            label6.Text = "Validade:";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(151, 171);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(293, 97);
            rtbDescricao.TabIndex = 79;
            rtbDescricao.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 211);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 78;
            label5.Text = "Descrição:";
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(151, 112);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(107, 23);
            txtCargaHoraria.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 115);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 76;
            label4.Text = "Carga Horária:";
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
            panel1.Size = new Size(549, 46);
            panel1.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(195, 37);
            label2.TabIndex = 3;
            label2.Text = "EDITAR CURSO";
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
            // txtNome
            // 
            txtNome.Location = new Point(151, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 76);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 73;
            label3.Text = "Nome:";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(437, 376);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(72, 40);
            btnExcluir.TabIndex = 99;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(357, 376);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 100;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 431);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(mtbValidade);
            Controls.Add(btnVoltar);
            Controls.Add(label6);
            Controls.Add(rtbDescricao);
            Controls.Add(label5);
            Controls.Add(txtCargaHoraria);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(txtNome);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmEditarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPICONTROL";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbValidade;
        private Button btnVoltar;
        private Label label6;
        private RichTextBox rtbDescricao;
        private Label label5;
        private TextBox txtCargaHoraria;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtNome;
        private Label label3;
		private Button btnExcluir;
		private Button btnEditar;
	}
}