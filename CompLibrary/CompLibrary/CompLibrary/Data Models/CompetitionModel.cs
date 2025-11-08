using System.Collections.Generic;

namespace CompLibrary
{
    // TODO - for the love of god use proper enums instead of ints for PlacementType and OrderingType
    public class CompetitionModel(string Name, string Description, string ImagePath, int PlacementType, int OrderingType)
    {
        /// <summary>
        /// Unique identifier of a competition;
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        /// The name of a competition.
        /// </summary>
        public string Name { get; set; } = Name;

        /// <summary>
        /// The description of this competition.
        /// </summary>
        public string Description { get; set; } = Description;

        /// <summary>
        /// The placement type used.
        /// </summary>
        /// <example>
        /// 0 = Timing, 1 = Points
        /// </example>
        public int PlacementType { get; set; } = PlacementType;

        /// <summary>
        /// The type of ordering of the leaderboards.
        /// </summary>
        /// <example>
        /// 0 = Ascending, 1 = Descending
        /// </example>
        public int OrderingType { get; set; } = OrderingType;

        /// <summary>
        /// Path to where the image is stored on disk
        /// </summary>
        public string ImagePath { get; set; } = ImagePath;

        /// <summary>
        /// List of competitors in the current competition.
        /// </summary>
        public List<CompetitorModel> Competitors { get; set; } = [];
    }
}
