using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
                    // Workaround to preserve data integrity
                    // The proper way to fix this would be to assure data integrity at the source (i.e., the class, using constructors and methods)
                    if (competition.OrderingType == 0)
                    {
                        competition.Competitors = [.. competition.Competitors.OrderBy(c => c.Score)];
                    }
                    else
                    {
                        competition.Competitors = [.. competition.Competitors.OrderByDescending(c => c.Score)];
                    }

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
