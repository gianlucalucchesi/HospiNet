using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EFDoctors
    {
        public List<usp_GetAllDoctors_Result> GetAllDoctors()
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_GetAllDoctors().ToList();
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

        public List<usp_SelectAllSpecialities_Result> GetAllSpecialities()
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_SelectAllSpecialities().ToList();
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

        public List<usp_GetDoctorSpecialities_Result> GetDoctorSpecialities(Guid doctorId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_GetDoctorSpecialities(doctorId).ToList();
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

        public List<usp_GetDoctorsBasedOnSpeciality_Result> GetDoctorsBasedOnSpeciality(Guid specialityId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_GetDoctorsBasedOnSpeciality(specialityId).ToList();
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

        public Guid? AddDoctor(string firstName, string lastName)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_AddDoctor(firstName, lastName).FirstOrDefault();
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

        public void AddDoctorSpeciality(Guid? doctorId, Guid specialityId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    oDatabase.usp_AddDoctorSpeciality(doctorId, specialityId);
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

        public List<usp_GetDoctorAppointments_Result> GetAppointments(Guid doctorId)
        {
           try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_GetDoctorAppointments(doctorId).ToList();
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

        public void ConfirmAppointment(int appointmentid)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    oDatabase.usp_ConfirmAppointment(appointmentid);
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

        public int AddAttendence(Guid? doctorId, Guid? hospitalId, Guid? specialityId, int duration, DateTime fromDateTime, DateTime toDateTime)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_AddDoctorAvailability(doctorId, hospitalId, specialityId, duration, fromDateTime, toDateTime);
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

        public int? GetAppointmentDuration(Guid? doctorId, Guid? hospitalId, DateTime dateTimeStart, Guid? specialityId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_GetAppointmentDuration(doctorId, hospitalId, dateTimeStart, specialityId).SingleOrDefault();
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

        public List<usp_GetDoctorAvailabilities_Result> GetAttendances(Guid? doctorId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntitiesDoctor())
                {
                    return oDatabase.usp_GetDoctorAvailabilities(doctorId).ToList();
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