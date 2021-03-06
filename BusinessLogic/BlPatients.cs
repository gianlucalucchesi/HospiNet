using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusinessLogic
{
    public class BlPatients
    {
        // TODO logic here instead of DAL
        public List<Models.ModPatient> GetAllPatients()
        {
            DataAccessLayer.EFPatients oData = new DataAccessLayer.EFPatients();
            return oData.GetAllPatients();
        }

        public Guid? AddPatient(Models.ModPatient oPatient)
        {
            DataAccessLayer.EFPatients oData = new DataAccessLayer.EFPatients();
            return oData.AddPatient(oPatient.FirstName, oPatient.LastName, oPatient.Birthday);
        }
    }
}
