using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class CompetitorModel
    {
        /// <summary>
        /// The vehicle that this competitor is made of.
        /// </summary>
        public VehicleModel Vehicle { get; set; }
        /// <summary>
        /// The points of this competitor.
        /// </summary>
        public int Points { get; set; } = 0;
        /// <summary>
        /// The time this competitor achieved.
        /// </summary>
        public Time TimeOnTrack { get; set; }

        /// <summary>
        /// The author of an entry.
        /// </summary>
        public string Author { get; set; } = "Me";
    }
}
