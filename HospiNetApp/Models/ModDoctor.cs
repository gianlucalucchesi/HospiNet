using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospiNetApp.Models
{
    public class ModDoctor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RegistrationNumber { get; set; }
        public List<ModSpeciality> Specialities { get; set; }
    }
}