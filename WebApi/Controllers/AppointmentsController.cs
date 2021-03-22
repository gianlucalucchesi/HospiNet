using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class AvailableHospitalsDTO
    {
        public string doctorName { get; set; }
        public string specialityName { get; set; }
    }

    public class AvailableTimesDTO
    {
        public string doctorName { get; set; }
        public string hospitalName { get; set; }
        public string specialityName { get; set; }
    }

    public class AppointmentsController : ApiController
    {
        [HttpPost]
        [Route("api/appointments/add")]
        public IHttpActionResult AddAppointment([FromBody] Models.ModAppointment newAppointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            BusinessLogic.BlAppointment oData = new BusinessLogic.BlAppointment();
            int? appointmentId = oData.AddAppointment(newAppointment);

            if (appointmentId != -1)
                return Created("database", appointmentId);
            else
                return Conflict();
        }

        [HttpGet]
        [Route("api/appointments/GetAvailableHospitals")]
        public IHttpActionResult GetAvailableHospitals(string doctorName, string specialityName)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            BusinessLogic.BlAppointment oData = new BusinessLogic.BlAppointment();
            var lstHospitals = oData.GetAvailableHospitals(doctorName, specialityName);

            if (lstHospitals != null)
                return Ok(lstHospitals);
            else
                return NotFound();
        }
    }
}