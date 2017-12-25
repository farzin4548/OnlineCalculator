using NUnit.Framework;
using OnlineCalculator.Models;
using System;
using TechTalk.SpecFlow;

namespace CalcUnitTest
{
    [Binding]
    public class AddSpecTestSteps
    {
        Expression expression = new Expression();
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(float p0)
        {
            expression.Operand1 = p0;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(float p0)
        {
            expression.Operand2 = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            expression.Operators = Operator.ADD;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(float p0)
        {
            Assert.AreEqual(p0, expression.Result);
        }
    }
}
