using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OnlineCalculator.Models;

namespace CalcUnitTest
{
    [TestClass]
    public class StoryOneTes
    {
        [TestMethod]
        public void WhenPlusTwoOperandResultMustExpected()
        {
            Expression expression = new Expression();

            expression.Operand1 = 2;
            expression.Operand2 = 3;
            expression.Operator = Operator.ADD;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expression.Result, 5);
        }


    }
}
