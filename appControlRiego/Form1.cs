using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Fuzzy;


namespace appControlRiego
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			//AForge.Fuzzy
			//InferenceSystem fis = new InferenceSystem(new Database(),new Aforge. InferenceSystemSerializer().Deserialize("ruta/al/archivo.fis"));
			InitializeComponent();
			this.label3.Text = this.trackBar1.Value.ToString();
			this.label4.Text = this.trackBar2.Value.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.label3.Text = this.trackBar1.Value.ToString();
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			this.label4.Text = this.trackBar2.Value.ToString();
		}
	}
}
