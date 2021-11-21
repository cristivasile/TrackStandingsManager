using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary.Storage_Management
{
    public static class CRUD
    {

        /// <summary>
        /// Creates a new vehicle and writes it to all storage solutions.
        /// </summary>
        /// <param name="newVehicle">The vehicle information</param>
        /// <returns>The vehicle information + id</returns>
        public static void CreateVehicle(VehicleModel newVehicle)
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

            //trim spaces from strings
            newVehicle.Brand = newVehicle.Brand.Trim();
            newVehicle.Model = newVehicle.Model.Trim();
            newVehicle.Category = newVehicle.Category.Trim();

            GlobalData.Vehicles.Add(newVehicle);

            foreach (IDataConnection storage in GlobalConfig.Connections)
                storage.WriteVehicles();
        }


        /// <summary>
        /// Creates a new category and writes it to all storage solutions.
        /// </summary>
        /// <param name="newCategory">The category to be inserted</param>
        public static bool CreateCategory(string newCategory)
        {

            //category special formatting: first letter uppercase
            newCategory = newCategory.FirstLetterUpper();

            //search to see if the category already exists
            foreach (string category in GlobalData.Categories)
                //if it does, stop
                if (category == newCategory)
                    return false;

            //otherwise, add it
            GlobalData.Categories.Add(newCategory);

            foreach (IDataConnection storage in GlobalConfig.Connections)
                storage.WriteCategories();

            return true;

        }

        /// <summary>
        /// Creates a new category and saves it to all storage solutions.
        /// </summary>
        public static int CreateCompetition(CompetitionModel newCompetition)
        {
            //if competitions already exist in our list, use last known Id and increment it
            if (GlobalData.Competitions.Count != 0)
            {
                newCompetition.Id = GlobalData.Competitions[^1].Id + 1; // ^1 = last element
            }
            //otherwise, assign 0
            else
            {
                newCompetition.Id = 0;
            }

            //trim spaces from strings
            newCompetition.Name = newCompetition.Name.Trim();
            newCompetition.Description = newCompetition.Description.Trim();

            GlobalData.Competitions.Add(newCompetition);

            foreach (IDataConnection storage in GlobalConfig.Connections)
                storage.WriteCompetitions();

            return newCompetition.Id;
        }

        /// <summary>
        /// Reads all vehicles from first storage solutions.
        /// </summary>
        /// <returns>A list of all vehicles</returns>
        public static List<VehicleModel> ReadVehicles()
        {
            IDataConnection storage = GlobalConfig.Connections[0];
            return storage.ReadVehicles();
        }

        /// <summary>
        /// Reads all categories from first storage solutions.
        /// </summary>
        /// <returns>List of all categories</returns>
        public static BindingList<string> ReadCategories()
        {
            IDataConnection storage = GlobalConfig.Connections[0];
            return storage.ReadCategories();
        }

        /// <summary>
        /// Reads all competitions from first storage solutions.
        /// </summary>
        /// <returns>List of all categories</returns>
        public static List<CompetitionModel> ReadCompetitions()
        {
            IDataConnection storage = GlobalConfig.Connections[0];
            return storage.ReadCompetitions();
        }

        /// <summary>
        /// Updates a vehicle in GlobalData.Vehicles and writes it to all storage solutions.
        /// </summary>
        public static bool UpdateVehicle(VehicleModel updatedvehicle)
        {

            for (int i = 0; i < GlobalData.Vehicles.Count; i++)
                if (GlobalData.Vehicles[i].Id == updatedvehicle.Id)
                {
                    GlobalData.Vehicles[i].Brand = updatedvehicle.Brand.Trim();
                    GlobalData.Vehicles[i].Model = updatedvehicle.Model.Trim();
                    GlobalData.Vehicles[i].Category = updatedvehicle.Category.Trim();
                    GlobalData.Vehicles[i].ImagePath = updatedvehicle.ImagePath;

                    foreach (IDataConnection storage in GlobalConfig.Connections)
                        storage.WriteVehicles();

                    return true;
                }

            return false;
        }

        /// <summary>
        /// Removes a category received as a parameter and updates storage solutions.
        /// </summary>
        /// <param name="toBeDeleted"></param>
        public static bool DeleteCategory(string toBeDeleted)
        {
            // search for the category in the list
            foreach (string category in GlobalData.Categories)
            {

                //if it is found, delete it and update the json file
                if (category.ToLower() == toBeDeleted.ToLower())
                {
                    GlobalData.Categories.Remove(category);
                    foreach (IDataConnection storage in GlobalConfig.Connections)
                        storage.WriteCategories();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Deletes a vehicle with Id given as parameter and updates storage solutions.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static bool DeleteVehicle(int Id)
        {
            string ImagePath;

            foreach (VehicleModel vehicle in GlobalData.Vehicles)
            {
                if (vehicle.Id == Id)
                {
                    ImagePath = vehicle.ImagePath;
                    if (ImagePath != "")
                        File.Delete(ImagePath);

                    //TODO - Delete this vehicle from all competitions
                    GlobalData.Vehicles.Remove(vehicle);

                    foreach (IDataConnection storage in GlobalConfig.Connections)
                        storage.WriteVehicles();

                    return true;
                }
            }

            return false;
        }
    }
}
