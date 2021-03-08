using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BlHospitals
    {
        public List<Models.ModHospital> GetAllHospitals()
        {
            DataAccessLayer.EFHospital oData = new DataAccessLayer.EFHospital();
            var lstReturned = oData.GetAllHospitals();
            List<Models.ModHospital> lstHospitals = new List<Models.ModHospital>();

            foreach (var hospital in lstReturned)
            {
                Models.ModHospital oHospital = new Models.ModHospital();

                oHospital.Id = hospital.Id;
                oHospital.Name = hospital.Name;
                oHospital.Address = hospital.Address;
                oHospital.ZipCode = hospital.ZipCode;
                oHospital.City = hospital.City;

                lstHospitals.Add(oHospital);
            }

            return lstHospitals;
        }

        /// <summary>
        /// Returns true or false
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Guid? UserExists(string FirstName, string LastName, string Type)
        {
            DataAccessLayer.EFHospital oData = new DataAccessLayer.EFHospital();
            return oData.UserExists(FirstName, LastName, Type);
        }

        public List<Models.ModRoom> GetAllRooms()
        {
            DataAccessLayer.EFHospital oData = new DataAccessLayer.EFHospital();
            var lstRooms = new List<Models.ModRoom>();
            var lstContent = oData.GetAllRooms();

            foreach (var room in lstContent)
            {
                var oRoom = new Models.ModRoom();

                oRoom.Id = room.Id;
                oRoom.RoomName = room.RoomName;
                oRoom.HospitalName = room.HospitalName;

                lstRooms.Add(oRoom);
            }

            return lstRooms;
        }
    }
}
