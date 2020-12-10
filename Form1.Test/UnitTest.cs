using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Form1.Test
{

    

    [TestClass]
    public class UnitTest1
    {
        CalcSharp.Form1 Test = new CalcSharp.Form1();


        [TestMethod]
        public void Equally_SumOperation_Success()
        {
            //Arrange
            double result = 5;
            string operand = "+";
            string secondvalue = "2";

            double expected = 7;

            //Act
            double actual = Test.Equally(secondvalue, operand, result);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Equally_DivideOperation_Success()
        {
            double result = 20;
            string operand = "/";
            string secondvalue = "4";


            double expected = 5;

            double actual = Test.Equally(secondvalue, operand, result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Equally_MultiplyOperation_Faild()
        {
            double result = 2;
            string operand = "*";
            string secondvalue = "2";


            double expected = 5;

            double actual = Test.Equally(secondvalue, operand, result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sqrt_Check_Success()
        {

            Test.DisplayText.Text = "25";
            double expected = 5;

            double actual = Test.Sqrt(double.Parse(Test.DisplayText.Text));

            Assert.AreEqual(expected, actual);
        }
    }
}
