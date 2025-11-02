using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLibrary
{
    /// TODO - It's stupid for the Write functions to not have parameters but oh well.
    /// Might fix at some point
    public interface IDataConnection
    {
        void WriteVehicles();
        void WriteCategories();
        void WriteCompetitions();
        List<VehicleModel> ReadVehicles();
        BindingList<string> ReadCategories();
        List<CompetitionModel> ReadCompetitions();
        void CreateBackup();
        void RestoreBackup();
    }
}
