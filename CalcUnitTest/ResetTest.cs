using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineCalculator.Models;

namespace CalcUnitTest
{
    [TestClass]
    public class ResetTest
    {
        private Expression expression;

        [TestInitialize()]
        public void setupTest()
        {
            expression = new Expression();
        }
        [TestMethod()]
        public void WhenReset()
        {
            expression.Reset();
            Assert.AreEqual(expression.Result, 0);
            Assert.AreEqual(expression.Operand1,0);
            Assert.AreEqual(expression.Operand2, 0);
        }
    }
}
