using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace CompLibrary
{
    public class JsonConnector : IDataConnection
    {
        private readonly string VehiclesFile = "vehicles.json";
        private readonly string CategoriesFile = "categories.json";
        private readonly string CompetitionsFile = "competitions.json";
        
        public void WriteVehicles()
        {
            VehiclesFile.GetFilePath().WriteToFile(GlobalData.Vehicles.GetJsonString());
        }

        public void WriteCategories()
        {

            CategoriesFile.GetFilePath().WriteToFile(GlobalData.Categories.GetJsonString());
        }

        public void WriteCompetitions()
        {
            CompetitionsFile.GetFilePath().WriteToFile(GlobalData.Competitions.GetJsonString());
        }

        public List<VehicleModel> ReadVehicles()
        {
            VehiclesFile.CreateFileIfNull();
            return VehiclesFile.GetFilePath().ReadFromFile().DeserializeData<List<VehicleModel>>();
        }

        public BindingList<string> ReadCategories()
        {
            CategoriesFile.CreateFileIfNull(GlobalConfig.DefaultCategories);
            return CategoriesFile.GetFilePath().ReadFromFile().DeserializeData<BindingList<String>>();
        }

        public List<CompetitionModel> ReadCompetitions()
        {
            CompetitionsFile.CreateFileIfNull();
            return CompetitionsFile.GetFilePath().ReadFromFile().DeserializeData<List<CompetitionModel>>();
        }
    }
}
