using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    public class VehicleModel
    {
        /// <summary>
        /// Unique identifier of a vehicle;
        /// </summary>
        public int Id { get; set; }
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
        /// Average position in all competitions this vehicle takes part in.
        /// </summary>
        public int AveragePosition = 100000;

        public VehicleModel(string Brand, string Model, string Category, string ImagePath = "")
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Category = Category;
            this.ImagePath = ImagePath;
        }

    }
}
