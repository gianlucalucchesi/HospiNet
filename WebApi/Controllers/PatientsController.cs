using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace WebApi.Controllers
{
    public class PatientsController : ApiController
    {
        [HttpGet]
        [Route("api/patients/GetAll")]
        public IHttpActionResult GetAllPatients()
        {
            BusinessLogic.BlPatients oData = new BusinessLogic.BlPatients();
            var patients = oData.GetAllPatients();

            if (patients != null)
                return Ok(patients); // Status 200
            else
                return NotFound(); // Status 404
        }

        [HttpPost]
        [Route("api/patients/Add")]
        public IHttpActionResult AddPatient([FromBody] Models.ModPatient oPatient)
        {
            BusinessLogic.BlPatients oData = new BusinessLogic.BlPatients();
            var guid = oData.AddPatient(oPatient);

            if (guid != null)
                return Created("Database", oPatient); //Status 201
            else
                return Conflict(); //Status 409
        }

        [HttpPut]
        [Route("api/patients/Update")]
        public IHttpActionResult UpdatePatient([FromBody] Models.ModPatient oPatient)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            BusinessLogic.BlPatients oData = new BusinessLogic.BlPatients();
            bool success = oData.UpdatePatient(oPatient);

            if (success)
                return Ok();
            else
                return NotFound();
        }
    }
}
