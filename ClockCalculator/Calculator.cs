using System;

namespace ClockCalculator
{
    public class Calculator
    {
        private const int MINUTES_PER_HOUR = 60;
        private const decimal HOUR_HAND_DEGREES_PER_MINUTE = 0.5M;
        private const int MINUTE_HAND_DEGREES_PER_MINUTE = 6;

        public decimal GetDegrees(int hour, int minute)
        {
            hour = hour % 12;

            var totalMinutes = (hour * MINUTES_PER_HOUR) + minute;

            var hourPosition = totalMinutes * HOUR_HAND_DEGREES_PER_MINUTE;

            var minutePosition = minute * MINUTE_HAND_DEGREES_PER_MINUTE;

            return Math.Abs(hourPosition - minutePosition);
        }
    }
}