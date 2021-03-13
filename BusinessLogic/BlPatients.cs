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
            DataAccessLayer.EFPatients oDatabase = new DataAccessLayer.EFPatients();
            return oDatabase.GetAllPatients();
        }

        public Guid? AddPatient(Models.ModPatient oPatient)
        {
            DataAccessLayer.EFPatients oDatabase = new DataAccessLayer.EFPatients();
            return oDatabase.AddPatient(oPatient.FirstName, oPatient.LastName, oPatient.Birthday);
        }

        public bool UpdatePatient(Models.ModPatient oPatient)
        {
            DataAccessLayer.EFPatients oData = new DataAccessLayer.EFPatients();

            var existingPatient = GetAllPatients().Where(s => s.Id == oPatient.Id).FirstOrDefault<Models.ModPatient>();

            if (existingPatient != null)
            {
                oData.UpdatePatient(oPatient);
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
