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
        /// Unique identifier of a competitor;
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id of the vehicle that this competitor contains.
        /// </summary>
        public int VehicleId { get; set; }

        /// <summary>
        /// The points of this competitor.
        /// </summary>
        public int Points { get; set; } = 0;

        /// <summary>
        /// The time this competitor achieved in seconds.
        /// </summary>
        public double TimeOnTrack { get; set; }

        /// <summary>
        /// The author of an entry.
        /// </summary>
        public string Author { get; set; } = "Me";
    }
}
