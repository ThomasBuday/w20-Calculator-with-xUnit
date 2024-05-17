using System;
using w20_Calculator_with_xUnit;
using Xunit;

namespace Calculator_Test_xUnit
{
    public class CalculatorTests
    {
        private const bool noError = true;

        [Fact]
        public void AddCorrect()
        {
            Calculator calculator = new Calculator();           // Arrange

            double result = (double)calculator.Add(3, 5);       // Act

            Assert.Equal(8, result);                            // Assert
        }

        [Fact]
        public void SubtractCorrect()
        {
            Calculator calculator = new Calculator();           // Arrange

            double result = (double)calculator.Subtract(10, 4); // Act

            Assert.Equal(6, result);                            // Assert
        }

        [Fact]
        public void MultiplyCorrect()
        {
            Calculator calculator = new Calculator();           // Arrange

            double result = (double)calculator.Multiply(2, 3);  // Act

            Assert.Equal(6, result);                            // Assert
        }

        [Fact]
        public void DivideCorrect()
        { 
            Calculator calculator = new Calculator();           // Arrange

            double result = calculator.Divide(10, 2, 1);        // Act

            Assert.Equal(5, result);                            // Assert
        }

        [Fact]
        public void DivideByZeroException()
        {
            Calculator calculator = new Calculator();           // Arrange

            double result = calculator.Divide(10, 0, 1);        // Act

            Assert.Equal(0, result);                            // Assert
        }
    }
}