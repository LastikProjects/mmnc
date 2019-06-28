using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmnc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 9 * Math.Pow(10, -28);
            double h = 1.055 * Math.Pow(10, -27);
            double a = Convert.ToDouble(textBox1.Text);
            double U = Convert.ToDouble(textBox2.Text);
            int n = Convert.ToInt32(textBox3.Text);
            double[] x = new double[100*n];
            double[] E = new double[100*n];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                if (a < ((double)i / 100))
                    E[i] = (Math.PI * Math.PI * h * h - 8 * U * m * ((double)i * (double)i / (double)(x.Length*x.Length))) / (8 * m * ((double)i * (double)i / (double)(x.Length*x.Length)));
                else
                    E[i] = (Math.PI * Math.PI * h * h - 8 * U * m * a * a) / (8 * m * a * a);
                chart1.Series[0].Points.AddXY(i / 100, E[i]);
                if (a < (i / 100))
                    E[i] = -U;
                else
                    E[i] = -U;
                chart1.Series[1].Points.AddXY(i / 100, E[i]);
            }
        }
    }
}
