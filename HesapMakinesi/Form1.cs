using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int firstnumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "3";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnnull_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            firstnumber = int.Parse(textBox1.Text);
            textBox1.Text = null;
            operation = "+";
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            firstnumber = int.Parse(textBox1.Text);
            textBox1.Text = null;
            operation = "-";
        }

        private void btnesittir_Click(object sender, EventArgs e)
        {
            int secondnumbner;
            int result;
            secondnumbner = int.Parse(textBox1.Text);

            if(operation == "+")
            {
                result = firstnumber + secondnumbner;
                textBox1.Text = Convert.ToString(result);
            }
            else if(operation == "-")
            {
                result = firstnumber - secondnumbner;
                textBox1.Text = Convert.ToString(result);
            }
        }
    }
}
