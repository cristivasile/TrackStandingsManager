using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class JsonConnector : IDataConnection
    {
        string vehiclesFile = "vehicles.json";
        string categoriesFile = "categories.json";
        /// <summary>
        /// Saves a new vehicle to JSON
        /// </summary>
        /// <param name="newVehicle">The vehicle information</param>
        /// <returns>The vehicle information + id</returns>
        public VehicleModel CreateVehicle(VehicleModel newVehicle)
        {
            newVehicle.Id = GlobalData.vehicles.Count();
            GlobalData.vehicles.Add(newVehicle);

            string writeToFile = JsonConvert.SerializeObject(GlobalData.vehicles);
            File.WriteAllText(vehiclesFile.GetFilePath(), writeToFile);

            return newVehicle;
        }

        /// <summary>
        /// Reads all vehicles from json.
        /// </summary>
        /// <returns>A list of all vehicles</returns>
        public List<VehicleModel> ReadVehicles()
        {
           CompLibrary.JsonConnectorProcessor.createFileIfNull(vehiclesFile);
           string readFromFile = File.ReadAllText(vehiclesFile.GetFilePath());
           return JsonConvert.DeserializeObject<List<VehicleModel>>(readFromFile);
        }

        /// <summary>
        /// Creates a new category and saves it to json.
        /// </summary>
        /// <param name="newCategory">The category to be inserted</param>
        public bool CreateCategory(string newCategory)
        {

            //category special formatting: first letter uppercase
            newCategory = newCategory.firstLetterUpper();

            //we search to see if the category already exists
            foreach(string category in GlobalData.categories)
            //if it does, we stop
                if(category == newCategory)
                    return false;

            //otherwise, we add it
            GlobalData.categories.Add(newCategory);

            string WriteToFile = JsonConvert.SerializeObject(GlobalData.categories);
            File.WriteAllText(categoriesFile.GetFilePath(), WriteToFile);
            return true;

            
        }

        /// <summary>
        /// Reads all categories from local json.
        /// </summary>
        /// <returns>List of all categories</returns>
        public BindingList<string> ReadCategories()
        {
            CompLibrary.JsonConnectorProcessor.createFileIfNull(categoriesFile, GlobalData.defaultCategories);
            string readFromFile = File.ReadAllText(categoriesFile.GetFilePath());
            return JsonConvert.DeserializeObject<BindingList<String>>(readFromFile);
        }

        /// <summary>
        /// Removes a category received as a parameter
        /// </summary>
        /// <param name="toBeDeleted"></param>
        public bool RemoveCategory(string toBeDeleted)
        {
            // we search for the category in the list
            foreach(string category in GlobalData.categories)
            {

                //if we find it, we delete it and update the json file
                if(category == toBeDeleted.ToLower())
                {
                    GlobalData.categories.Remove(category);

                    string WriteToFile = JsonConvert.SerializeObject(GlobalData.categories);
                    File.WriteAllText(categoriesFile.GetFilePath(), WriteToFile);

                    return true;
                }
            }
            return false;
        }
    }
}
