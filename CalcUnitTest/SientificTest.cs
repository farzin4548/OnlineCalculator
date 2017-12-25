using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcUnitTest
{
    [TestClass]
    public class SientificTest
    {
        [TestMethod]
        public void SinusTest()
        {
            StringCalculation stringCalculation = new StringCalculation();
            string expr = "90";
            double result = stringCalculation.Sinus(expr);
            Assert.AreEqual(result, 1);

        }
    }
}
