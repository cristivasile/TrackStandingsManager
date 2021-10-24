using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initializing DB Connection
            CompLibrary.GlobalConfig.InitializeDataConnections(true);
            //Initializing image storage connection
            CompLibrary.GlobalConfig.InitializeImageConnections();
            //Initializing List variables
            CompLibrary.GlobalConfig.InitializeLists();

 
            Application.Run(new VehicleAddForm());
        }


    }
}
