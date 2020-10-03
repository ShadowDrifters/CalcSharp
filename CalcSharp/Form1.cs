using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "1";
            else
                DisplayText.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "2";
            else
                DisplayText.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "3";
            else
                DisplayText.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "4";
            else
                DisplayText.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "5";
            else
                DisplayText.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "6";
            else
                DisplayText.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "7";
            else
                DisplayText.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "8";
            else
                DisplayText.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "9";
            else
                DisplayText.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (DisplayText.Text == "0")
                DisplayText.Text = "0";
            else
                DisplayText.AppendText("0");
        }
    }
}
