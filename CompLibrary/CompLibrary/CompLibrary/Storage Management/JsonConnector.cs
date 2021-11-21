using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace CompLibrary
{
    public class JsonConnector : IDataConnection
    {
        public static readonly string VehiclesFileName = "vehicles.json";
        public static readonly string CategoriesFileName = "categories.json";
        public static readonly string CompetitionsFileName = "competitions.json";
        private static readonly string VehiclesFile = $"{JsonConnectorProcessor.JsonDirectory}\\{VehiclesFileName}";
        private static readonly string CategoriesFile = $"{JsonConnectorProcessor.JsonDirectory}\\{CategoriesFileName}";
        private static readonly string CompetitionsFile = $"{JsonConnectorProcessor.JsonDirectory}\\{CompetitionsFileName}";
        
        public void WriteVehicles()
        {
            VehiclesFile.WriteToFile(GlobalData.Vehicles.GetJsonString());
        }

        public void WriteCategories()
        {

            CategoriesFile.WriteToFile(GlobalData.Categories.GetJsonString());
        }

        public void WriteCompetitions()
        {
            CompetitionsFile.WriteToFile(GlobalData.Competitions.GetJsonString());
        }

        public List<VehicleModel> ReadVehicles()
        {
            VehiclesFile.CreateFileIfNull();
            return VehiclesFile.ReadFromFile().DeserializeData<List<VehicleModel>>();
        }

        public BindingList<string> ReadCategories()
        {
            CategoriesFile.CreateFileIfNull(GlobalConfig.DefaultCategories);
            return CategoriesFile.ReadFromFile().DeserializeData<BindingList<String>>();
        }

        public List<CompetitionModel> ReadCompetitions()
        {
            CompetitionsFile.CreateFileIfNull();
            return CompetitionsFile.ReadFromFile().DeserializeData<List<CompetitionModel>>();
        }

        /// <summary>
        /// Creates a back-up of all JSON files. The app will only keep 5 back-ups at a time.
        /// </summary>
        public void CreateBackup()
        {
            string CurrentBackupDirectory = $"{JsonConnectorProcessor.BackupDirectory}\\{DateTime.Now.ToString("s").TimeFolderFormat()}";
            Directory.CreateDirectory(CurrentBackupDirectory);
            $"{CurrentBackupDirectory}\\{VehiclesFileName}".WriteToFile(GlobalData.Vehicles.GetJsonString());
            $"{CurrentBackupDirectory}\\{CategoriesFileName}".WriteToFile(GlobalData.Categories.GetJsonString());
            $"{CurrentBackupDirectory}\\{CompetitionsFileName}".WriteToFile(GlobalData.Competitions.GetJsonString());

            List<string> BackupDirectories = new (Directory.GetDirectories(JsonConnectorProcessor.BackupDirectory));
            
            //only keep 5 back-ups at a time
            if(BackupDirectories.Count == 6)
            {
                //directories are sorted by date, first directory is oldest
                DirectoryInfo toDelete = new (BackupDirectories[0]);

                //delete all files in directory
                foreach (FileInfo file in toDelete.GetFiles())
                    file.Delete();

                //delete all directories in directory
                foreach (DirectoryInfo directory in toDelete.GetDirectories())
                    directory.Delete();

                toDelete.Delete();
            }

        }

        /// <summary>
        /// If an error is encountered at start up, the JSON files are restored from last backup.
        /// </summary>
        public void RestoreBackup()
        {
            List<string> BackupDirectories = new(Directory.GetDirectories(JsonConnectorProcessor.BackupDirectory));
            string LastBackup = BackupDirectories[^1];

            VehiclesFile.WriteToFile($"{LastBackup}\\{VehiclesFileName}".ReadFromFile());
            CompetitionsFile.WriteToFile($"{LastBackup}\\{CompetitionsFileName}".ReadFromFile());
            CategoriesFile.WriteToFile($"{LastBackup}\\{CategoriesFileName}".ReadFromFile());
        }
    }
}
