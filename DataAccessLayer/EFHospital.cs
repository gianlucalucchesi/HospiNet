using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EFHospital
    {
        public List<usp_GetHospitals_Result> GetAllHospitals()
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    return oDatabase.usp_GetHospitals().ToList();
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

        /// <summary>
        /// Returns 1 if user exists
        /// Returns 0 if user doesn't exist
        /// </summary>
        /// <param name="FirstName">Admin</param>
        /// <param name="LastName">Admin</param>
        /// <param name="Type">Patient/Admin/Doctor</param>
        /// <returns></returns>
        public Guid? UserExists(string FirstName, string LastName, string Type)
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    return oDatabase.usp_UserExists(FirstName, LastName, Type).FirstOrDefault();
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

        public List<usp_GetAllRooms_Result> GetAllRooms()
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    return oDatabase.usp_GetAllRooms().ToList();
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

        public Guid? GetAvailableRoom(Guid? hospitalId, DateTime? AppointmentStart, DateTime? AppointmentEnd)
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    return oDatabase.usp_GetAvailableRoom(hospitalId, AppointmentStart, AppointmentEnd).FirstOrDefault();
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

        public void AddRoom(string roomName, Guid HospitalId)
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    oDatabase.usp_AddRoom(roomName, HospitalId);
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

        public void AddHospital(Models.ModHospital oHospital)
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    oDatabase.usp_AddHospital(oHospital.Name, oHospital.Address, oHospital.ZipCode, oHospital.City);
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

        public void UpdateHospital(Models.ModHospital oHospital)
        {
            try
            {
                using (var oDatabase = new HospiNetEntities())
                {
                    oDatabase.usp_UpdateHospital(oHospital.Id, oHospital.Name, oHospital.Address, oHospital.ZipCode, oHospital.City);
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
