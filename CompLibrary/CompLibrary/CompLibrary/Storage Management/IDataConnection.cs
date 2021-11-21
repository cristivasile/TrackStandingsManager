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
        void WriteVehicles();
        void WriteCategories();
        void WriteCompetitions();
        List<VehicleModel> ReadVehicles();
        BindingList<string> ReadCategories();
        List<CompetitionModel> ReadCompetitions();
    }
}
