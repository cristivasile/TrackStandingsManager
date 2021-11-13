using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace CompLibrary
{
    public class JsonConnector : IDataConnection
    {
        private readonly string vehiclesFile = "vehicles.json";
        private readonly string categoriesFile = "categories.json";
        /// <summary>
        /// Saves a new vehicle to JSON
        /// </summary>
        /// <param name="newVehicle">The vehicle information</param>
        /// <returns>The vehicle information + id</returns>
        public void CreateVehicle(VehicleModel newVehicle)
        {
            //if vehicles already exist in our list, use last known Id and increment it
            if (GlobalData.Vehicles.Count != 0)
            {
                newVehicle.Id = GlobalData.Vehicles[^1].Id + 1; // ^1 = last element
            }
            //otherwise, assign 0
            else
            {
                newVehicle.Id = 0;
            }
            newVehicle.Brand = newVehicle.Brand.Trim();
            newVehicle.Model = newVehicle.Model.Trim();
            newVehicle.Category = newVehicle.Category.Trim();

            GlobalData.Vehicles.Add(newVehicle);

            vehiclesFile.GetFilePath().WriteToFile(GlobalData.Vehicles.GetJsonString());
        }

        /// <summary>
        /// Reads all vehicles from json.
        /// </summary>
        /// <returns>A list of all vehicles</returns>
        public List<VehicleModel> ReadVehicles()
        {
           vehiclesFile.CreateFileIfNull();
           return vehiclesFile.GetFilePath().ReadFromFile().DeserializeData<List<VehicleModel>>();
        }

        /// <summary>
        /// Creates a new category and saves it to json.
        /// </summary>
        /// <param name="newCategory">The category to be inserted</param>
        public bool CreateCategory(string newCategory)
        {

            //category special formatting: first letter uppercase
            newCategory = newCategory.FirstLetterUpper();

            //search to see if the category already exists
            foreach(string category in GlobalData.Categories)
            //if it does, stop
                if(category == newCategory)
                    return false;

            //otherwise, add it
            GlobalData.Categories.Add(newCategory);
            categoriesFile.GetFilePath().WriteToFile(GlobalData.Categories.GetJsonString());

            return true;

            
        }

        /// <summary>
        /// Reads all categories from local json.
        /// </summary>
        /// <returns>List of all categories</returns>
        public BindingList<string> ReadCategories()
        {
            categoriesFile.CreateFileIfNull(GlobalConfig.DefaultCategories);
            return categoriesFile.GetFilePath().ReadFromFile().DeserializeData<BindingList<String>>();
        }

        /// <summary>
        /// Removes a category received as a parameter
        /// </summary>
        /// <param name="toBeDeleted"></param>
        public bool RemoveCategory(string toBeDeleted)
        {
            // search for the category in the list
            foreach(string category in GlobalData.Categories)
            {

                //if it is found, delete it and update the json file
                if(category.ToLower() == toBeDeleted.ToLower())
                {
                    GlobalData.Categories.Remove(category);
                    categoriesFile.GetFilePath().WriteToFile(GlobalData.Categories.GetJsonString());
                    return true;
                }
            }
            return false;
        }

        public bool RemoveVehicle(int Id)
        {
            string ImagePath;

            foreach(VehicleModel vehicle in GlobalData.Vehicles)
            {
                if (vehicle.Id == Id)
                {
                    ImagePath = vehicle.ImagePath;
                    if(ImagePath != "")
                        File.Delete(ImagePath);

                    //TODO - Delete this vehicle from all competitions
                    GlobalData.Vehicles.Remove(vehicle);
                    vehiclesFile.GetFilePath().WriteToFile(GlobalData.Vehicles.GetJsonString());
                    return true;
                }
            }

            return false;
        }

        public VehicleModel GetVehicleById(int Id)
        {
            foreach(VehicleModel vehicle in GlobalData.Vehicles)
                if (vehicle.Id == Id)
                    return vehicle;

            return null;
        }

        public bool UpdateVehicle(VehicleModel updatedvehicle)
        {

            for (int i = 0; i < GlobalData.Vehicles.Count; i++)
                if (GlobalData.Vehicles[i].Id == updatedvehicle.Id)
                {
                    updatedvehicle.Brand = updatedvehicle.Brand.Trim();
                    updatedvehicle.Model = updatedvehicle.Model.Trim();
                    updatedvehicle.Category = updatedvehicle.Category.Trim();
                    GlobalData.Vehicles[i] = updatedvehicle;
                    vehiclesFile.GetFilePath().WriteToFile(GlobalData.Vehicles.GetJsonString());
                    return true;
                }

            return false;
        }
    }
}
