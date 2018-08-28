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
            var minutePosition = GetMinutesPosition(minute);
            var hourPosition = GetHoursPosition(hour, minute);

            return GetAngle(hourPosition, minutePosition);
        }

        private int GetMinutesPosition(int minute) =>
            minute * MINUTE_HAND_DEGREES_PER_MINUTE;

        private decimal GetHoursPosition(int hour, int minute)
        {
            hour = hour % 12;
            var totalMinutes = (hour * MINUTES_PER_HOUR) + minute;
            return totalMinutes * HOUR_HAND_DEGREES_PER_MINUTE;
        }

        private decimal GetAngle(decimal hourPosition, int minutePosition)
        {
            var angle = Math.Abs(hourPosition - minutePosition);

            if (angle > 180)
                angle -= 180;

            return angle;
        }
    }
}