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
        public Guid HospitalId { get; set; }
        public Guid RoomId { get; set; }
        public ModPatient Patient { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime? DateTimeEnd{ get; set; }
        public bool Confirmed { get; set; }
    }
}
