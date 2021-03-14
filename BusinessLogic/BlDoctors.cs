using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusinessLogic
{
    public class BlDoctors
    {
        public List<Models.ModSpeciality> GetAllSpecialities()
        {
            DataAccessLayer.EFDoctors oSpecialities = new DataAccessLayer.EFDoctors();
            var lstReceived = oSpecialities.GetAllSpecialities();

            List<Models.ModSpeciality> lstSpecialities = new List<Models.ModSpeciality>();

            // Use Model instead of directly returing SelectAll() serialized to maintain control on what fields are returned
            foreach (var speciality in lstReceived)
            {
                var oSpeciality = new Models.ModSpeciality();
                oSpeciality.Id = speciality.Id;
                oSpeciality.Name = speciality.Name;

                lstSpecialities.Add(oSpeciality);
            }

            return lstSpecialities;
        }

        public List<Models.ModSpeciality> GetDoctorSpecialities(Guid doctorId)
        {
            DataAccessLayer.EFDoctors oDoctors = new DataAccessLayer.EFDoctors();
            var lstReceived = oDoctors.GetDoctorSpecialities(doctorId);
            var lstSpecialities = new List<Models.ModSpeciality>();

            foreach (var speciality in lstReceived)
            {
                var oSpeciality = new Models.ModSpeciality();

                oSpeciality.Id = speciality.Id;
                oSpeciality.Name = speciality.Name;

                lstSpecialities.Add(oSpeciality);
            }

            return lstSpecialities;
        }

        public List<Models.ModDoctor> GetAllDoctors()
        {
            DataAccessLayer.EFDoctors oDoctors = new DataAccessLayer.EFDoctors();
            var lstReceivedDoctors = oDoctors.GetAllDoctors();

            List<Models.ModDoctor> lstDoctors = new List<Models.ModDoctor>();

            // Use Model instead of directly returing SelectAll() serialized to maintain control on what fields are returned
            foreach (var doctor in lstReceivedDoctors)
            {
                var oDoctor = new Models.ModDoctor();

                oDoctor.Id = doctor.Id;
                oDoctor.FirstName = doctor.FirstName;
                oDoctor.LastName = doctor.LastName;
                oDoctor.RegistrationNumber = doctor.RegistrationNumber;

                var lstReceivedSpecialities = GetDoctorSpecialities(doctor.Id);

                oDoctor.Specialities = new List<Models.ModSpeciality>();

                foreach (var speciality in lstReceivedSpecialities)
                {
                    oDoctor.Specialities.Add(speciality);
                }

                lstDoctors.Add(oDoctor);
            }

            return lstDoctors;
        }

        public List<Models.ModDoctor> GetDoctorBasedOnSpeciality(string speciality)
        {
            DataAccessLayer.EFDoctors oData = new DataAccessLayer.EFDoctors();

            var specialities = GetAllSpecialities();
            var lstDoctorsToReturn = new List<Models.ModDoctor>();

            Models.ModSpeciality oSpeciality = specialities.Find(x => x.Name == speciality);

            var lstReceived = oData.GetDoctorsBasedOnSpeciality(oSpeciality.Id);

            foreach (var doctor in lstReceived)
            {
                Models.ModDoctor oDoctor = new Models.ModDoctor();
                oDoctor.FirstName = doctor.FirstName;
                oDoctor.LastName = doctor.LastName;
                oDoctor.RegistrationNumber = doctor.RegistrationNumber;

                lstDoctorsToReturn.Add(oDoctor);
            }

            return lstDoctorsToReturn;
        }

        public List<Models.ModAppointmentVw> GetAppointments(Guid DoctorId)
        {
            List<Models.ModAppointmentVw> lstAppointments = new List<Models.ModAppointmentVw>();
            DataAccessLayer.EFDoctors oData = new DataAccessLayer.EFDoctors();

            var contentReceived = oData.GetAppointments(DoctorId);

            foreach (var appointment in contentReceived)
            {
                Models.ModAppointmentVw oAppointment = new Models.ModAppointmentVw();

                oAppointment.Id = appointment.Id;
                oAppointment.HospitalName = appointment.HospitalName;
                oAppointment.RoomName = appointment.RoomName;
                oAppointment.FirstName = appointment.FirstName;
                oAppointment.LastName = appointment.LastName;
                oAppointment.DateTimeStart = appointment.DateTimeStart;
                oAppointment.DateTimeEnd = appointment.DateTimeEnd;
                oAppointment.Confirmed = appointment.Confirmed;

                lstAppointments.Add(oAppointment);
            }

            return lstAppointments;
        }

        public void AddDoctor(Models.ModDoctor oDoctor)
        {
            DataAccessLayer.EFDoctors oDoctorEF = new DataAccessLayer.EFDoctors();
            Guid? doctorId = oDoctorEF.AddDoctor(oDoctor.FirstName, oDoctor.LastName);

            foreach (var speciality in oDoctor.Specialities)
            {
                oDoctorEF.AddDoctorSpeciality(doctorId, speciality.Id);
            }
        }
    }
}
