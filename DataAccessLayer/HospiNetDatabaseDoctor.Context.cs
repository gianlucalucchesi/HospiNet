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
    
    public partial class HospiNetEntitiesDoctor : DbContext
    {
        public HospiNetEntitiesDoctor()
            : base("name=HospiNetEntitiesDoctor")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
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
    
        public virtual ObjectResult<usp_GetAllDoctors_Result> usp_GetAllDoctors()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllDoctors_Result>("usp_GetAllDoctors");
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
    
        public virtual ObjectResult<usp_GetDoctorAppointments_Result> usp_GetDoctorAppointments(Nullable<System.Guid> doctor_id)
        {
            var doctor_idParameter = doctor_id.HasValue ?
                new ObjectParameter("doctor_id", doctor_id) :
                new ObjectParameter("doctor_id", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorAppointments_Result>("usp_GetDoctorAppointments", doctor_idParameter);
        }
    
        public virtual ObjectResult<usp_GetDoctorAvailabilities_Result> usp_GetDoctorAvailabilities(Nullable<System.Guid> doctorId)
        {
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("doctorId", doctorId) :
                new ObjectParameter("doctorId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorAvailabilities_Result>("usp_GetDoctorAvailabilities", doctorIdParameter);
        }
    
        public virtual ObjectResult<usp_GetDoctorsBasedOnSpeciality_Result> usp_GetDoctorsBasedOnSpeciality(Nullable<System.Guid> specialityId)
        {
            var specialityIdParameter = specialityId.HasValue ?
                new ObjectParameter("SpecialityId", specialityId) :
                new ObjectParameter("SpecialityId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorsBasedOnSpeciality_Result>("usp_GetDoctorsBasedOnSpeciality", specialityIdParameter);
        }
    
        public virtual ObjectResult<usp_GetDoctorSpecialities_Result> usp_GetDoctorSpecialities(Nullable<System.Guid> doctorId)
        {
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("doctorId", doctorId) :
                new ObjectParameter("doctorId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetDoctorSpecialities_Result>("usp_GetDoctorSpecialities", doctorIdParameter);
        }
    
        public virtual ObjectResult<usp_SelectAllSpecialities_Result> usp_SelectAllSpecialities()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectAllSpecialities_Result>("usp_SelectAllSpecialities");
        }
    }
}
