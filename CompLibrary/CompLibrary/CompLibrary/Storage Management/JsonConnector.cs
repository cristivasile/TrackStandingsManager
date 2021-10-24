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
        public void CreateVehicle(VehicleModel newVehicle)
        {
            //if vehicles already exist we can use last known Id and increment it
            if (GlobalData.vehicles.Count() != 0)
            {
                newVehicle.Id = GlobalData.vehicles[GlobalData.vehicles.Count() - 1].Id + 1;
            }
            //otherwise, we assign 0
            else
            {
                newVehicle.Id = 0;
            }
            GlobalData.vehicles.Add(newVehicle);

            vehiclesFile.getFilePath().writeToFile(GlobalData.vehicles.getJsonString());
        }

        /// <summary>
        /// Reads all vehicles from json.
        /// </summary>
        /// <returns>A list of all vehicles</returns>
        public List<VehicleModel> ReadVehicles()
        {
           vehiclesFile.createFileIfNull();
           return vehiclesFile.getFilePath().readFromFile().deserializeData<List<VehicleModel>>();
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
            categoriesFile.getFilePath().writeToFile(GlobalData.categories.getJsonString());

            return true;

            
        }

        /// <summary>
        /// Reads all categories from local json.
        /// </summary>
        /// <returns>List of all categories</returns>
        public BindingList<string> ReadCategories()
        {
            categoriesFile.createFileIfNull(GlobalData.defaultCategories);
            return categoriesFile.getFilePath().readFromFile().deserializeData<BindingList<String>>();
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
                if(category.ToLower() == toBeDeleted.ToLower())
                {
                    GlobalData.categories.Remove(category);
                    categoriesFile.getFilePath().writeToFile(GlobalData.categories.getJsonString());
                    return true;
                }
            }
            return false;
        }
    }
}
