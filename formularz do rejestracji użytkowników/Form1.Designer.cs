namespace formularz_do_rejestracji_użytkowników
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			listView1 = new ListView();
			textbox6 = new TextBox();
			checkBox1 = new CheckBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			button2 = new Button();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			error = new Label();
			SuspendLayout();
			// 
			// listView1
			// 
			listView1.Location = new Point(416, 82);
			listView1.Name = "listView1";
			listView1.Size = new Size(223, 209);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
			// 
			// textbox6
			// 
			textbox6.Location = new Point(128, 223);
			textbox6.Name = "textbox6";
			textbox6.Size = new Size(100, 23);
			textbox6.TabIndex = 3;
			textbox6.TextChanged += textBox3_TextChanged;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(128, 300);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(134, 19);
			checkBox1.TabIndex = 4;
			checkBox1.Text = "akceptuje regulamin";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(128, 55);
			label1.Name = "label1";
			label1.Size = new Size(109, 15);
			label1.TabIndex = 5;
			label1.Text = "nazwa użytkownika";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(128, 121);
			label2.Name = "label2";
			label2.Size = new Size(67, 15);
			label2.TabIndex = 6;
			label2.Text = "adres email";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(128, 195);
			label3.Name = "label3";
			label3.Size = new Size(35, 15);
			label3.TabIndex = 7;
			label3.Text = "hasło";
			// 
			// button1
			// 
			button1.Location = new Point(128, 353);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 8;
			button1.Text = "zapisz";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(256, 353);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 9;
			button2.Text = "usuń";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(128, 153);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 10;
			textBox3.TextChanged += textBox3_TextChanged_1;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(128, 82);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 23);
			textBox4.TabIndex = 11;
			textBox4.TextChanged += textBox4_TextChanged_1;
			// 
			// error
			// 
			error.AutoSize = true;
			error.Location = new Point(306, 175);
			error.Name = "error";
			error.Size = new Size(0, 15);
			error.TabIndex = 12;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(error);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(checkBox1);
			Controls.Add(textbox6);
			Controls.Add(listView1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView listView1;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textbox6;
		private CheckBox checkBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private Button button2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Label error;
	}
}
