using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class CompetitorModel(int VehicleId, double Score, string Author)
    {
        /// <summary>
        /// Unique identifier of a competitor;
        /// </summary>
        public int Id { get; set; } = -1;

        /// <summary>
        /// The id of the vehicle that this competitor contains.
        /// </summary>
        public int VehicleId { get; set; } = VehicleId;

        /// <summary>
        /// The points or timing in seconds of this competitor.
        /// </summary>
        public double Score { get; set; } = Score;

        /// <summary>
        /// The author of an entry.
        /// </summary>
        public string Author { get; set; } = Author;
        /// <summary>
        /// Current position in the competition.
        /// </summary>
        public int Position = 0;
    }
}
