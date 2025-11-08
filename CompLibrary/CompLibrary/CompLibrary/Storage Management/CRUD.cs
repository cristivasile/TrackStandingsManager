using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

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
            int maxId = 0;
            foreach (var pair in GlobalData.Vehicles)
            {
                if (pair.Key >= maxId)
                    maxId = pair.Key + 1;
            }
            newVehicle.Id = maxId;

            //trim spaces from strings
            newVehicle.Brand = newVehicle.Brand.Trim();
            newVehicle.Model = newVehicle.Model.Trim();
            newVehicle.Category = newVehicle.Category.Trim().FirstLetterUpper();

            GlobalData.Vehicles[newVehicle.Id] = newVehicle;

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
        public static void CreateCompetition(CompetitionModel newCompetition)
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
        }

        /// <summary>
        /// Creates a new competitor in a given competition. The competitor list is sorted. 
        /// </summary>
        /// <param name="CompetitionId"></param>
        /// <param name="NewCompetitor"></param>
        public static void CreateCompetitor(int CompetitionId, CompetitorModel NewCompetitor)
        {
            foreach(CompetitionModel competition in GlobalData.Competitions)
                if(competition.Id == CompetitionId)
                {
                    //generate Id if it has default value. if it does not, this was called from UpdateCompetitor
                    if (NewCompetitor.Id == -1)
                    {
                        int Id = 0;
                        foreach (CompetitorModel competitor in competition.Competitors)
                            if (Id <= competitor.Id)
                                Id = competitor.Id + 1;

                        NewCompetitor.Id = Id;
                    }

                    int Position = 1;
                    int Index = 0;
                    //check sort type

                    //ascending
                    if(competition.OrderingType == 0)
                        // Compute position and Insertion index
                        while(Index < competition.Competitors.Count 
                        && competition.Competitors[Index].Score <= NewCompetitor.Score)
                        {
                            // The new competitor is behind
                            if (competition.Competitors[Index].Score < NewCompetitor.Score)
                                Position = competition.Competitors[Index].Position + 1;
                            // Competitors have same position
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
                    GlobalData.Vehicles[NewCompetitor.VehicleId].SumPositions += Position;
                    GlobalData.Vehicles[NewCompetitor.VehicleId].NrCompetitions ++;

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
        /// Reads all vehicles from first storage solution.
        /// </summary>
        /// <returns>A list of all vehicles</returns>
        public static List<VehicleModel> ReadVehicles()
        {
            IDataConnection storage = GlobalConfig.Connections[0];
            return storage.ReadVehicles();
        }

        /// <summary>
        /// Reads all categories from first storage solution.
        /// </summary>
        /// <returns>List of all categories</returns>
        public static BindingList<string> ReadCategories()
        {
            IDataConnection storage = GlobalConfig.Connections[0];
            return storage.ReadCategories();
        }

        /// <summary>
        /// Reads all competitions from first storage solution.
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
        public static bool UpdateVehicle(VehicleModel updatedVehicle)
        {

            for (int i = 0; i < GlobalData.Vehicles.Count; i++)
                if (GlobalData.Vehicles[i].Id == updatedVehicle.Id)
                {
                    GlobalData.Vehicles[i].Brand = updatedVehicle.Brand.Trim();
                    GlobalData.Vehicles[i].Model = updatedVehicle.Model.Trim();
                    GlobalData.Vehicles[i].Category = updatedVehicle.Category.Trim().FirstLetterUpper();
                    GlobalData.Vehicles[i].ImagePath = updatedVehicle.ImagePath;

                    foreach (IDataConnection storage in GlobalConfig.Connections)
                        storage.WriteVehicles();

                    return true;
                }

            return false;
        }

        /// <summary>
        /// Updates a competitor by deleting and re-inserting.
        /// </summary>
        public static void UpdateCompetitor(int CompetitionId, CompetitorModel ToUpdate)
        {
            DeleteCompetitor(CompetitionId, ToUpdate.Id);
            CreateCompetitor(CompetitionId, ToUpdate);
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
                if (category.Equals(toBeDeleted, System.StringComparison.CurrentCultureIgnoreCase))
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

            foreach (VehicleModel vehicle in GlobalData.Vehicles.Values)
            {
                if (vehicle.Id == Id)
                {
                    ImagePath = vehicle.ImagePath;
                    if (ImagePath != "")
                        File.Delete(ImagePath);

                    //iterate through competitions and remove current vehicle
                    for (int Index = 0; Index < GlobalData.Competitions.Count; Index++)
                        DeleteVehicleFromCompetition(Index, Id);

                    GlobalData.Vehicles.Remove(vehicle.Id);

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
                GlobalData.Vehicles[competitor.VehicleId].SumPositions = GlobalData.Vehicles[competitor.VehicleId].SumPositions - competitor.Position + CurrentPosition;

                competitor.Position = CurrentPosition;
            }
        }

        public static bool DeleteCompetition(int Id)
        {
            foreach(CompetitionModel competition in GlobalData.Competitions)
                if(competition.Id == Id)
                {
                    if (competition.ImagePath != "" && File.Exists(competition.ImagePath))
                        File.Delete(competition.ImagePath);

                    // Remove each position from positions sum and decrement counter in each participating vehicle
                    foreach (CompetitorModel competitor in competition.Competitors)
                    {
                        GlobalData.Vehicles[competitor.VehicleId].NrCompetitions--;
                        GlobalData.Vehicles[competitor.VehicleId].SumPositions -= competitor.Position;
                    }

                    GlobalData.Competitions.Remove(competition);
                    foreach (IDataConnection connection in GlobalConfig.Connections)
                    {
                        connection.WriteCompetitions();
                        connection.WriteVehicles();
                    }
                    return true;
                }

            return false;
        }

        public static bool DeleteCompetitor(int CompetitionId, int CompetitorId)
        {
            foreach (CompetitionModel competition in GlobalData.Competitions)
                if (competition.Id == CompetitionId)
                {
                    int Index = 0;
                    int DeletedPosition;

                    //search for delete index
                    while (competition.Competitors[Index].Id != CompetitorId)
                        Index++;

                    //update deleted vehicle info
                    GlobalData.Vehicles[competition.Competitors[Index].VehicleId].SumPositions -= competition.Competitors[Index].Position;
                    GlobalData.Vehicles[competition.Competitors[Index].VehicleId].NrCompetitions--;

                    DeletedPosition = competition.Competitors[Index].Position;
                    competition.Competitors.RemoveAt(Index);

                    //Example: _4_ 4 4 7 if we delete _4_ we must ignore next two 4s
                    while (Index < competition.Competitors.Count && competition.Competitors[Index].Position == DeletedPosition)
                        Index++;

                    //next competitors will have gone up one position
                    for (int i = Index; i < competition.Competitors.Count; i++)
                    {
                        competition.Competitors[i].Position--;
                        GlobalData.Vehicles[competition.Competitors[i].VehicleId].SumPositions--;
                    }

                    foreach (IDataConnection connection in GlobalConfig.Connections)
                    {
                        connection.WriteCompetitions();
                        connection.WriteVehicles();
                    }
                    return true;
                }

            return false;
        }


        public static VehicleModel GetVehicleById(int Id)
        {
            if (GlobalData.Vehicles.TryGetValue(Id, out VehicleModel value))
                return value;

            return null;
        }

        public static CompetitionModel GetCompetitionById(int Id)
        {
            foreach (CompetitionModel competition in GlobalData.Competitions)
                if (competition.Id == Id)
                    return competition;
            return null;
        }

        // TODO - instead of doing this every single time we should just switch to storing these in-memory only
        public static void RecalculateVehiclePositions()
        {
            // Reset all counters
            foreach (var v in GlobalData.Vehicles.Values)
            {
                v.SumPositions = 0;
                v.NrCompetitions = 0;
            }

            // Re-scan all competitions and re-compute positions for vehicles
            foreach (var comp in GlobalData.Competitions)
            {
                foreach (var competitor in comp.Competitors)
                {
                    if (GlobalData.Vehicles.TryGetValue(competitor.VehicleId, out var vehicle))
                    {
                        vehicle.SumPositions += competitor.Position;
                        vehicle.NrCompetitions++;
                    }
                }
            }

            foreach (IDataConnection c in GlobalConfig.Connections)
                c.WriteVehicles();
        }

    }
}
