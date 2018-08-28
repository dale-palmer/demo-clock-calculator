using NUnit.Framework;
using System;

namespace ClockCalculator.Tests
{
    public class CalculatorTests
    {
        [TestCase(3, 90)]
        [TestCase(6, 180)]
        [TestCase(1, 30)]
        public void Calculator_GetDegrees_OnTheHour_ReturnsCorrectAngle(int hour, int expected)
        {
            // Assemble
            var sut = new Calculator();

            // Act
            var actual = sut.GetDegrees(hour, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 90)]
        [TestCase(18, 180)]
        [TestCase(13, 30)]
        public void Calculator_GetDegrees_WithAfternoonHour_ReturnsCorrectAngle(int hour, int expected)
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