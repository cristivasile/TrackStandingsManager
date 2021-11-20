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
        /// Unique identifier of a competition;
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        /// The name of a competition.
        /// </summary>
        public string Name{ get; set; }

        /// <summary>
        /// The description of this competition.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The placement type used.
        /// </summary>
        /// <example>
        /// 0 = Timing, 1 = Points
        /// </example>
        public int PlacementType { get; set; }

        /// <summary>
        /// The type of ordering of the leaderboards.
        /// </summary>
        /// <example>
        /// 0 = Ascending, 1 = Descending
        /// </example>
        public int OrderingType{ get; set; }
        /// <summary>
        /// Timing type of competition.
        /// </summary>
        /// <example>
        /// 0 = SS.mmm, 1 = MM:SS.mmm, 2 = HH:MM:SS.mmm, -1 = no timing 
        /// </example>
        public int TimingType { get; set; }

        /// <summary>
        /// Path to where the image is stored on disk
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// List of competitors in the current competition.
        /// </summary>
        public List<CompetitorModel> Competitors { get; set; } = new List<CompetitorModel>();


        public CompetitionModel(string Name, string Description, string ImagePath, int PlacementType, int OrderingType, int TimingType)
        {
            this.Name = Name;
            this.Description = Description;
            this.PlacementType = PlacementType;
            this.OrderingType = OrderingType;
            this.TimingType = TimingType;
            this.ImagePath = ImagePath;
        }
    }
}
