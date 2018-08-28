using NUnit.Framework;
using System;

namespace ClockCalculator.Tests
{
    public class CalculatorTests
    {
        [TestCase(3, 90)]
        [TestCase(6, 180)]
        public void Calculator_GetDegrees_OnTheHour_ReturnsCorrectAngle(int hour, int expected)
        {
            // Assemble
            var sut = new Calculator();

            // Act
            var actual = sut.GetDegrees(hour, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
