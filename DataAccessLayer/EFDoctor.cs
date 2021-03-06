using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EFDoctors
    {
        public List<usp_GetAllDoctors_Result> GetAllDoctors()
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetAllDoctors().ToList();
            }
        }

        public List<usp_SelectAllSpecialities_Result> GetAllSpecialities()
        {
            HospiNetEntities oDatabase = new HospiNetEntities();
            return oDatabase.usp_SelectAllSpecialities().ToList();
        }

        public List<usp_GetAppointments_Result> GetAppointments(Guid doctorId)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetAppointments(doctorId).ToList();
            }
        }

        public List<usp_GetDoctorSpecialities_Result> GetDoctorSpecialities(Guid doctorId)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetDoctorSpecialities(doctorId).ToList();
            }
        }

        public List<usp_GetDoctorsBasedOnSpeciality_Result> GetDoctorsBasedOnSpeciality(Guid specialityId)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetDoctorsBasedOnSpeciality(specialityId).ToList();
            }
        }

        //public int? AddApointment(Models.ModAppointment oAppointment)
        //{
        //    using (var oDatabase = new HospiNetEntities())
        //    {
        //        //return oDatabase.usp_AddAppointment(oAppointment);
        //    }
        //}
    }
}
