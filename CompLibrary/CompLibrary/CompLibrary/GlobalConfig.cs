using CompLibrary.Image_management;
using System;
using System.Collections.Generic;


namespace CompLibrary
{
    public static class GlobalConfig
    {
        
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static IImagesConnection ImageStorage { get; private set; }

        /// <summary>
        /// Initializes data storage connections
        /// </summary>
        public static void InitializeDataConnections(bool JSON)
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
        /// Initializes image storage connections
        /// </summary>
        public static void InitializeImageConnections()
        {
            //creates required folders
            DiskConnectorProcessor.CreateImageDirectories();
            ImageStorage = new DiskConnector();
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

    }
}
