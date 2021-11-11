using System.Collections.Generic;
using System.ComponentModel;

namespace CompLibrary
{
    //TODO - remove this
    public static class GlobalData
    {
        /// <summary>
        /// All categories stored locally.
        /// Note: it is a binding list to work better with combo boxes
        /// </summary>
        public static BindingList<string> Categories { get; private set; } = new BindingList<string>();
        /// <summary>
        /// Vehicles stored locally.
        /// </summary>
        public static List<VehicleModel> Vehicles { get; private set; } = new List<VehicleModel>();

        public static void InitializeLists()
        {
            foreach (IDataConnection storage in GlobalConfig.Connections)
            {
                GlobalData.Categories = storage.ReadCategories();
                GlobalData.Vehicles = storage.ReadVehicles();
            }
        }
    }
}
