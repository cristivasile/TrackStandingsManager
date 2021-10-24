using System;
using System.Collections.Generic;


namespace CompLibrary
{
    public static class GlobalConfig
    {

        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool JSON)
        {
            if (JSON)
            {
                //creates required folders
                JsonConnectorProcessor.CreateJsonDirectories();
                JsonConnector conn = new();
                Connections.Add(conn);
            }
        }

        /// <summary>
        /// Initializes all lists on startup
        /// </summary>
        public static void InitializeLists()
        {
                foreach (IDataConnection storage in GlobalConfig.Connections)
                {
                    GlobalData.Categories = storage.ReadCategories();
                    GlobalData.Vehicles = storage.ReadVehicles();
                }
        }

        /// <summary>
        /// Returns application directory
        /// </summary>
        /// <returns></returns>
        public static string GetAppDirectory()
        {
            return $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\TrackStandingsManager";
        }
    }
}
