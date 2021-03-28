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
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_GetAllDoctors().ToList();
            }
        }

        public List<usp_SelectAllSpecialities_Result> GetAllSpecialities()
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_SelectAllSpecialities().ToList();
            }
        }

        public List<usp_GetDoctorSpecialities_Result> GetDoctorSpecialities(Guid doctorId)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_GetDoctorSpecialities(doctorId).ToList();
            }
        }

        public List<usp_GetDoctorsBasedOnSpeciality_Result> GetDoctorsBasedOnSpeciality(Guid specialityId)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_GetDoctorsBasedOnSpeciality(specialityId).ToList();
            }
        }

        public Guid? AddDoctor(string firstName, string lastName)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_AddDoctor(firstName, lastName).FirstOrDefault();
            }
        }

        public void AddDoctorSpeciality(Guid? doctorId, Guid specialityId)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                oDatabase.usp_AddDoctorSpeciality(doctorId, specialityId);
            }
        }

        public List<usp_GetDoctorAppointments_Result> GetAppointments(Guid doctorId)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_GetDoctorAppointments(doctorId).ToList();
            }
        }

        public void ConfirmAppointment(int appointmentid)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                oDatabase.usp_ConfirmAppointment(appointmentid);
            }
        }

        public int AddAttendence(Guid? doctorId, Guid? hospitalId, Guid? specialityId, int duration, DateTime fromDateTime, DateTime toDateTime)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_AddDoctorAvailability(doctorId, hospitalId, specialityId, duration, fromDateTime, toDateTime);
            }
        }

        public int? GetAppointmentDuration(Guid? doctorId, Guid? hospitalId, DateTime dateTimeStart, Guid? specialityId)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_GetAppointmentDuration(doctorId, hospitalId, dateTimeStart, specialityId).SingleOrDefault();
            }
        }

        public List<usp_GetDoctorAvailabilities_Result> GetAttendances(Guid? doctorId)
        {
            using (var oDatabase = new HospiNetEntitiesDoctor())
            {
                return oDatabase.usp_GetDoctorAvailabilities(doctorId).ToList();
            }
        }
    }
}
