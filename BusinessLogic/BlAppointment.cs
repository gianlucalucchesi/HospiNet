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
            Models.ModSpeciality oSpeciality = blDoctors.GetAllSpecialities().SingleOrDefault(x => x.Name == appointment.SpecialityName);

            appointment.Patient.Id = blHospitals.UserExists(appointment.Patient.FirstName, appointment.Patient.LastName, "Patient");

            if (appointment.Patient.Id == null) // If does not exist
            {
                blPatients.AddPatient(appointment.Patient);
                appointment.Patient.Id = blHospitals.UserExists(appointment.Patient.FirstName, appointment.Patient.LastName, "Patient");
            }

            double appointmentDuration = (double)GetAppointmentDuration(oDoctor.Id, oHospital.Id, appointment.DateTimeStart, oSpeciality.Id);
            appointment.DateTimeEnd = appointment.DateTimeStart.AddMinutes(appointmentDuration);

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

        private int? GetAppointmentDuration(Guid? doctorId, Guid? hospitalId, DateTime dateTimeStart, Guid? specialityId)
        {
            DataAccessLayer.EFDoctors oDatabase = new DataAccessLayer.EFDoctors();
            return oDatabase.GetAppointmentDuration(doctorId, hospitalId, dateTimeStart, specialityId);
        }

        public List<Models.ModHospital> GetAvailableHospitals(string doctorName, string specialityName)
        {
            List<Models.ModHospital> lstHospitalsFull = new List<Models.ModHospital>();

            DataAccessLayer.EFDoctors efDoctors = new DataAccessLayer.EFDoctors();
            string[] name = doctorName.Split(' ');

            var doctorReceived = efDoctors.GetAllDoctors().SingleOrDefault(x => x.FirstName + " " + x.LastName == doctorName);

            Models.ModDoctor oDoctor = new Models.ModDoctor();
            oDoctor.FirstName = doctorReceived.FirstName;
            oDoctor.LastName = doctorReceived.LastName;
            oDoctor.Id = doctorReceived.Id;

            var attendancesReceived = efDoctors.GetAttendances(oDoctor.Id);

            var specialityReceived = efDoctors.GetAllSpecialities().SingleOrDefault(x => x.Name == specialityName);
            Models.ModSpeciality oSpeciality = new Models.ModSpeciality();
            oSpeciality.Id = specialityReceived.Id;
            oSpeciality.Name = specialityReceived.Name;

            BlHospitals blHospitals = new BlHospitals();
            var lstAllHospitals = blHospitals.GetAllHospitals();

            foreach (var hospital in attendancesReceived)
            {
                if (hospital.Speciality_Id == oSpeciality.Id)
                {
                    Models.ModHospital oHospital = new Models.ModHospital();
                    oHospital.Id = hospital.Hospital_Id;
                    oHospital.Name = lstAllHospitals.SingleOrDefault(x => x.Id == hospital.Hospital_Id).Name;

                    lstHospitalsFull.Add(oHospital);
                }
            }

            return lstHospitalsFull;
        }
    }
}
