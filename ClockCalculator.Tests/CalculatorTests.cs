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
        [TestCase(12, 0)]
        public void Calculator_GetDegrees_WithAfternoonHour_ReturnsCorrectAngle(int hour, int expected)
        {
            // Assemble
            var sut = new Calculator();

            // Act
            var actual = sut.GetDegrees(hour, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 30, 15)]
        [TestCase(12, 30, 165)]
        [TestCase(3, 15, 7.5)]
        public void Calculator_GetDegrees_WithHoursAndMinutes_ReturnsCorrectAngle(int hour, int minute, decimal expected)
        {
            // Assemble
            var sut = new Calculator();

            // Act
            var actual = sut.GetDegrees(hour, minute);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 0)]
        [TestCase(10, 8)]
        public void Calculator_GetDegrees_WithReflexAngleResult_ShouldReturnSmallestAngle(int hour, int minute)
        {
            // Assemble
            var threshold = 180;
            var sut = new Calculator();

            // Act
            var actual = sut.GetDegrees(hour, minute);

            // Assert
            Assert.LessOrEqual(actual, threshold);
        }
    }
}