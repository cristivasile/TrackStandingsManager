using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class Time
    {
        /// <summary>
        /// Milliseconds of the current Time structure.
        /// </summary>
        public int Milliseconds { get; set; } = 0;

        /// <summary>
        /// Seconds of the current Time structure.
        /// </summary>
        public int Seconds { get; set; } = 0;

        /// <summary>
        /// Minutes of the current Time structure.
        /// </summary>
        public int Minutes { get; set; } = 0;

        /// <summary>
        /// Returns the time calculated in seconds.
        /// </summary>
        /// <returns></returns>
        public double getTimeInSeconds()
        {
            return Convert.ToDouble(Minutes) * 60 + Convert.ToDouble(Seconds) + Convert.ToDouble(Milliseconds) / 1000;
        }
    }
}
