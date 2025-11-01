namespace EpiControl.Views.EPI
{
    partial class CadastrarEpi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEpi));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label3 = new Label();
			textBox1 = new TextBox();
			label4 = new Label();
			textBox2 = new TextBox();
			label5 = new Label();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			label6 = new Label();
			textBox3 = new TextBox();
			label7 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label8 = new Label();
			textBox4 = new TextBox();
			label9 = new Label();
			textBox5 = new TextBox();
			btn_voltar = new Button();
			button1 = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
			panel1.TabIndex = 53;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(206, 37);
			label2.TabIndex = 3;
			label2.Text = "CADASTRAR EPI";
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
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 71);
			label3.Name = "label3";
			label3.Size = new Size(43, 15);
			label3.TabIndex = 54;
			label3.Text = "Nome:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(61, 68);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(325, 23);
			textBox1.TabIndex = 55;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 119);
			label4.Name = "label4";
			label4.Size = new Size(90, 15);
			label4.TabIndex = 56;
			label4.Text = "Código Interno:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(108, 116);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(132, 23);
			textBox2.TabIndex = 57;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(263, 119);
			label5.Name = "label5";
			label5.Size = new Size(42, 15);
			label5.TabIndex = 58;
			label5.Text = "Status:";
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(311, 119);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(53, 19);
			radioButton1.TabIndex = 59;
			radioButton1.TabStop = true;
			radioButton1.Text = "Ativo";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(370, 120);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(61, 19);
			radioButton2.TabIndex = 60;
			radioButton2.TabStop = true;
			radioButton2.Text = "Inativo";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 163);
			label6.Name = "label6";
			label6.Size = new Size(26, 15);
			label6.TabIndex = 61;
			label6.Text = "CA:";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(44, 160);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(132, 23);
			textBox3.TabIndex = 62;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(221, 163);
			label7.Name = "label7";
			label7.Size = new Size(90, 15);
			label7.TabIndex = 63;
			label7.Text = "Validade do CA:";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(311, 160);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(200, 23);
			dateTimePicker1.TabIndex = 64;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(12, 205);
			label8.Name = "label8";
			label8.Size = new Size(59, 15);
			label8.TabIndex = 65;
			label8.Text = "Tamanho:";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(78, 202);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(132, 23);
			textBox4.TabIndex = 66;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(235, 205);
			label9.Name = "label9";
			label9.Size = new Size(29, 15);
			label9.TabIndex = 67;
			label9.Text = "Cor:";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(270, 205);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(132, 23);
			textBox5.TabIndex = 68;
			// 
			// btn_voltar
			// 
			btn_voltar.BackColor = Color.Transparent;
			btn_voltar.Location = new Point(557, 367);
			btn_voltar.Name = "btn_voltar";
			btn_voltar.Size = new Size(75, 40);
			btn_voltar.TabIndex = 69;
			btn_voltar.Text = "Voltar";
			btn_voltar.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(17, 138, 254);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.White;
			button1.Location = new Point(660, 367);
			button1.Name = "button1";
			button1.Size = new Size(75, 40);
			button1.TabIndex = 70;
			button1.Text = " Salvar";
			button1.UseVisualStyleBackColor = false;
			// 
			// CadastrarEpi
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(btn_voltar);
			Controls.Add(textBox5);
			Controls.Add(label9);
			Controls.Add(textBox4);
			Controls.Add(label8);
			Controls.Add(dateTimePicker1);
			Controls.Add(label7);
			Controls.Add(textBox3);
			Controls.Add(label6);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(label5);
			Controls.Add(textBox2);
			Controls.Add(label4);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "CadastrarEpi";
			Text = "EPICONTROL";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Button btn_voltar;
        private Button button1;
    }
}