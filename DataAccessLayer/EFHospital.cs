using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EFHospital
    {
        public List<usp_GetHospitals_Result> GetAllHospitals()
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetHospitals().ToList();
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
            HospiNetEntities oDatabase = new HospiNetEntities();
            return oDatabase.usp_UserExists(FirstName, LastName, Type).FirstOrDefault();
        }

        public List<usp_GetAllRooms_Result> GetAllRooms()
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetAllRooms().ToList();
            }
        }

        public Guid? GetAvailableRoom(Guid? hospitalId, DateTime? AppointmentStart, DateTime? AppointmentEnd)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                return oDatabase.usp_GetAvailableRoom(hospitalId, AppointmentStart, AppointmentEnd).FirstOrDefault();
            }
        }

        public void AddRoom(string roomName, Guid HospitalId)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                oDatabase.usp_AddRoom(roomName, HospitalId);
            }
        }

        public void AddHospital(Models.ModHospital oHospital)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                oDatabase.usp_AddHospital(oHospital.Name, oHospital.Address, oHospital.ZipCode, oHospital.City);
            }
        }

        public void UpdateHospital(Models.ModHospital oHospital)
        {
            using (var oDatabase = new HospiNetEntities())
            {
                oDatabase.usp_UpdateHospital(oHospital.Id, oHospital.Name, oHospital.Address, oHospital.ZipCode, oHospital.City);
            }
        }
    }
}
