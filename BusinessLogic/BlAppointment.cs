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

            appointment.Patient.Id = blHospitals.UserExists(appointment.Patient.FirstName, appointment.Patient.LastName, "Patient");

            if (appointment.Patient.Id == null) // If does not exist
            {
                blPatients.AddPatient(appointment.Patient);
                appointment.Patient.Id = blHospitals.UserExists(appointment.Patient.FirstName, appointment.Patient.LastName, "Patient");
            }

            //TODO: Assign correct datetime
            appointment.DateTimeEnd = appointment.DateTimeStart.AddMinutes(15.00);

            //Assign available room
            //TO CHANGE: get timeslots when rooms available
            Models.ModRoom oRoom = new Models.ModRoom()
            { 
                Id = oDatabase.GetAvailableRoom(oHospital.Id, appointment.DateTimeStart, appointment.DateTimeEnd) 
            };

            if (oRoom.Id == null)
                return -1;

            return oDatabase.AddAppointment(oHospital.Id, oRoom.Id, appointment.Patient.Id, oDoctor.Id, appointment.DateTimeStart, appointment.DateTimeEnd);
        }
    }
}
