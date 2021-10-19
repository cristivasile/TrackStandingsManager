using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class CompetitionModel
    {
        /// <summary>
        /// The name of a competition.
        /// </summary>
        public string Name{ get; set; }

        /// <summary>
        /// Represents the type of competition evalued.
        /// </summary>
        /// <example>
        ///  0 = Race track, 1 = Extra
        /// </example>
        public bool Type { get; set; }

        /// <summary>
        /// List of competitors in the current competition.
        /// </summary>
        public List<CompetitorModel> Competitors { get; set; } = new List<CompetitorModel>();

        /// <summary>
        /// The description of this competition.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The placement type evalued.
        /// </summary>
        /// <example>
        /// 0 = Timing, 1 = Points
        /// </example>
        public bool PlacementType { get; set; }

        /// <summary>
        /// The type of ordering of the leaderboards.
        /// </summary>
        /// <example>
        /// 0 = Ascending, 1 = Descending
        /// </example>
        public bool OrderingType{ get; set; }
    }
}
