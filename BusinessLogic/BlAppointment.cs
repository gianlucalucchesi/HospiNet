using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BlAppointment
    {
        public int? AddAppointment(Models.ModAppointment appointment)
        {
            DataAccessLayer.EFAppointment oDatabase = new DataAccessLayer.EFAppointment();
            BlDoctors blDoctors = new BlDoctors();
            BlHospitals blHospitals = new BlHospitals();
            BlPatients blPatients = new BlPatients();

            Models.ModDoctor oDoctor = blDoctors.GetAllDoctors().SingleOrDefault(x => x.FirstName + " " + x.LastName == appointment.DoctorName);
            Models.ModHospital oHospital = blHospitals.GetAllHospitals().SingleOrDefault(x => x.Name == appointment.HospitalName);
            Models.ModRoom oRoom = blHospitals.GetAllRooms().SingleOrDefault(x => x.RoomName == appointment.RoomName);
            //Models.ModPatient oPatient = appointment.Patient; //Unnecessary usage of memory

            return oDatabase.AddAppointment(oHospital.Id, oRoom.Id, appointment.Patient.Id, oDoctor.Id, appointment.DateTimeStart, appointment.DateTimeEnd);
        }
    }
}
