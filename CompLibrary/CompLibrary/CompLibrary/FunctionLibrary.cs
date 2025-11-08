using System;
using System.Collections.Generic;

namespace CompLibrary
{
    public static class FunctionLibrary
    {

        /// <summary>
        /// Formats a string so that first letter is uppercase and all others are lowercase.
        /// </summary>
        public static string FirstLetterUpper(this string input)
        {
            string ResultString = "";
            ResultString += char.ToUpper(input[0]);
            for (int Index = 1; Index < input.Length; Index++)
                ResultString += char.ToLower(input[Index]);

            return ResultString;
        }

        /// <summary>
        /// Returns application directory
        /// </summary>
        /// <returns></returns>
        public static string GetAppDirectory()
        {
            return $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\TrackStandingsManager";
        }

        /// <summary>
        /// Replaces any non-digit character with '_'
        /// </summary>
        public static string TimeFolderFormat(this string toFilter)
        {
            string resultString = "";

            foreach (char character in toFilter)
                if (char.IsDigit(character))
                    resultString += character;
                else
                    resultString += '_';

            return resultString;
        }

        /// <summary>
        /// Receives a time in seconds and returns a formatted string.
        /// </summary>
        /// <param name="time"> - received time in seconds</param>
        /// <param name="TimingType"> - 0 = SS.mmm, 1 = MM:SS.mmm, 2 = HH:MM:SS.mmm</param>
        /// <returns></returns>
        public static string GetTimeString(double time)
        {
            int hours = (int)(time / 3600);
            time %= 3600;

            int minutes = (int)(time / 60);
            time %= 60;

            int seconds = (int)Math.Floor(time);
            int milliseconds = (int)Math.Round((time - seconds) * 1000);

            // Handle rounding overflow (e.g., 12.999 → 13.000)
            if (milliseconds == 1000)
            {
                milliseconds = 0;
                seconds++;
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes == 60)
                    {
                        minutes = 0;
                        hours++;
                    }
                }
            }

            // Format parts
            string hh = hours.ToString("00");
            string mm = minutes.ToString("00");
            string ss = seconds.ToString("00");
            string ms = milliseconds.ToString("000");

            // Decide output automatically
            if (hours > 0)
                return $"{hh}:{mm}:{ss}.{ms}";

            if (minutes > 0)
                return $"{mm}:{ss}.{ms}";

            return $"{ss}.{ms}";
        }
    }
}
