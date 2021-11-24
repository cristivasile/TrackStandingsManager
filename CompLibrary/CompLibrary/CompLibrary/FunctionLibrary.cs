﻿using System;
using System.Collections.Generic;

namespace CompLibrary
{
    public static class FunctionLibrary
    {

        public static string FirstLetterUpper(this string input)
        {
            return char.ToUpper(input[0]) + input[1..];
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
        /// 
        /// </summary>
        /// <returns> - dictionary with vehicle ids as keys and corresponding indexes in GlobalData.vehicles as values</returns>
        public static Dictionary<int, int> MapVehicleIdsToIndexes()
        {
            Dictionary<int, int> VehicleIdsToIndexes = new();

            for (int Index = 0; Index < GlobalData.Vehicles.Count; Index++)
                VehicleIdsToIndexes[GlobalData.Vehicles[Index].Id] = Index;

            return VehicleIdsToIndexes;
        }


        /// <summary>
        /// Receives a time in seconds and returns a formatted string.
        /// </summary>
        /// <param name="time"> - received time in seconds</param>
        /// <param name="TimingType"> - 0 = SS.mmm, 1 = MM:SS.mmm, 2 = HH:MM:SS.mmm</param>
        /// <returns></returns>
        public static string GetTimeString(double time, int TimingType)
        {
            int hours, minutes, seconds, milliseconds;
            hours = Convert.ToInt32(time / 3600);
            time %= 3600;
            minutes = Convert.ToInt32(time / 60);
            time %= 60;
            seconds = Convert.ToInt32(Math.Floor(time));
            time = (time * 1000) % 1000;
            milliseconds = Convert.ToInt32(time);

            //9 -> 09
            string HoursString = Convert.ToString(hours);
            if (HoursString.Length == 1)
                HoursString = "0" + HoursString;

            string MinutesString = Convert.ToString(minutes);
            if (MinutesString.Length == 1)
                MinutesString = "0" + MinutesString;

            string SecondsString = Convert.ToString(seconds);
            if (SecondsString.Length == 1)
                SecondsString = "0" + SecondsString;

            string MillisecondsString = Convert.ToString(milliseconds);
            while (MillisecondsString.Length < 3)
                MillisecondsString = "0" + MillisecondsString;

            //0 = SS.mmm, 1 = MM:SS.mmm, 2 = HH:MM: SS.mmm 
            if (TimingType == 0)
                return $"{SecondsString}.{MillisecondsString}";
            else if (TimingType == 1)
                return $"{MinutesString}:{SecondsString}.{MillisecondsString}";
            else return $"{HoursString}:{MinutesString}:{SecondsString}.{MillisecondsString}";
        }
    }
}
