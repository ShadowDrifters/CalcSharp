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
        public double result;
        public string operand;
        public string firstvalue;
        public string secondvalue;
        public bool point = false;


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

        private void button11_Click(object sender, EventArgs e)
        {
                
            firstvalue = DisplayText.Text;
            DisplayText.Text = "";
            point = false;
            operand = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstvalue = DisplayText.Text;
            DisplayText.Text = "";
            point = false;
            operand = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstvalue = DisplayText.Text;
            DisplayText.Text = "";
            point = false;
            operand = "*";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            firstvalue = DisplayText.Text;
            DisplayText.Text = "";
            point = false;
            operand = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (point == false)
            {
                DisplayText.AppendText(",");
                point = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            secondvalue = DisplayText.Text;
            DisplayText.Text = "";
            switch (operand)
            {
                case "+" :
                    result = double.Parse(firstvalue) + double.Parse(secondvalue);
                    DisplayText.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = double.Parse(firstvalue) - double.Parse(secondvalue);
                    DisplayText.Text = Convert.ToString(result);

                    break;
                case "*":
                    result = double.Parse(firstvalue) * double.Parse(secondvalue);
                    DisplayText.Text = Convert.ToString(result);

                    break;
                case "/":
                    if (secondvalue == "0")
                    {
                        DisplayText.Text = "Деление на 0";
                    }
                    else
                    {
                        result = double.Parse(firstvalue) / double.Parse(secondvalue);
                        DisplayText.Text = Convert.ToString(result);
                    }

                    break;

                default:
                    break;


            }
            


        }

        private void button10_Click(object sender, EventArgs e)
        {
            DisplayText.Text = "";
            operand = "";
            point = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.Match(e.KeyChar.ToString(), @"\/|\*|\-|\+|\=|\,|[0-9]").Success)
            {
                e.Handled = true;
            }
            else
            {
                if (DisplayText.Text == "0")
                {
                    DisplayText.Text = "";
                    DisplayText.Text = e.KeyChar.ToString();
                }
                else DisplayText.AppendText(e.KeyChar.ToString());
            }
        }
    }
}
