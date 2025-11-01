namespace EpiControl.Views.Emprestimo
{
	partial class CadastrarEmprestimo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEmprestimo));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label3 = new Label();
			comboBox1 = new ComboBox();
			label4 = new Label();
			label6 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label5 = new Label();
			dateTimePicker2 = new DateTimePicker();
			comboBox3 = new ComboBox();
			label8 = new Label();
			label7 = new Label();
			button1 = new Button();
			numericUpDown1 = new NumericUpDown();
			treeView1 = new TreeView();
			button2 = new Button();
			btn_voltar = new Button();
			label9 = new Label();
			checkBox1 = new CheckBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
			panel1.Size = new Size(608, 46);
			panel1.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(57, 4);
			label2.Name = "label2";
			label2.Size = new Size(319, 37);
			label2.TabIndex = 3;
			label2.Text = "CADASTRO EMPRÉSTIMO";
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
			label3.Location = new Point(59, 83);
			label3.Name = "label3";
			label3.Size = new Size(128, 15);
			label3.TabIndex = 8;
			label3.Text = "Nome do Funcionario*";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(211, 80);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(249, 23);
			comboBox1.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(59, 259);
			label4.Name = "label4";
			label4.Size = new Size(74, 15);
			label4.TabIndex = 10;
			label4.Text = "Quantidade*";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(59, 134);
			label6.Name = "label6";
			label6.Size = new Size(120, 15);
			label6.TabIndex = 20;
			label6.Text = "Data do Empréstimo*";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(211, 128);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(249, 23);
			dateTimePicker1.TabIndex = 19;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(57, 303);
			label5.Name = "label5";
			label5.Size = new Size(106, 15);
			label5.TabIndex = 23;
			label5.Text = "Data de Devolução";
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(209, 297);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(249, 23);
			dateTimePicker2.TabIndex = 22;
			// 
			// comboBox3
			// 
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(211, 215);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(249, 23);
			comboBox3.TabIndex = 26;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(59, 218);
			label8.Name = "label8";
			label8.Size = new Size(28, 15);
			label8.TabIndex = 25;
			label8.Text = "EPI*";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(-32, 178);
			label7.Name = "label7";
			label7.Size = new Size(697, 15);
			label7.TabIndex = 51;
			label7.Text = "__________________________________________________________________________________________________________________________________________";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(136, 186, 163);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(483, 297);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 52;
			button1.Text = "Adicionar";
			button1.UseVisualStyleBackColor = false;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(211, 259);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(50, 23);
			numericUpDown1.TabIndex = 53;
			// 
			// treeView1
			// 
			treeView1.Location = new Point(57, 374);
			treeView1.Name = "treeView1";
			treeView1.Size = new Size(499, 118);
			treeView1.TabIndex = 54;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(17, 138, 254);
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = Color.White;
			button2.Location = new Point(483, 502);
			button2.Name = "button2";
			button2.Size = new Size(75, 40);
			button2.TabIndex = 72;
			button2.Text = " Salvar";
			button2.UseVisualStyleBackColor = false;
			// 
			// btn_voltar
			// 
			btn_voltar.BackColor = Color.Transparent;
			btn_voltar.Location = new Point(402, 502);
			btn_voltar.Name = "btn_voltar";
			btn_voltar.Size = new Size(75, 40);
			btn_voltar.TabIndex = 71;
			btn_voltar.Text = "Voltar";
			btn_voltar.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(251, 356);
			label9.Name = "label9";
			label9.Size = new Size(125, 15);
			label9.TabIndex = 73;
			label9.Text = "Itens para Emprestimo";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(466, 217);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(133, 19);
			checkBox1.TabIndex = 74;
			checkBox1.Text = "Recomendar por NR";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// CadastrarEmprestimo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(608, 551);
			Controls.Add(checkBox1);
			Controls.Add(label9);
			Controls.Add(button2);
			Controls.Add(btn_voltar);
			Controls.Add(treeView1);
			Controls.Add(numericUpDown1);
			Controls.Add(button1);
			Controls.Add(label7);
			Controls.Add(comboBox3);
			Controls.Add(label8);
			Controls.Add(label5);
			Controls.Add(dateTimePicker2);
			Controls.Add(label6);
			Controls.Add(dateTimePicker1);
			Controls.Add(label4);
			Controls.Add(comboBox1);
			Controls.Add(label3);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "CadastrarEmprestimo";
			Text = "EPICONTROL";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label3;
		private ComboBox comboBox1;
		private Label label4;
		private Label label6;
		private DateTimePicker dateTimePicker1;
		private Label label5;
		private DateTimePicker dateTimePicker2;
		private ComboBox comboBox3;
		private Label label8;
		private Label label7;
		private Button button1;
		private NumericUpDown numericUpDown1;
		private TreeView treeView1;
		private Button button2;
		private Button btn_voltar;
		private Label label9;
		private CheckBox checkBox1;
	}
}