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
        //TODO - delete entry from competition and update vehicles
        //TODO - delete competition and update vehicles
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
        /// <returns> True if category was inserted, false if it already exists.</returns>
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
        /// <returns> New competition id. </returns>
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
        /// Creates a new competitor in a given competition. The competitor list is sorted. 
        /// </summary>
        /// <param name="CompetitionId"></param>
        /// <param name="NewCompetitor"></param>
        public static void CreateCompetitor(int CompetitionId, CompetitorModel NewCompetitor)
        {
            Dictionary<int, int> VehicleIdsToIndexes = new();

            //Map id's to current index in vehicle list
            for(int i = 0; i < GlobalData.Vehicles.Count; i++)
                VehicleIdsToIndexes[GlobalData.Vehicles[i].Id] = i; 

            foreach(CompetitionModel competition in GlobalData.Competitions)
                if(competition.Id == CompetitionId)
                {
                    int Id = 0;
                    //generate Id
                    foreach (CompetitorModel competitor in competition.Competitors)
                        if (Id <= competitor.Id)
                            Id = competitor.Id + 1;

                    NewCompetitor.Id = Id;

                    int Position = 1;
                    int Index = 0;
                    //check sort type

                    //ascending
                    if(competition.OrderingType == 0)
                        //compute position and Inseration index
                        while(Index < competition.Competitors.Count 
                        && competition.Competitors[Index].Score <= NewCompetitor.Score)
                        {
                            //the new competitor is behind
                            if (competition.Competitors[Index].Score < NewCompetitor.Score)
                                Position = competition.Competitors[Index].Position + 1;
                            //competitors have same position
                            else if (competition.Competitors[Index].Score == NewCompetitor.Score)
                                Position = competition.Competitors[Index].Position;
                            Index++;
                        }
                    else
                        //same code as above, except sort type is descending
                        while (Index < competition.Competitors.Count
                        && competition.Competitors[Index].Score >= NewCompetitor.Score)
                        {
                            //the new competitor is behind
                            if (competition.Competitors[Index].Score > NewCompetitor.Score)
                                Position = competition.Competitors[Index].Position + 1;
                            //competitors have same position
                            else if (competition.Competitors[Index].Score == NewCompetitor.Score)
                                Position = competition.Competitors[Index].Position;
                            Index++;
                        }

                    NewCompetitor.Position = Position;

                    competition.Competitors.Insert(Index, NewCompetitor);

                    //add position and increment NrCompetitions for current vehicle
                    GlobalData.Vehicles[VehicleIdsToIndexes[NewCompetitor.VehicleId]].SumPositions += Position;
                    GlobalData.Vehicles[VehicleIdsToIndexes[NewCompetitor.VehicleId]].NrCompetitions ++;

                    //update position of all competitors that are now behind the new one
                    for (int i = Index + 1; i < competition.Competitors.Count; i++)
                    {
                        competition.Competitors[i].Position = competition.Competitors[i].Position + 1;
                        //add one position to SumPosition of vehicle
                        GlobalData.Vehicles[competition.Competitors[i].VehicleId].SumPositions++;
                    }
                }

            foreach (IDataConnection connection in GlobalConfig.Connections)
            {
                connection.WriteCompetitions();
                connection.WriteVehicles();
            }
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

                    //iterate through competitions and remove current vehicle
                    for (int Index = 0; Index < GlobalData.Competitions.Count; Index++)
                        DeleteVehicleFromCompetition(Index, Id);

                    GlobalData.Vehicles.Remove(vehicle);

                    foreach (IDataConnection storage in GlobalConfig.Connections)
                    {
                        storage.WriteCompetitions();
                        storage.WriteVehicles();
                    }

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Deletes all entries that contain a certain vehicle id. 
        /// </summary>
        /// <param name="competitionIndex"> - current competition Index in GlobalData.competitions list</param>
        public static void DeleteVehicleFromCompetition(int competitionIndex, int vehicleId)
        {
            Dictionary<int, int> VehicleIdsToIndexes = new();

            //Map id's to current index in vehicle list
            for (int i = 0; i < GlobalData.Vehicles.Count; i++)
                VehicleIdsToIndexes[GlobalData.Vehicles[i].Id] = i;

            //remove all entries that contain the vehicle
            for (int index = 0; index < GlobalData.Competitions[competitionIndex].Competitors.Count; index++)
                if (GlobalData.Competitions[competitionIndex].Competitors[index].VehicleId == vehicleId)
                {
                    GlobalData.Competitions[competitionIndex].Competitors.RemoveAt(index);
                    index--;
                }


            //recalculate all positions
            int CurrentPosition = 0;
            double LastScore = -1000000;
            //example : 2 vehicles are tied for 2nd, we want the next one to be 4th
            int toIncrement = 1;

            foreach(CompetitorModel competitor in GlobalData.Competitions[competitionIndex].Competitors)
            {
                if (LastScore != competitor.Score)
                {
                    CurrentPosition += toIncrement;
                    LastScore = competitor.Score;
                    toIncrement = 1;
                }
                else
                {
                    toIncrement++;
                }

                //subtract old position from sum and add new one
                GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]].SumPositions = GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]].SumPositions - competitor.Position + CurrentPosition;

                competitor.Position = CurrentPosition;
            }
        }


        public static VehicleModel GetVehicleById(int Id)
        {
            foreach (VehicleModel vehicle in GlobalData.Vehicles)
                if (vehicle.Id == Id)
                    return vehicle;

            return null;
        }

        public static CompetitionModel GetCompetitionById(int Id)
        {
            foreach (CompetitionModel competition in GlobalData.Competitions)
                if (competition.Id == Id)
                    return competition;
            return null;
        }

    }
}
