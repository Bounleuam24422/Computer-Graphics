namespace Computer_Graphices
{
	partial class Main
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
			groupBox1 = new GroupBox();
			btn1 = new Button();
			GB2 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btn1);
			groupBox1.Location = new Point(65, 29);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(963, 318);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "ບົດເຝິກຫັດ";
			// 
			// btn1
			// 
			btn1.Location = new Point(73, 51);
			btn1.Name = "btn1";
			btn1.Size = new Size(202, 51);
			btn1.TabIndex = 0;
			btn1.Text = "lab 1 Drawing graphics";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += btn1_Click;
			// 
			// GB2
			// 
			GB2.Location = new Point(82, 376);
			GB2.Name = "GB2";
			GB2.Size = new Size(946, 155);
			GB2.TabIndex = 1;
			GB2.TabStop = false;
			GB2.Text = "ວຽກບ້ານ";
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources._8k;
			ClientSize = new Size(1094, 556);
			Controls.Add(GB2);
			Controls.Add(groupBox1);
			Name = "Main";
			Text = "Main";
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox GB2;
		private Button btn1;
	}
}