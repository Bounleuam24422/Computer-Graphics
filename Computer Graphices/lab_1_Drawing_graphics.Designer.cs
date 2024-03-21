namespace Computer_Graphices
{
	partial class lab_1_Drawing_graphics
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
			button1 = new Button();
			btnDraw = new Button();
			btnColor = new Button();
			numericUpDown1 = new NumericUpDown();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(628, 96);
			button1.Name = "button1";
			button1.Size = new Size(121, 42);
			button1.TabIndex = 0;
			button1.Text = "Delete";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// btnDraw
			// 
			btnDraw.Location = new Point(628, 38);
			btnDraw.Name = "btnDraw";
			btnDraw.Size = new Size(121, 42);
			btnDraw.TabIndex = 0;
			btnDraw.Text = "Draw";
			btnDraw.UseVisualStyleBackColor = true;
			btnDraw.Click += btnDraw_Click;
			// 
			// btnColor
			// 
			btnColor.Location = new Point(628, 226);
			btnColor.Name = "btnColor";
			btnColor.Size = new Size(121, 42);
			btnColor.TabIndex = 0;
			btnColor.UseVisualStyleBackColor = true;
			btnColor.Click += btnColor_Click;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(628, 174);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(121, 27);
			numericUpDown1.TabIndex = 1;
			numericUpDown1.Value = new decimal(new int[] { 9, 0, 0, 0 });
			numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(559, 176);
			label1.Name = "label1";
			label1.Size = new Size(63, 20);
			label1.TabIndex = 2;
			label1.Text = "Pen Size";
			// 
			// Exersice1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Controls.Add(numericUpDown1);
			Controls.Add(btnColor);
			Controls.Add(btnDraw);
			Controls.Add(button1);
			Name = "Exersice1";
			Text = "Form1";
			Paint += Exersice1_Paint;
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button btnDraw;
		private Button btnColor;
		private NumericUpDown numericUpDown1;
		private Label label1;
	}
}