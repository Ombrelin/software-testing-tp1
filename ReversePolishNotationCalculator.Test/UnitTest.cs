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
        public void Compute_TwoTerms_ReturnsRightResult(string expression, double expectedResult)
        {
            // When
            var result = calculator.Compute(expression);
            
            // Then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Compute_UnsupportedOperation_ThrowsException()
        {
            // Given
            var expression = "2 20 ù";

            // When & Then
            Assert.Throws<MalformedExpressionException>(
                () => calculator.Compute(expression)
            );
        }

        [Test]
        [TestCase("1 b +")]
        [TestCase("a 1 +")]
        [TestCase("a b +")]
        public void Compute_OperandAreNotNumber_ThrowsException(string expression)
        {
            // When & Then
            Assert.Throws<MalformedExpressionException>(
                () => calculator.Compute(expression)
            );
        }

        [Test]
        [TestCase("2 1 + 3 *", 9)]
        [TestCase("4 13 5 / +", 6.6d)]
        public void Compute_MultipleOperators_ReturnsRightResult(string expression, double expectedResult)
        {
            // When
            var result = calculator.Compute(expression);
            
            // Then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Compute_UnaryOperator_ReturnsRightResult()
        {
            // Given
            string expression = "4 sqrt";

            // When
            var result = calculator.Compute(expression);

            // Then
            Assert.AreEqual(2, result);
        }
    }
}

