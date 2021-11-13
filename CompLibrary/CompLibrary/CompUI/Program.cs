using CompUI.Forms;
using CompUI.Forms.Competition_Branch;
using System;
using System.Windows.Forms;

namespace CompUI
{
    static class Program
    {
        /// <summary>
        /// The program can have only one instance of any form type
        /// </summary>
        public static MainMenuForm MainMenuFormInstance {get; private set; }
        public static VehicleAddForm VehicleAddFormInstance { get; set; }
        public static VehicleUpdateForm VehicleUpdateFormInstance { get; set; }
        public static VehicleManagerForm VehicleManagerFormInstance { get; set; }
        public static RandomChoiceForm RandomChoiceFormInstance { get; set; }
        public static CompetitionManagerForm CompetitionManagerFormInstance { get; set; }
        public static EntryInsertForm EntryInsertFormInstance { get; set; }
        public static NewCompetitionForm NewCompetitionFormInstance { get; set; }
        public static StandingsViewerForm StandingsViewerFormInstance { get; set; }

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
            CompLibrary.GlobalData.InitializeLists();

            MainMenuFormInstance = new MainMenuForm();
            Application.Run(MainMenuFormInstance);
        }
        //TODO - change icon of all forms
    }
}
