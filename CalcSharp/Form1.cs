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
        public string cv;
        public string kays;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
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
            operand = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstvalue = DisplayText.Text;
            DisplayText.Text = "";
            operand = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstvalue = DisplayText.Text;
            DisplayText.Text = "";
            operand = "*";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            firstvalue = DisplayText.Text;
            DisplayText.Text = "";
            operand = "/";
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
                    result = double.Parse(firstvalue) / double.Parse(secondvalue);
                    DisplayText.Text = Convert.ToString(result);

                    break;

                default:
                    break;


            }
            


        }

        private void button10_Click(object sender, EventArgs e)
        {

            DisplayText.Text = "";
            operand = "";
        }

        
        
        
        
        // ************************************* Горячие клавиши *********************************************
        
         void Form1_KayDawn(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.NumPad1)
            {
                button1_Click(button1, null);
            }
        }

        void Form1_Two(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad2)
            {
                button2.PerformClick();
            }
        }


         void Form1_Three(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad3)
            {
                button3.PerformClick();
            }
        }



         void Form1_Four(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad4)
            {
                button4.PerformClick();
            }
        }



         void Form1_Five(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad5)
            {
                button5.PerformClick();
            }
        }


         void Form1_Six(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad6)
            {
                button6.PerformClick();
            }
        }


         void Form1_Seven(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad7)
            {
                button7.PerformClick();
            }
        }


         void Form1_Eight(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad8)
            {
                button8.PerformClick();
            }
        }


         void Form1_Nine(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad9)
            {
                button9.PerformClick();
            }
        }


         void Form1_Zero(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                button0.PerformClick();
            }
        }

       








        /*
           switch (kays)
           {
               case "1":
                  if (e.KeyCode == Keys.NumPad1)
                   {
                       button1.PerformClick();
                   };
                   break;

               case "2":
                   if (e.KeyCode == Keys.NumPad2)
                   {
                       button2.PerformClick();
                   };
                   break;

               default:
                   break;
           }
           */

    }
}
