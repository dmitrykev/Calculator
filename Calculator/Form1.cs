using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double plus, minus, multiply, division, equally;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        
        //---------------------------------------------------------
        private void button_0_Click(object sender, EventArgs e)
        {
            label.Text += this.button_0.Text;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            label.Text += this.button_1.Text;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            label.Text += this.button_2.Text;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            label.Text += this.button_3.Text;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            label.Text += this.button_4.Text;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            label.Text += this.button_5.Text;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            label.Text += this.button_6.Text;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            label.Text += this.button_7.Text;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            label.Text += this.button_8.Text;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            label.Text += this.button_9.Text;
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            if(division == 0)
            {
                division += Convert.ToDouble(label.Text);
                label.Text = "";
            }
            else if(division != 0)
            {
                division /= Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if(label.Text == "" || label.Text == "-")
            {
                label.Text = "-";
            }
            else
            {
                minus += Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (multiply == 0)
            {
                multiply += Convert.ToDouble(label.Text);
                label.Text = "";
            }
            else if (multiply != 0)
            {
                multiply /= Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (label.Text != "")
            {
                plus += Convert.ToDouble(label.Text);
            }
            int trigger = label2.Text.IndexOf('=', 0, label2.Text.Length);
            if (trigger != -1)
            {
                label2.Text = "";
            }
            int trigger2 = label2.Text.LastIndexOf('+');
            label2.Text += label.Text;
            if (trigger2 == -1)
            {
                label2.Text += " + ";
            }
            label.Text = "";
        }

        private void button_equally_Click(object sender, EventArgs e)
        {
            label2.Text += label.Text + " =";
            if(plus != 0)
            {
                if (label.Text != "")
                {
                    equally = Convert.ToDouble(label.Text);
                }
                label.Text = Convert.ToString(plus + equally);
                
                
            }
            else if(minus != 0)
            {
                equally = Convert.ToDouble(label.Text);
                label.Text = Convert.ToString(minus - equally);
            }
            else if(multiply > 1)
            {
                equally = Convert.ToDouble(label.Text);
                label.Text = Convert.ToString(multiply * equally);
            }
            else if(division != 0)
            {
                equally = Convert.ToDouble(label.Text);
                label.Text = Convert.ToString(division / equally);
            }
            plus = minus = division = equally = multiply = 0;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            plus = minus = division = equally = multiply = 0;
            label.Text = "";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            label.Text += this.button_dot.Text;
        }
    }
}
