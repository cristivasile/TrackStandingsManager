using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUIWPF
{
    public static partial class Utilities
    {
        /// <summary>
        /// Returns copy image loaded from disk. Used to close image files after load.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Image GetCopyImage(string path)
        {
            using Image img = Image.FromFile(path);
            Bitmap bmp = new(img);
            return bmp;
        }

        /// <summary>
        /// Filters digits from given string
        /// </summary>
        public static string FilterDigits(this string toFilter)
        {
            string FilteredString = "";

            foreach (char character in toFilter)
                if (char.IsDigit(character))
                    FilteredString += character;

            return FilteredString;
        }

        /// <summary>
        /// Adds 0-es at the end of a string until the required length is achieved.
        /// </summary>
        /// <returns></returns>
        public static string PadZeroes(this string toPad, int requiredLength)
        {
            while (toPad.Length != requiredLength)
                toPad += '0';

            return toPad;
        }


        [GeneratedRegex(
            @"^(?:(?<hh>\d{1,2}):(?<mm>\d{1,2}):(?<ss>\d{1,2})|(?<mm>\d{1,2}):(?<ss>\d{1,2})|(?<ss>\d{1,2}))([.,](?<ms>\d{1,3}))$",
            RegexOptions.Compiled)]
        private static partial Regex TimeRgx();

        /// <summary>
        /// Extracts the time in seconds from a string if the format is valid.
        /// Valid formats are: SS.mmm, MM:SS.mmm, HH:MM:SS.mmm
        /// 
        /// <out> The time value in seconds, if valid, using timeInSeconds </out>
        /// <returns> Whether the input string is valid </returns>
        public static bool ExtractTimeIfValid(this string input, out double timeInSeconds)
        {
            timeInSeconds = 0;
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var match = TimeRgx().Match(input.Trim());

            if (match.Success)
            {
                int hh = match.Groups["hh"].Success ? int.Parse(match.Groups["hh"].Value) : 0;
                int mm = match.Groups["mm"].Success ? int.Parse(match.Groups["mm"].Value) : 0;
                int ss = int.Parse(match.Groups["ss"].Value);

                string msText = match.Groups["ms"].Value.Replace(',', '.');
                double ms = double.Parse(msText, System.Globalization.CultureInfo.InvariantCulture);


                if (hh < 0 || hh > 23 || mm < 0 || mm > 59 || ss < 0 || ss > 59 || ms < 0)
                {
                    return false;
                }

                timeInSeconds = hh * 3600 + mm * 60 + ss + (ms / 1000.0);
                return true;
            }

            return false;
        }
    }
}
