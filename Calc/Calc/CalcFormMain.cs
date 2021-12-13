using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalcFormMain : Form
    {
        public CalcFormMain()
        {
            InitializeComponent();
        }
        double number1 = 0;
        double number2 = 0;
        char znak;
        double result = 0;
        private void btnDigit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";

        }

        private void btnDigit2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";
        }

        private void btnDigit3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";
        }

        private void btnDigit4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";
        }

        private void btnDigit5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";
        }

        private void btnDigit6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void btnDigit7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void btnDigit8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void btnDigit9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void btnDigit0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "+";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = "0";
            znak = '+';
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "-";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = "0";
            znak = '-';
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "/";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = "0";
            znak = '/';
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "*";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = "0";
            znak = '*';
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '^':
                    result = Math.Pow(number1, number2);
                    break;
                case '√':
                    result = Math.Sqrt(number1);
                    break;
            }
            if (number2 == 0 && znak == '/')
            {
                textBox1.Text = "Деление невозможно";
            }
            else
            {
                textBox1.Text = result.ToString();
            }
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "^";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = "0";
            znak = '^';
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "√";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = "0";
            znak = '√';
        }
    }
}
