using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
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
            BusinessLogic.BlAppointment oData = new BusinessLogic.BlAppointment();
            var lstHospitals = oData.GetAvailableHospitals(doctorName, specialityName);

            if (lstHospitals != null)
                return Ok(lstHospitals);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("api/appointments/GetAvailableTimeSlots")]
        public IHttpActionResult GetAvailableTimeSlots(string doctorName, string specialityName, string hospitalName, string day)
        {
            BusinessLogic.BlAppointment oData = new BusinessLogic.BlAppointment();
            var lstTimeSlots = oData.GetAvailableTimes(DateTime.Parse(day), doctorName, hospitalName, specialityName);

            if (lstTimeSlots != null)
                return Ok(lstTimeSlots);
            else
                return NotFound();
        }
    }
}