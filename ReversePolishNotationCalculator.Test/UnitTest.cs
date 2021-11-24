using System;
using NUnit.Framework;

namespace ReversePolishNotationCalculator.Test
{
    public class Tests
    {
        private ReversePolishNotationCalculator calculator;
        
        [SetUp]
        public void Setup()
        {
            calculator  = new ReversePolishNotationCalculator();
        }
        
        [Test]
        [TestCase("2 20 +", 22)]
        [TestCase("2 20 -", -18)]
        [TestCase("2 20 *", 40)]
        [TestCase("2 20 /", .1)]
        public void Compute_TwoTerms_RightResult(string expected, double expectedResult)
        {
            // When
            var result = calculator.Compute(expected);
            
            // Then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Compute_UnsupportedOperation_ThrowsException()
        {
            // Given
            var expression = "2 20 ù";

            // When
            Action a = () => calculator.Compute(expression);
            
            // Then
            Assert.Throws<UnsupportedOperatorExce>()

        }
    }
}

