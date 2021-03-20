using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ModAppointment
    {
        public int? Id { get; set; }
        public string HospitalName { get; set; }
        public string RoomName { get; set; }
        public ModPatient Patient { get; set; }
        public string DoctorName { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public bool Confirmed { get; set; }
    }
}
