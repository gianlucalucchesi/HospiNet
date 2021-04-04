using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    return oDatabase.usp_AddAppointment(hospitalId, roomId, patientId, DoctorId, SpecialityId, dateTimeStart, dateTimeEnd).SingleOrDefault();
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
        }

        public Guid? GetAvailableRoom(Guid? hospitalId, DateTime? dateTimeStart, DateTime? dateTimeEnd)
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    return oDatabase.usp_GetAvailableRoom(hospitalId, dateTimeStart, dateTimeEnd).SingleOrDefault();
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
        }

        public List<usp_GetDayAppointments_Result> GetDayAppointments(DateTime day)
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    return oDatabase.usp_GetDayAppointments(day).ToList();
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
        }

        public usp_GetAppointment_Result GetAppointment(int appointmentId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesPatient())
                {
                    return oDatabase.usp_GetAppointment(appointmentId).SingleOrDefault();
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
        }

        public int CancelAppointment(int appointmentId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesPatient())
                {
                    return oDatabase.usp_CancelAppointment(appointmentId);
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
        }
    }
}