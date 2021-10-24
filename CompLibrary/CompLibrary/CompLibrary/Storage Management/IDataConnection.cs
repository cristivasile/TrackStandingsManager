using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    public interface IDataConnection
    {

        void CreateVehicle(VehicleModel newVehicle);
        List<VehicleModel> ReadVehicles();
        bool CreateCategory(string newCategory);
        BindingList<string> ReadCategories();
        bool RemoveCategory(string toBeDeleted);
    }
}
