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
		private SzwalniaEntities db;
		public Form1()
		{
			InitializeComponent();
			btnChange.Enabled = false;
			db = new SzwalniaEntities();
		}


		private void chcBox1_CheckedChanged(object sender, EventArgs e)
		{
			btnChange.Enabled = chcBox1.Checked;
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			Details details = new Details(db, textBox1.Text);
			details.Show();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
