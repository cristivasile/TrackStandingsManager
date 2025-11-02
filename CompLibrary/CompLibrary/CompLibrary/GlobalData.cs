using System.Collections.Generic;
using System.ComponentModel;

namespace CompLibrary
{
    public static class GlobalData
    {
        public static BindingList<string> Categories { get; private set; } = [];
        public static List<VehicleModel> Vehicles { get; private set; } = [];
        public static List<CompetitionModel> Competitions { get; private set; } = [];

        public static void InitializeLists()
        {
            foreach (IDataConnection storage in GlobalConfig.Connections)
            {
                GlobalData.Categories = storage.ReadCategories();
                GlobalData.Vehicles = storage.ReadVehicles();
                GlobalData.Competitions = storage.ReadCompetitions();
            }
        }
    }
}
