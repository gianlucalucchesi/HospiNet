using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiNetApp.Models
{
    public class ModAppointmentVw
    {
        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string RoomName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateTimeStart { get; set; }
        public System.DateTime DateTimeEnd { get; set; }
        public bool Confirmed { get; set; }
        public System.Guid DoctorId { get; set; }
    }
}
