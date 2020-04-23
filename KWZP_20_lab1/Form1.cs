using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP_20_lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.TextLength > 0)
			{
				btnChange.Text = textBox1.Text;
			}
		}

		private void chcBox1_CheckedChanged(object sender, EventArgs e)
		{
			btnChange.Enabled = chcBox1.Checked;
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
