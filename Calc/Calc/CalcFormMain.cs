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

        private void btnDigit1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btnDigit2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btnDigit3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btnDigit4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btnDigit5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btnDigit6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btnDigit7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btnDigit8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btnDigit9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btnDigit0_Click(object sender, EventArgs e)
        {
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
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "-";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "/";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "*";
        }
    }
}
