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
        /// The points or timing in seconds of this competitor.
        /// </summary>
        public double Score { get; set; } = 0;

        /// <summary>
        /// The author of an entry.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Current position in the competition.
        /// </summary>
        public int Position = 0;

        public CompetitorModel(int VehicleId, double Score, string Author)
        {
            this.VehicleId = VehicleId;
            this.Score = Score;
            this.Author = Author;
        }

    }
}
