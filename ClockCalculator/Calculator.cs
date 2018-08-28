using System;

namespace ClockCalculator
{
    public class Calculator
    {
        private const int DEGREES_PER_HOUR = 30;

        public int GetDegrees(int hour, int minutes)
        {
            hour = hour % 12;

            var hourPosition = hour * DEGREES_PER_HOUR;

            return hourPosition;
        }
    }
}