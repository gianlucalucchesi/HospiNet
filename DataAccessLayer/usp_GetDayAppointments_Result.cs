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
    
    public partial class usp_GetDayAppointments_Result
    {
        public int Id { get; set; }
        public System.Guid DoctorId { get; set; }
        public string SpecialityName { get; set; }
        public int ConsultationTime { get; set; }
        public string HospitalName { get; set; }
        public string RoomName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateTimeStart { get; set; }
        public System.DateTime DateTimeEnd { get; set; }
        public bool Confirmed { get; set; }
    }
}
