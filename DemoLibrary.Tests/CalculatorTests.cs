using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 4, 6)]
        [InlineData(-1, -3, -4)]
        [InlineData(10, 2.34, 12.34)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(-1000, 200, -5)]
        [InlineData(0, 13, 0)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
