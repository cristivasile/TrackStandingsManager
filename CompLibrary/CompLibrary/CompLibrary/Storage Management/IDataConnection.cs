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
        bool CreateCategory(string newCategory);
        int CreateCompetition(CompetitionModel newCompetition);
        List<VehicleModel> ReadVehicles();
        BindingList<string> ReadCategories();
        List<CompetitionModel> ReadCompetitions();
        bool RemoveCategory(string toBeDeleted);
        bool RemoveVehicle(int Id);
        bool UpdateVehicle(VehicleModel vehicle);
    }
}
