using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EFAppointment
    {
        public int? AddAppointment(Guid? hospitalId, Guid? roomId, Guid? patientId, 
            Guid? DoctorId, Guid? SpecialityId, DateTime? dateTimeStart, DateTime? dateTimeEnd)
        {
            HospiNetEntities oDatabase = new HospiNetEntities();
            return oDatabase.usp_AddAppointment(hospitalId, roomId, patientId, DoctorId, SpecialityId, dateTimeStart, dateTimeEnd).SingleOrDefault();
        }

        public Guid? GetAvailableRoom(Guid? hospitalId, DateTime? dateTimeStart, DateTime? dateTimeEnd)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetAvailableRoom(hospitalId, dateTimeStart, dateTimeEnd).SingleOrDefault();
            }
        }

        public List<usp_GetDayAppointments_Result> GetDayAppointments(DateTime day)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetDayAppointments(day).ToList();
            }
        }

        public usp_GetAppointment_Result GetAppointment(int appointmentId)
        {
            using (var oDatabase = new HospiNetEntitiesPatient())
            {
                return oDatabase.usp_GetAppointment(appointmentId).SingleOrDefault();
            }
        }

        public int CancelAppointment(int appointmentId)
        {
            using (var oDatabase = new HospiNetEntitiesPatient())
            {
                return oDatabase.usp_CancelAppointment(appointmentId);
            }
        }
    }
}