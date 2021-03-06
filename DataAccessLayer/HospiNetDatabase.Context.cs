//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HospiNetEntities : DbContext
    {
        public HospiNetEntities()
            : base("name=HospiNetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<usp_SelectAllSpecialities_Result> usp_SelectAllSpecialities()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectAllSpecialities_Result>("usp_SelectAllSpecialities");
        }
    
        public virtual int usp_AddHospital(string name, string address, string zipCode, string city)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var zipCodeParameter = zipCode != null ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddHospital", nameParameter, addressParameter, zipCodeParameter, cityParameter);
        }
    
        public virtual ObjectResult<usp_GetHospitals_Result> usp_GetHospitals()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetHospitals_Result>("usp_GetHospitals");
        }
    
        public virtual ObjectResult<Nullable<System.Guid>> usp_UserExists(string firstName, string lastName, string type)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("usp_UserExists", firstNameParameter, lastNameParameter, typeParameter);
        }
    
        public virtual ObjectResult<usp_GetAllPatients_Result> usp_GetAllPatients()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllPatients_Result>("usp_GetAllPatients");
        }
    
        public virtual ObjectResult<Nullable<int>> usp_AddAppointment(Nullable<System.Guid> hospital_Id, Nullable<System.Guid> room_Id, Nullable<System.Guid> patient_Id, Nullable<System.Guid> doctor_Id, Nullable<System.Guid> speciality_Id, Nullable<System.DateTime> dateTimeStart, Nullable<System.DateTime> dateTimeEnd)
        {
            var hospital_IdParameter = hospital_Id.HasValue ?
                new ObjectParameter("Hospital_Id", hospital_Id) :
                new ObjectParameter("Hospital_Id", typeof(System.Guid));
    
            var room_IdParameter = room_Id.HasValue ?
                new ObjectParameter("Room_Id", room_Id) :
                new ObjectParameter("Room_Id", typeof(System.Guid));
    
            var patient_IdParameter = patient_Id.HasValue ?
                new ObjectParameter("Patient_Id", patient_Id) :
                new ObjectParameter("Patient_Id", typeof(System.Guid));
    
            var doctor_IdParameter = doctor_Id.HasValue ?
                new ObjectParameter("Doctor_Id", doctor_Id) :
                new ObjectParameter("Doctor_Id", typeof(System.Guid));
    
            var speciality_IdParameter = speciality_Id.HasValue ?
                new ObjectParameter("Speciality_Id", speciality_Id) :
                new ObjectParameter("Speciality_Id", typeof(System.Guid));
    
            var dateTimeStartParameter = dateTimeStart.HasValue ?
                new ObjectParameter("DateTimeStart", dateTimeStart) :
                new ObjectParameter("DateTimeStart", typeof(System.DateTime));
    
            var dateTimeEndParameter = dateTimeEnd.HasValue ?
                new ObjectParameter("DateTimeEnd", dateTimeEnd) :
                new ObjectParameter("DateTimeEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_AddAppointment", hospital_IdParameter, room_IdParameter, patient_IdParameter, doctor_IdParameter, speciality_IdParameter, dateTimeStartParameter, dateTimeEndParameter);
        }
    
        public virtual ObjectResult<usp_GetAllDoctors_Result> usp_GetAllDoctors()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllDoctors_Result>("usp_GetAllDoctors");
        }
    
        public virtual ObjectResult<usp_GetDoctorSpecialities_Result> usp_GetDoctorSpecialities(Nullable<System.Guid> doctorId)
        {
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("doctorId", doctorId) :
                new ObjectParameter("doctorId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorSpecialities_Result>("usp_GetDoctorSpecialities", doctorIdParameter);
        }
    
        public virtual ObjectResult<usp_GetDoctorsBasedOnSpeciality_Result> usp_GetDoctorsBasedOnSpeciality(Nullable<System.Guid> specialityId)
        {
            var specialityIdParameter = specialityId.HasValue ?
                new ObjectParameter("SpecialityId", specialityId) :
                new ObjectParameter("SpecialityId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorsBasedOnSpeciality_Result>("usp_GetDoctorsBasedOnSpeciality", specialityIdParameter);
        }
    
        public virtual ObjectResult<Nullable<System.Guid>> usp_AddPatient(string firstName, string lastName, Nullable<System.DateTime> birthday)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var birthdayParameter = birthday.HasValue ?
                new ObjectParameter("Birthday", birthday) :
                new ObjectParameter("Birthday", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("usp_AddPatient", firstNameParameter, lastNameParameter, birthdayParameter);
        }
    
        public virtual ObjectResult<usp_GetAllRooms_Result> usp_GetAllRooms()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllRooms_Result>("usp_GetAllRooms");
        }
    
        public virtual int usp_AddRoom(string name, Nullable<System.Guid> hospital_Id)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var hospital_IdParameter = hospital_Id.HasValue ?
                new ObjectParameter("hospital_Id", hospital_Id) :
                new ObjectParameter("hospital_Id", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddRoom", nameParameter, hospital_IdParameter);
        }
    
        public virtual int usp_UpdatePatient(Nullable<System.Guid> id, string firstName, string lastName, Nullable<System.DateTime> birthday)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(System.Guid));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var birthdayParameter = birthday.HasValue ?
                new ObjectParameter("Birthday", birthday) :
                new ObjectParameter("Birthday", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdatePatient", idParameter, firstNameParameter, lastNameParameter, birthdayParameter);
        }
    
        public virtual int usp_UpdateHospital(Nullable<System.Guid> id, string name, string address, string zipcode, string city)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(System.Guid));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var zipcodeParameter = zipcode != null ?
                new ObjectParameter("zipcode", zipcode) :
                new ObjectParameter("zipcode", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateHospital", idParameter, nameParameter, addressParameter, zipcodeParameter, cityParameter);
        }
    
        public virtual ObjectResult<Nullable<System.Guid>> usp_AddDoctor(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("usp_AddDoctor", firstNameParameter, lastNameParameter);
        }
    
        public virtual int usp_AddDoctorSpeciality(Nullable<System.Guid> doctor_id, Nullable<System.Guid> speciality_id)
        {
            var doctor_idParameter = doctor_id.HasValue ?
                new ObjectParameter("doctor_id", doctor_id) :
                new ObjectParameter("doctor_id", typeof(System.Guid));
    
            var speciality_idParameter = speciality_id.HasValue ?
                new ObjectParameter("speciality_id", speciality_id) :
                new ObjectParameter("speciality_id", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddDoctorSpeciality", doctor_idParameter, speciality_idParameter);
        }
    
        public virtual int usp_ConfirmAppointment(Nullable<int> appointmentId)
        {
            var appointmentIdParameter = appointmentId.HasValue ?
                new ObjectParameter("appointmentId", appointmentId) :
                new ObjectParameter("appointmentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ConfirmAppointment", appointmentIdParameter);
        }
    
        public virtual ObjectResult<Nullable<System.Guid>> usp_GetAvailableRoom(Nullable<System.Guid> hospitalId, Nullable<System.DateTime> dateTimeStart, Nullable<System.DateTime> dateTimeEnd)
        {
            var hospitalIdParameter = hospitalId.HasValue ?
                new ObjectParameter("hospitalId", hospitalId) :
                new ObjectParameter("hospitalId", typeof(System.Guid));
    
            var dateTimeStartParameter = dateTimeStart.HasValue ?
                new ObjectParameter("dateTimeStart", dateTimeStart) :
                new ObjectParameter("dateTimeStart", typeof(System.DateTime));
    
            var dateTimeEndParameter = dateTimeEnd.HasValue ?
                new ObjectParameter("dateTimeEnd", dateTimeEnd) :
                new ObjectParameter("dateTimeEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("usp_GetAvailableRoom", hospitalIdParameter, dateTimeStartParameter, dateTimeEndParameter);
        }
    
        public virtual int usp_AddDoctorAvailability(Nullable<System.Guid> doctorId, Nullable<System.Guid> hospitalId, Nullable<System.Guid> specialityId, Nullable<int> consultationTime, Nullable<System.DateTime> dateTimeStart, Nullable<System.DateTime> dateTimeEnd)
        {
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("doctorId", doctorId) :
                new ObjectParameter("doctorId", typeof(System.Guid));
    
            var hospitalIdParameter = hospitalId.HasValue ?
                new ObjectParameter("hospitalId", hospitalId) :
                new ObjectParameter("hospitalId", typeof(System.Guid));
    
            var specialityIdParameter = specialityId.HasValue ?
                new ObjectParameter("specialityId", specialityId) :
                new ObjectParameter("specialityId", typeof(System.Guid));
    
            var consultationTimeParameter = consultationTime.HasValue ?
                new ObjectParameter("consultationTime", consultationTime) :
                new ObjectParameter("consultationTime", typeof(int));
    
            var dateTimeStartParameter = dateTimeStart.HasValue ?
                new ObjectParameter("dateTimeStart", dateTimeStart) :
                new ObjectParameter("dateTimeStart", typeof(System.DateTime));
    
            var dateTimeEndParameter = dateTimeEnd.HasValue ?
                new ObjectParameter("dateTimeEnd", dateTimeEnd) :
                new ObjectParameter("dateTimeEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddDoctorAvailability", doctorIdParameter, hospitalIdParameter, specialityIdParameter, consultationTimeParameter, dateTimeStartParameter, dateTimeEndParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_GetAppointmentDuration(Nullable<System.Guid> doctorId, Nullable<System.Guid> hospitalId, Nullable<System.DateTime> dateTimeStart, Nullable<System.Guid> specialityId)
        {
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("doctorId", doctorId) :
                new ObjectParameter("doctorId", typeof(System.Guid));
    
            var hospitalIdParameter = hospitalId.HasValue ?
                new ObjectParameter("hospitalId", hospitalId) :
                new ObjectParameter("hospitalId", typeof(System.Guid));
    
            var dateTimeStartParameter = dateTimeStart.HasValue ?
                new ObjectParameter("dateTimeStart", dateTimeStart) :
                new ObjectParameter("dateTimeStart", typeof(System.DateTime));
    
            var specialityIdParameter = specialityId.HasValue ?
                new ObjectParameter("specialityId", specialityId) :
                new ObjectParameter("specialityId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_GetAppointmentDuration", doctorIdParameter, hospitalIdParameter, dateTimeStartParameter, specialityIdParameter);
        }
    
        public virtual ObjectResult<usp_GetDoctorAvailabilities_Result> usp_GetDoctorAvailabilities(Nullable<System.Guid> doctorId)
        {
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("doctorId", doctorId) :
                new ObjectParameter("doctorId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorAvailabilities_Result>("usp_GetDoctorAvailabilities", doctorIdParameter);
        }
    
        public virtual int usp_CancelAppointment(Nullable<int> appointmentId)
        {
            var appointmentIdParameter = appointmentId.HasValue ?
                new ObjectParameter("appointmentId", appointmentId) :
                new ObjectParameter("appointmentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CancelAppointment", appointmentIdParameter);
        }
    
        public virtual ObjectResult<usp_GetDoctorAppointments_Result> usp_GetDoctorAppointments(Nullable<System.Guid> doctor_id)
        {
            var doctor_idParameter = doctor_id.HasValue ?
                new ObjectParameter("doctor_id", doctor_id) :
                new ObjectParameter("doctor_id", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorAppointments_Result>("usp_GetDoctorAppointments", doctor_idParameter);
        }
    
        public virtual ObjectResult<usp_GetDayAppointments_Result> usp_GetDayAppointments(Nullable<System.DateTime> day)
        {
            var dayParameter = day.HasValue ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDayAppointments_Result>("usp_GetDayAppointments", dayParameter);
        }
    
        public virtual ObjectResult<usp_GetAppointment_Result> usp_GetAppointment(Nullable<int> appointmentId)
        {
            var appointmentIdParameter = appointmentId.HasValue ?
                new ObjectParameter("appointmentId", appointmentId) :
                new ObjectParameter("appointmentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAppointment_Result>("usp_GetAppointment", appointmentIdParameter);
        }
    }
}
