namespace EpiControl.epicontrol.views
{
    partial class frmCadastrarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarCurso));
            label3 = new Label();
            txtNome = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtCargaHoraria = new TextBox();
            label5 = new Label();
            rtbDescricao = new RichTextBox();
            label6 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            mtbValidade = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 64);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 55;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 56;
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
            panel1.Size = new Size(489, 46);
            panel1.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(256, 37);
            label2.TabIndex = 3;
            label2.Text = "CADASTRAR CURSO";
            label2.Click += label2_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 103);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 58;
            label4.Text = "Carga Horária:";
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(93, 100);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(107, 23);
            txtCargaHoraria.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 199);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 60;
            label5.Text = "Descrição:";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(93, 158);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(293, 97);
            rtbDescricao.TabIndex = 61;
            rtbDescricao.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 286);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 62;
            label6.Text = "Validade:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(280, 341);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 40);
            btnVoltar.TabIndex = 70;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(17, 138, 254);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(373, 341);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 40);
            btnSalvar.TabIndex = 71;
            btnSalvar.Text = " Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // mtbValidade
            // 
            mtbValidade.Location = new Point(93, 283);
            mtbValidade.Mask = "00/00/0000";
            mtbValidade.Name = "mtbValidade";
            mtbValidade.Size = new Size(100, 23);
            mtbValidade.TabIndex = 72;
            mtbValidade.ValidatingType = typeof(DateTime);
            // 
            // frmCadastrarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 406);
            Controls.Add(mtbValidade);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label6);
            Controls.Add(rtbDescricao);
            Controls.Add(label5);
            Controls.Add(txtCargaHoraria);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastrarCurso";
            Text = "Cadastrar Curso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtNome;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtCargaHoraria;
        private Label label5;
        private RichTextBox rtbDescricao;
        private Label label6;
        private Button btnVoltar;
        private Button btnSalvar;
        private MaskedTextBox mtbValidade;
    }
}