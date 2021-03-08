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
            var lstHospitals = oData.GetAllHospitals();

            if (lstHospitals != null)
                return Ok(lstHospitals);
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

        [HttpGet]
        [Route("api/hospitals/GetAllRooms")]
        public IHttpActionResult GetAllRooms()
        {
            BusinessLogic.BlHospitals oData = new BusinessLogic.BlHospitals();
            var lstRooms = oData.GetAllRooms();

            if (lstRooms != null)
            {
                return Ok(lstRooms);
            } else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("api/hospitals/AddRoom")]
        public IHttpActionResult AddRoom(dynamic room)
        {
            BusinessLogic.BlHospitals oData = new BusinessLogic.BlHospitals();

            try
            {
                oData.AddRoom(room.roomName, room.hospitalName);
                return Created("Database", room.roomName);
            }
            catch (Exception)
            {
                return Conflict();
            }
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
