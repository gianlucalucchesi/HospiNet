﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EFPatients
    {
        public List<Models.ModPatient> GetAllPatients()
        {
            HospiNetEntities oDatabase = new HospiNetEntities();
            List<usp_GetAllPatients_Result> lstResult = oDatabase.usp_GetAllPatients().ToList();
            List<Models.ModPatient> lstPatients = new List<Models.ModPatient>();

            foreach (var result in lstResult)
            {
                var oPatient = new Models.ModPatient();
                oPatient.Id = result.Id;
                oPatient.FirstName = result.FirstName;
                oPatient.LastName = result.LastName;
                oPatient.Birthday = result.Birthday;

                lstPatients.Add(oPatient);
            }

            return lstPatients;
        }

        public Guid? AddPatient(string FirstName, string LastName, DateTime Birthday)
        {
            using (var oDatabase = new HospiNetEntities())
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
            using (var oDatabase = new HospiNetEntities())
            {
                oDatabase.usp_UpdatePatient(oPatient.Id, oPatient.FirstName, oPatient.LastName, oPatient.Birthday);
            }
        }
    }
}
