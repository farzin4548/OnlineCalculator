
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineCalculator.Models;


namespace CalcUnitTest
{
    [TestClass]
    public class StoryOneTes
    {
        private Expression expression;

        [TestInitialize()]
        public void setupTest()
        {
            expression = new Expression();
        }
        [TestMethod()]
        public void WhenPlus()
        {
            expression.Operand1 = 1;
            expression.Operand2 = 3;
            expression.Operators = Operator.ADD;
            Assert.AreEqual(expression.Result, 4);
        }

        [TestMethod]
        public void WhenConvertUSDoGBPUnitTimesRate()
        {
            //arrange      
            var vSDGBPExchangeRateFeedMock = new Mock<IUSDGBPExchangeRateFeed>();
            vSDGBPExchangeRateFeedMock.Setup(a => a.GetGBPRate()).Returns(500);
            var usdValue = 2;
            //act
            var expression = new Expression(vSDGBPExchangeRateFeedMock.Object);
            var resullt = expression.ConvertUSDtoGBP(usdValue);
            //assert
            var expected = 500;
            Assert.AreEqual(expected, resullt);
        }

    }
}
