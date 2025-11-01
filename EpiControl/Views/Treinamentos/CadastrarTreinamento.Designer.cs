namespace EpiControl.Views.Treinamentos
{
	partial class CadastrarTreinamento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarTreinamento));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			textBox2 = new TextBox();
			label4 = new Label();
			richTextBox1 = new RichTextBox();
			label5 = new Label();
			label6 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label3 = new Label();
			dateTimePicker2 = new DateTimePicker();
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
			panel1.Size = new Size(626, 46);
			panel1.TabIndex = 6;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(336, 37);
			label2.TabIndex = 3;
			label2.Text = "CADASTRO TREINAMENTO";
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
			// textBox2
			// 
			textBox2.Location = new Point(178, 82);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(349, 23);
			textBox2.TabIndex = 13;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(57, 90);
			label4.Name = "label4";
			label4.Size = new Size(42, 15);
			label4.TabIndex = 12;
			label4.Text = "Titulo*";
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(178, 141);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(349, 144);
			richTextBox1.TabIndex = 16;
			richTextBox1.Text = "";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(57, 144);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 15;
			label5.Text = "Descrição*";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(57, 328);
			label6.Name = "label6";
			label6.Size = new Size(97, 15);
			label6.TabIndex = 18;
			label6.Text = "Data de Validade ";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(178, 322);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(249, 23);
			dateTimePicker1.TabIndex = 17;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(57, 379);
			label3.Name = "label3";
			label3.Size = new Size(105, 15);
			label3.TabIndex = 20;
			label3.Text = "Data de Realização";
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(178, 373);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(249, 23);
			dateTimePicker2.TabIndex = 19;
			// 
			// btn_voltar
			// 
			btn_voltar.BackColor = Color.Transparent;
			btn_voltar.Location = new Point(351, 433);
			btn_voltar.Name = "btn_voltar";
			btn_voltar.Size = new Size(75, 40);
			btn_voltar.TabIndex = 23;
			btn_voltar.Text = "Voltar";
			btn_voltar.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(17, 138, 254);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.White;
			button1.Location = new Point(452, 433);
			button1.Name = "button1";
			button1.Size = new Size(75, 40);
			button1.TabIndex = 22;
			button1.Text = " Salvar";
			button1.UseVisualStyleBackColor = false;
			// 
			// CadastrarTreinamento
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(626, 498);
			Controls.Add(btn_voltar);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(dateTimePicker2);
			Controls.Add(label6);
			Controls.Add(dateTimePicker1);
			Controls.Add(richTextBox1);
			Controls.Add(label5);
			Controls.Add(textBox2);
			Controls.Add(label4);
			Controls.Add(panel1);
			Name = "CadastrarTreinamento";
			Text = "CadastrarTreinamento";
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
		private TextBox textBox2;
		private Label label4;
		private RichTextBox richTextBox1;
		private Label label5;
		private Label label6;
		private DateTimePicker dateTimePicker1;
		private Label label3;
		private DateTimePicker dateTimePicker2;
		private Button btn_voltar;
		private Button button1;
	}
}