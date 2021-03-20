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
    }
}