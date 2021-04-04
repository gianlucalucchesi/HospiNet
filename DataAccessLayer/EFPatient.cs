using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EFPatients
    {
        public List<Models.ModPatient> GetAllPatients()
        {
            List<Models.ModPatient> lstPatients = new List<Models.ModPatient>();

            try
            {
                HospiNetEntitiesPatient oDatabase = new HospiNetEntitiesPatient();
                List<usp_GetAllPatients_Result> lstResult = oDatabase.usp_GetAllPatients().ToList();

                foreach (var result in lstResult)
                {
                    var oPatient = new Models.ModPatient();
                    oPatient.Id = result.Id;
                    oPatient.FirstName = result.FirstName;
                    oPatient.LastName = result.LastName;
                    oPatient.Birthday = result.Birthday;

                    lstPatients.Add(oPatient);
                }
            }
            catch (Exception e)
            {
                var exc = e.GetBaseException() as SqlException; 

                if (!(exc is null))
                {
                    CustomErrors.CustomSqlErrors customException = new CustomErrors.CustomSqlErrors(exc.Number);
                    customException.ExceptionDescription = exc.Message;

                    throw customException;
                }
                else
                {
                    Console.WriteLine("Other error: " + e.Message);
                    throw;
                }
            }

            return lstPatients;
        }

        public Guid? AddPatient(string FirstName, string LastName, DateTime Birthday)
        {
            using (var oDatabase = new HospiNetEntitiesPatient())
            {
                try
                {
                    return oDatabase.usp_AddPatient(FirstName, LastName, Birthday).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void UpdatePatient(Models.ModPatient oPatient)
        {
            using (var oDatabase = new HospiNetEntitiesPatient())
            {
                oDatabase.usp_UpdatePatient(oPatient.Id, oPatient.FirstName, oPatient.LastName, oPatient.Birthday);
            }
        }
    }
}
