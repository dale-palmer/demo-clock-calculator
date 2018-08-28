using System;

namespace ClockCalculator
{
    public class Calculator
    {
        private const int DEGREES_PER_HOUR = 30;

        public int GetDegrees(int hour, int minutes)
        {
            return hour * DEGREES_PER_HOUR;
        }
    }
}
