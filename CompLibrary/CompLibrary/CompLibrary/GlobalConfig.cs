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
        /// Default values for categories
        /// </summary>
        public static List<string> DefaultCategories { get; private set; } = new List<string>()
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

        public static List<string> DefaultTimings { get; private set; } = new List<string>()
        {
            "SS.mmm",
            "MM:SS.mmm",
            "HH:MM:SS.mmm"
        };
    }
}
