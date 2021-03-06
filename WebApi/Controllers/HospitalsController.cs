using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class HospitalsController : ApiController
    {
        [HttpGet]
        [Route("api/hospitals/GetAllHospitals")]
        public IHttpActionResult GetAllHospitals()
        {
            BusinessLogic.BlHospitals oData = new BusinessLogic.BlHospitals();
            var hospitals = oData.GetAllHospitals();

            if (hospitals != null)
                return Ok(hospitals);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("api/hospitals/UserExists")]
        public IHttpActionResult UserExists(string FirstName, string LastName, string Type)
        {
            BusinessLogic.BlHospitals oData = new BusinessLogic.BlHospitals();
            var userId = oData.UserExists(FirstName, LastName, Type);

            if (userId != null)
                return Ok(userId);
            else
                return NotFound();
        }

        //// GET: api/Hospitals/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Hospitals
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Hospitals/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Hospitals/5
        //public void Delete(int id)
        //{
        //}
    }
}
