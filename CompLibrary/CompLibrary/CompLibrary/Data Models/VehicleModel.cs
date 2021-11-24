using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class VehicleModel
    {
        /// <summary>
        /// Unique identifier of a vehicle;
        /// </summary>
        public int Id { get; set; } = -1;
        /// <summary>
        /// The brand of this vehicle.
        /// </summary>
        public string Brand { get; set; }
        
        /// <summary>
        /// The model of this vehicle.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The category this vehicle belongs in I.E. coupe.
        /// </summary>
        public string Category { get; set; }
        
        /// <summary>
        /// The relative path of the image used in the description of this vehicle.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Sum of all Positions in competitions that this vehicle takes part in.
        /// </summary>
        public int SumPositions = 0;
        /// <summary>
        /// Number of competitions that this vehicle takes part in.
        /// </summary>
        public int NrCompetitions = 0;

        public VehicleModel() {}
        public VehicleModel(string Brand, string Model, string Category, string ImagePath = "", int Id = -1)
        {
            if (Id != -1)
                this.Id = Id;

            this.Brand = Brand;
            this.Model = Model;
            this.Category = Category;
            this.ImagePath = ImagePath;
        }

        public VehicleModel(VehicleModel ToCopy)
        {
            this.Id = ToCopy.Id;
            this.Brand = ToCopy.Brand;
            this.Model = ToCopy.Model;
            this.Category = ToCopy.Category;
            this.ImagePath = ToCopy.ImagePath;
            this.SumPositions = ToCopy.SumPositions;
            this.NrCompetitions = ToCopy.NrCompetitions;
        }

        public double AveragePosition() {
            if (NrCompetitions != 0)
            {
                return Convert.ToDouble(SumPositions) / Convert.ToDouble(NrCompetitions);
            }
            else return 100000000;
        }

    }
}
