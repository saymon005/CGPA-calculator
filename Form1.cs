using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPACALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9,tb10, tb11, tb12, tb13, tb14, tb15, tb16, tb17, tb18, total, mul, cgpa;

            tb1 = double.Parse(textBox1.Text);
            tb2 = double.Parse(textBox2.Text);
            tb3 = double.Parse(textBox3.Text);
            tb4 = double.Parse(textBox4.Text);
            tb5 = double.Parse(textBox5.Text);
            tb6 = double.Parse(textBox6.Text);
            tb7 = double.Parse(textBox7.Text);
            tb8 = double.Parse(textBox8.Text);
            tb9 = double.Parse(textBox9.Text);

            tb10 = double.Parse(textBox10.Text);
            tb11 = double.Parse(textBox11.Text);
            tb12 = double.Parse(textBox12.Text);
            tb13 = double.Parse(textBox13.Text);
            tb14 = double.Parse(textBox14.Text);
            tb15 = double.Parse(textBox15.Text);
            tb16 = double.Parse(textBox16.Text);
            tb17 = double.Parse(textBox17.Text);
            tb18 = double.Parse(textBox18.Text);

            total = (tb1 + tb2 + tb3 + tb4 + tb5 + tb6 + tb7 + tb8);

            mul = ((tb1 * tb10) + (tb2 * tb11) + (tb3 * tb12) + (tb4 * tb13) + (tb5 * tb14) + (tb6 * tb15) + (tb7 * tb16) + (tb8 * tb17) + (tb9*tb18));

            cgpa = mul / total;

            textcgpa.Text = cgpa.ToString("0.####");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control c in groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = " ";
                }
            }
        }
    }
}
