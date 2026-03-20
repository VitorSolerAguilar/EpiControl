namespace EpiControl.epicontrol.views
{
    partial class FuncionarioCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioCurso));
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 56;
            label3.Text = "Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 57;
            label1.Text = "Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 58;
            label2.Text = "Conclusão:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 24);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 59;
            label4.Text = "Funcionário:";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 61;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(101, 67);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 62;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(101, 111);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(98, 23);
            maskedTextBox1.TabIndex = 74;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(101, 161);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(98, 23);
            maskedTextBox2.TabIndex = 75;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Location = new Point(249, 223);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 40);
            btnVoltar.TabIndex = 77;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(17, 138, 254);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(339, 223);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 40);
            btnSalvar.TabIndex = 78;
            btnSalvar.Text = " Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FuncionarioCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 281);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FuncionarioCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FuncionarioCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}