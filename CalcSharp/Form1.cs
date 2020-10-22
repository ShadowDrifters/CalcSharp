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
            //**********************************Горячие клавиши для чисел через лямду*************************************
            //**********************************Это код вместо стандартного ниже******************************************
            //void Form1_KayDawn(object sender, KeyEventArgs e)
            //{
            //   if (e.KeyValue == (char)Keys.NumPud1)
            //  {
            //      button1_click(button1, null);
            //  }
            //
            //}

            //*******************************************************************************************
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad1) button1_Click(button1, null); }; // При нажатии клавиши НумПад1 происходит нажатие на кнопку 1 которая вызывает сому себя (установленное на неё действие)
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad2) button2_Click(button2, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad3) button3_Click(button3, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad4) button4_Click(button4, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad5) button5_Click(button5, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad6) button6_Click(button6, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad7) button7_Click(button7, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad8) button8_Click(button8, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad9) button9_Click(button9, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.NumPad0) button0_Click(button0, null); };

            //**********************************Арифметические знаки*************************************
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Oemplus) button11_Click(button11, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.OemMinus) button12_Click(button12, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Multiply) button13_Click(button13, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Divide) button14_Click(button14, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) button15_Click(button15, null); };

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

  

        /*private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.Match(e.KeyChar.ToString(), @"\/|\*|\-|\+|\=|\,|[0-9]").Success) //Для проверки вводимых символов, 
                                                                                                                        //в данном примере используется метод 
                                                                                                                        //«Regex.Match». Данный метод ищет во 
                                                                                                                        //входящей строке все вхождения заданного 
                                                                                                                        //регулярного выражения. Регулярное выражение 
                                                                                                                        //представляет собой состоящий из символов 
                                                                                                                        //шаблон, обозначающий последовательность 
                                                                                                                        //символов произвольной длины.
            {
                e.Handled = true;                                                                                       //если пользователь ввел нечисло(и не арифметические знаки), и, если да, отменяет KeyPress событие с помощью Handled Свойства.
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
        }*/
    }
}
