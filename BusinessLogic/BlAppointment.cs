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
            Models.ModRoom oRoom = new Models.ModRoom()
            {
                Id = oDatabase.GetAvailableRoom(oHospital.Id, appointment.DateTimeStart, appointment.DateTimeEnd)
            };

            return oDatabase.AddAppointment(oHospital.Id, oRoom.Id, appointment.Patient.Id, oDoctor.Id, 
                oSpeciality.Id, appointment.DateTimeStart, appointment.DateTimeEnd);
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

        public List<Models.ModAppointmentVw> GetExistingDayAppointments(DateTime day) 
        {
            List<Models.ModAppointmentVw> lstAppointmentsVw = new List<Models.ModAppointmentVw>();
            DataAccessLayer.EFAppointment efAppointment = new DataAccessLayer.EFAppointment();
            var dayAppointments = efAppointment.GetDayAppointments(day);

            foreach (var appointment in dayAppointments)
            {
                Models.ModAppointmentVw oAppointmentVw = new Models.ModAppointmentVw();
                oAppointmentVw.Id = appointment.Id;
                oAppointmentVw.HospitalName = appointment.HospitalName;
                oAppointmentVw.RoomName = appointment.RoomName;
                oAppointmentVw.DoctorId = appointment.DoctorId;
                oAppointmentVw.FirstName = appointment.FirstName;
                oAppointmentVw.LastName = appointment.LastName;
                oAppointmentVw.DateTimeStart = appointment.DateTimeStart;
                oAppointmentVw.DateTimeEnd = appointment.DateTimeEnd;
                oAppointmentVw.Confirmed = appointment.Confirmed;
                oAppointmentVw.SpecialityName = appointment.SpecialityName;

                lstAppointmentsVw.Add(oAppointmentVw);
            }

            return lstAppointmentsVw;
        }

        public Guid? GetAvailableRoom(DateTime[] timeSlot, Guid? hospitalId)
        {
            BlHospitals blHospitals = new BlHospitals();
            return blHospitals.GetAvailableRoom(hospitalId, timeSlot[0], timeSlot[1]);
        }

        public List<DateTime[]> GetAvailableTimes(DateTime day, string doctorName, string hospitalName, string specialityName)
        {
            var lstExistingAppointments = GetExistingDayAppointments(day);
            List<DateTime[]> lstExistingAppointmentsDateTime = new List<DateTime[]>();

            BlDoctors blDoctors = new BlDoctors();
            BlHospitals blHospitals = new BlHospitals();
            Models.ModDoctor oDoctor = blDoctors.GetAllDoctors().SingleOrDefault(x => x.FirstName + " " + x.LastName == doctorName);
            Models.ModSpeciality oSpeciality = blDoctors.GetAllSpecialities().SingleOrDefault(x => x.Name == specialityName);
            Models.ModHospital oHospital = blHospitals.GetAllHospitals().SingleOrDefault(x => x.Name == hospitalName);

            int? appointmentDuration = GetAppointmentDuration(oDoctor.Id, oHospital.Id, day, oSpeciality.Id);

            List<DateTime[]> lstDoctorDayAttendances = blDoctors.GetAttendances(oDoctor.Id).Where(x => x[0].Date == day && x[1].Date == day).ToList();
            List<DateTime[]> lstAllTimeSlots = new List<DateTime[]>();

            foreach (var attendance in lstDoctorDayAttendances)
            {
                while (attendance[0] < attendance[1])
                {
                    DateTime[] arrTimeSlot =
{
                        attendance[0],
                        attendance[0].AddMinutes((double)appointmentDuration)
                    };

                    lstAllTimeSlots.Add(arrTimeSlot);
                    attendance[0] = attendance[0].AddMinutes((double)appointmentDuration);
                }
            }

            foreach (var exitingAppointment in lstExistingAppointments)
            {
                if (exitingAppointment.HospitalName == oHospital.Name
                    && exitingAppointment.DoctorId == oDoctor.Id
                    && exitingAppointment.SpecialityName == specialityName)
                {
                    DateTime[] arrExistingAppoitmentDateTime =
                    {
                        exitingAppointment.DateTimeStart,
                        exitingAppointment.DateTimeEnd
                    };

                    lstExistingAppointmentsDateTime.Add(arrExistingAppoitmentDateTime);
                }
            }

            List<DateTime[]> lstAvailableTimeSlots = new List<DateTime[]>();

            foreach (var timeSlot in lstAllTimeSlots)
            {
                bool available = true;

                foreach (var Existingappointment in lstExistingAppointmentsDateTime)
                {
                    if ((Existingappointment[0] >= timeSlot[0] && Existingappointment[0] <= timeSlot[1]) ||
                        (Existingappointment[1] >= timeSlot[0] && Existingappointment[1] <= timeSlot[1]))
                    {
                        available = false;                                                                   
                    } 
                }

                if (GetAvailableRoom(timeSlot, oHospital.Id) == null)
                    available = false;

                if (available)
                    lstAvailableTimeSlots.Add(timeSlot);
            }

            return lstAvailableTimeSlots;
        }

        public Models.ModAppointmentVw GetAppointment(int id)
        {
            DataAccessLayer.EFAppointment efAppointment = new DataAccessLayer.EFAppointment();
            BusinessLogic.BlDoctors blDoctor = new BusinessLogic.BlDoctors();
            var result = efAppointment.GetAppointment(id);
            Models.ModDoctor oDoctor = new Models.ModDoctor();
            Models.ModAppointmentVw oAppointmentVw = new Models.ModAppointmentVw();

            if (result != null)
            {
                oDoctor = blDoctor.GetAllDoctors().SingleOrDefault(x => x.Id == result.DoctorId);

                oAppointmentVw.Confirmed = result.Confirmed;
                oAppointmentVw.DateTimeEnd = result.DateTimeEnd;
                oAppointmentVw.DateTimeStart = result.DateTimeStart;
                oAppointmentVw.DoctorName = oDoctor.FirstName + " " + oDoctor.LastName;
                oAppointmentVw.HospitalName = result.HospitalName;
                oAppointmentVw.FirstName = result.FirstName;
                oAppointmentVw.LastName = result.LastName;
                oAppointmentVw.RoomName = result.RoomName;
                oAppointmentVw.SpecialityName = result.SpecialityName;
            }

            return oAppointmentVw;
        }

        public int CancelAppointment(int appointmentId)
        {
            DataAccessLayer.EFAppointment efAppointment = new DataAccessLayer.EFAppointment();
            return efAppointment.CancelAppointment(appointmentId);
        }
    }
}
