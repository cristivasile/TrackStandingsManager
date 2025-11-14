using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class CompetitorModel(int vehicleId, double score, DateTime dt)
    {
        /// <summary>
        /// Unique identifier of a competitor;
        /// </summary>
        public int Id { get; set; } = -1;

        /// <summary>
        /// The id of the vehicle that this competitor contains.
        /// </summary>
        public int VehicleId { get; set; } = vehicleId;

        /// <summary>
        /// The points or timing in seconds of this competitor.
        /// </summary>
        public double Score { get; set; } = score;

        /// <summary>
        /// Current position in the competition.
        /// </summary>
        public int Position = 0;

        /// <summary>
        /// Timestamp when the competitor entry was created or recorded.
        /// </summary>
        public DateTime Timestamp { get; set; } = dt;

        public CompetitorModel Clone()
        {
            return new CompetitorModel(this.VehicleId, this.Score, this.Timestamp)
            {
                Id = this.Id,
                Position = this.Position,
            };
        }
    }
}
