using System.Collections.Generic;
using System.ComponentModel;

namespace CompLibrary
{
    public static class GlobalData
    {
        /// <summary>
        /// All categories stored locally
        /// Note: it is binding to work better with combo boxes
        /// </summary>
        public static BindingList<string> Categories { get; set; } = new BindingList<string>();
        /// <summary>
        /// Default values for categories
        /// </summary>
        public static List<string> DefaultCategories { get; set; } = new List<string>()
        {
            "Coupe",
            "Sedan",
            "Cabriolet",
            "Hatchback",
            "Limousine",
            "Minivan",
            "Pickup",
            "Roadster",
            "Wagon",
            "Ute",
            "Suv"
        };
        /// <summary>
        /// vehicles stored locally
        /// </summary>
        public static List<VehicleModel> Vehicles { get; set; } = new List<VehicleModel>();

    }
}
