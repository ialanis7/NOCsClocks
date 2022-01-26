using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOCsClocks
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblEastern.Text = DateTime.Now.AddHours(2).ToString("HH:mm:ss");
			lblCentral.Text = DateTime.Now.AddHours(1).ToString("HH:mm:ss");
			lblMountain.Text = DateTime.Now.ToString("HH:mm:ss");
			lblPacific.Text = DateTime.Now.AddHours(-1).ToString("HH:mm:ss");
			lblArizona.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void lblEastern_Click(object sender, EventArgs e)
		{
				
		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}
	}
}
