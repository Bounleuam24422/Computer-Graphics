using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Graphices
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			lab_1_Drawing_graphics lab1Form = new lab_1_Drawing_graphics();
			lab1Form.Show();
		}
	}
}
