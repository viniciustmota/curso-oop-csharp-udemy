﻿using System.Globalization;
namespace System
{
    static internal class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours";
            }
            else if (duration.TotalDays < 365)
            {
                return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days";
            }
            double totalYears = duration.TotalDays / 365;
            return $"{totalYears.ToString("F1", CultureInfo.InvariantCulture)} years";
        }
    }
}
