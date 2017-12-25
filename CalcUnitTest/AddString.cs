using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineCalculator.Models;

namespace CalcUnitTest
{
    [TestClass]
    public class AddString
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            StringCalculation stringCalculation = new StringCalculation();
            string expr = String.Empty;
            int result = stringCalculation.Add(expr);
            Assert.AreEqual(result, 0);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MethodArgumentExceededTest()
        {
            StringCalculation stringCalculation = new StringCalculation();
            string expr = "1,2,3";
            int result = stringCalculation.Add(expr);            
        }

        [TestMethod]
        public void SumTest()
        {
            StringCalculation stringCalculation = new StringCalculation();
            string expr = "1,2";
            int result = stringCalculation.Add(expr);
            Assert.AreEqual(result, 3);

        }

        [TestMethod]
        public void AllowNewlinesBetweenNumbersTest()
        {
            StringCalculation stringCalculation = new StringCalculation();
            string expr = "1\n3";
            int result = stringCalculation.Add(expr);
            Assert.AreEqual(result, 4);

        }
         [TestMethod]
         [ExpectedException(typeof(ArgumentException))]

        public void DoNotAllowNegativeNumbersTest()
        {
            StringCalculation stringCalculation = new StringCalculation();
            string expr = "1,-3";
            int result = stringCalculation.Add(expr);

        }
    }
}
