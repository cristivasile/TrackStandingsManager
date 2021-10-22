using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

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
                JsonConnectorProcessor.createJsonDirectories();
                JsonConnector conn = new JsonConnector();
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
                    GlobalData.categories = storage.ReadCategories();
                    GlobalData.vehicles = storage.ReadVehicles();
                }
        }

        /// <summary>
        /// Returns application directory
        /// </summary>
        /// <returns></returns>
        public static string getAppDirectory()
        {
            return $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\TrackStandingsManager";
        }
    }
}
