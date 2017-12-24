using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OnlineCalculator.Models;
using Assert = NUnit.Framework.Assert;

namespace CalcUnitTest
{
    [TestFixture]
    public class StoryOneTes
    {
        private Expression expression;
        public void setupTest()
        {
            expression = new Expression();
        }
        [Test()]
        public void WhenPlusTwoOperandResultMustExpected()
        {
            expression.Operand1 = 1;
            expression.Operand2 = 3;
            expression.Operator = Operator.ADD;
            Assert.AreEqual(expression.Result, 5);
        }


    }
}
