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
    public class MinusTest
    {
        [TestMethod]
        public void Minus()
        {
            StringCalculation stringCalculation = new StringCalculation();
            string expr ="5,2";
            int result = stringCalculation.Minus(expr);
            Assert.AreEqual(result, 6);

        }

    }
}
