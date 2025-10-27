namespace EpiControl
{
	partial class backup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backup));
			panel2 = new Panel();
			button4 = new Button();
			button2 = new Button();
			button3 = new Button();
			button5 = new Button();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.Gray;
			panel2.Controls.Add(button4);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(button3);
			panel2.Controls.Add(button5);
			panel2.Location = new Point(300, 110);
			panel2.Margin = new Padding(0);
			panel2.Name = "panel2";
			panel2.RightToLeft = RightToLeft.No;
			panel2.Size = new Size(200, 230);
			panel2.TabIndex = 5;
			// 
			// button4
			// 
			button4.BackColor = Color.Gray;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Image = (Image)resources.GetObject("button4.Image");
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(7, 56);
			button4.Name = "button4";
			button4.Size = new Size(205, 54);
			button4.TabIndex = 6;
			button4.Text = "Cadastrar";
			button4.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(64, 64, 64);
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(0, 0);
			button2.Name = "button2";
			button2.Size = new Size(220, 54);
			button2.TabIndex = 2;
			button2.Text = "EPI";
			button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			button3.BackColor = Color.Gray;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Image = (Image)resources.GetObject("button3.Image");
			button3.ImageAlign = ContentAlignment.MiddleLeft;
			button3.Location = new Point(7, 112);
			button3.Name = "button3";
			button3.Size = new Size(205, 54);
			button3.TabIndex = 5;
			button3.Text = "Alterar";
			button3.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			button5.BackColor = Color.Gray;
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(7, 168);
			button5.Name = "button5";
			button5.Size = new Size(205, 54);
			button5.TabIndex = 6;
			button5.Text = "Excluir";
			button5.UseVisualStyleBackColor = false;
			// 
			// backup
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel2);
			Name = "backup";
			Text = "backup";
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Button button4;
		private Button button2;
		private Button button3;
		private Button button5;
	}
}