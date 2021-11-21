using CompUI.Forms;
using CompUI.Forms.Competition_Branch;
using System;
using System.Windows.Forms;

namespace CompUI
{
    static class Program
    {
        //TODO - submit/update/etc on enter keypress
        //TODO - organize code better
        /// <summary>
        /// The program can have only one instance of any form type
        /// </summary>
        public static MainMenuForm MainMenuFormInstance { get; private set; }
        public static VehicleAddForm VehicleAddFormInstance { get; set; }
        public static VehicleUpdateForm VehicleUpdateFormInstance { get; set; }
        public static VehicleManagerForm VehicleManagerFormInstance { get; set; }
        public static RandomChoiceForm RandomChoiceFormInstance { get; set; }
        public static CompetitionManagerForm CompetitionManagerFormInstance { get; set; }
        public static EntryInsertForm EntryInsertFormInstance { get; set; }
        public static CompetitionAddForm CompetitionAddFormInstance { get; set; }
        public static FilterForm FilterFormInstance { get; set; }

        /// <summary>
        /// Used for alerting the user that a read error was encountered.
        /// </summary>
        public static bool ReadErrorEncountered = false;

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

            try
            {
                //Initializing List variables
                CompLibrary.GlobalData.InitializeLists();
            }
            catch
            {
                CompLibrary.GlobalConfig.RestoreBackup();
                ReadErrorEncountered = true;
                CompLibrary.GlobalData.InitializeLists();
            }
            
            //If the program got to this point a data back-up is created
            CompLibrary.GlobalConfig.CreateBackup();

            MainMenuFormInstance = new MainMenuForm();
            Application.Run(MainMenuFormInstance);
        }
        //TODO - change icon and names of all forms
        //TODO - Make forms responsive to resizing
    }
}
