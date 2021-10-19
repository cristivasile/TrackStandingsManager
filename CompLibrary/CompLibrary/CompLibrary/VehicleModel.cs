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

        public int MyProperty { get; set;}
    }
}
