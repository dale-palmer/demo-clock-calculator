using System;

namespace ClockCalculator
{
    public static class Calculator
    {
        private const int MINUTES_PER_HOUR = 60;
        private const decimal HOUR_HAND_DEGREES_PER_MINUTE = 0.5M;
        private const int MINUTE_HAND_DEGREES_PER_MINUTE = 6;

        public static decimal GetDegrees(int hour, int minute)
        {
            var minutePosition = GetMinutesPosition(minute);
            var hourPosition = GetHoursPosition(hour, minute);
            return GetAngle(hourPosition, minutePosition);
        }

        private static int GetMinutesPosition(int minute) =>
            minute * MINUTE_HAND_DEGREES_PER_MINUTE;

        private static decimal GetHoursPosition(int hour, int minute)
        {
            var totalMinutes = ((hour %= 12) * MINUTES_PER_HOUR) + minute;
            return totalMinutes * HOUR_HAND_DEGREES_PER_MINUTE;
        }

        private static decimal GetAngle(decimal hourPosition, int minutePosition)
        {
            var angle = Math.Abs(hourPosition - minutePosition);
            return angle > 180 ? angle -= 180 : angle;
        }
    }
}