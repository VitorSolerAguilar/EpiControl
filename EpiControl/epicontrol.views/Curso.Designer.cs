namespace EpiControl.epicontrol.views
{
    partial class frmCurso
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
            label3 = new Label();
            txtNome = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            richTextBox1 = new RichTextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 55;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(101, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 56;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 23);
            textBox1.TabIndex = 58;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 59;
            label1.Text = "Carga Horária:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 220);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 60;
            label2.Text = "Descrição:";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 62;
            label4.Text = "Validade:";
            label4.Click += label4_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(342, 302);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 40);
            btnVoltar.TabIndex = 70;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(17, 138, 254);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(434, 302);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 40);
            btnSalvar.TabIndex = 71;
            btnSalvar.Text = " Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(101, 178);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(278, 97);
            richTextBox1.TabIndex = 72;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(101, 126);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(98, 23);
            maskedTextBox1.TabIndex = 73;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // frmCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 369);
            Controls.Add(maskedTextBox1);
            Controls.Add(richTextBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Name = "frmCurso";
            Text = "Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtNome;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnVoltar;
        private Button btnSalvar;
        private RichTextBox richTextBox1;
        private MaskedTextBox maskedTextBox1;
    }
}