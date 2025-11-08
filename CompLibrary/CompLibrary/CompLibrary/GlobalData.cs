using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CompLibrary
{
    public static class GlobalData
    {
        public static BindingList<string> Categories { get; private set; } = [];
        public static Dictionary<int, VehicleModel> Vehicles { get; private set; } = [];
        public static List<CompetitionModel> Competitions { get; private set; } = [];

        public static void InitializeLists()
        {
            foreach (IDataConnection storage in GlobalConfig.Connections)
            {
                GlobalData.Categories = storage.ReadCategories();
                foreach (var vehicle in storage.ReadVehicles())
                {
                    GlobalData.Vehicles[vehicle.Id] = vehicle;
                }
                GlobalData.Competitions = storage.ReadCompetitions();

                foreach (var competition in GlobalData.Competitions)
                {
                    foreach (var competitor in competition.Competitors)
                    {
                        if (competitor.Timestamp == DateTime.MinValue || competitor.Timestamp == default)
                            competitor.Timestamp = DateTime.Now;
                    }
                }
            }
        }
    }
}
