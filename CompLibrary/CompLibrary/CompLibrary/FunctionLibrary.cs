using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
