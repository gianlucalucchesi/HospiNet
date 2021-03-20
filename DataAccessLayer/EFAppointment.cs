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
            Guid? DoctorId, DateTime? dateTimeStart, DateTime? dateTimeEnd)
        {
            HospiNetEntities oDatabase = new HospiNetEntities();
            return oDatabase.usp_AddAppointment(hospitalId, roomId, patientId, DoctorId, dateTimeStart, dateTimeEnd).SingleOrDefault();
        }

        public Guid? GetAvailableRoom(Guid? hospitalId, DateTime? dateTimeStart, DateTime? dateTimeEnd)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetAvailableRoom(hospitalId, dateTimeStart, dateTimeEnd).SingleOrDefault();
            }
        }
    }
}