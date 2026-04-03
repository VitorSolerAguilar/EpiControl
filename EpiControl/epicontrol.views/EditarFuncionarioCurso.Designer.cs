namespace EpiControl.epicontrol.views
{
    partial class EditarFuncionarioCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionarioCurso));
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnVoltar = new Button();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 46);
            panel1.TabIndex = 90;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(57, 4);
            label5.Name = "label5";
            label5.Size = new Size(378, 37);
            label5.TabIndex = 3;
            label5.Text = "EDITAR FUNCIONARIO CURSO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(57, 9);
            label6.Name = "label6";
            label6.Size = new Size(130, 28);
            label6.TabIndex = 2;
            label6.Text = "EPI CONTROL";
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
            btnVoltar.Location = new Point(300, 332);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 40);
            btnVoltar.TabIndex = 88;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(101, 280);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(98, 23);
            maskedTextBox2.TabIndex = 87;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(101, 231);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(98, 23);
            maskedTextBox1.TabIndex = 86;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(101, 184);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 85;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 142);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 83;
            label4.Text = "Funcionário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 283);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 82;
            label2.Text = "Conclusão:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 234);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 81;
            label1.Text = "Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 187);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 80;
            label3.Text = "Curso:";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(239, 43, 65);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(487, 332);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 40);
            btnExcluir.TabIndex = 98;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(17, 138, 254);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(392, 332);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 99;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // EditarFuncionarioCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 393);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(panel1);
            Controls.Add(btnVoltar);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "EditarFuncionarioCurso";
            Text = "EditarFuncionarioCurso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnVoltar;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnExcluir;
        private Button btnEditar;
    }
}