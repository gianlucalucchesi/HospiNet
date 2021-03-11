using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class RoomDTO
    {
        public string roomName { get; set; }
        public string hospitalName { get; set; }
    }

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

        //DTO = Data Transfer Object
        [HttpPost]
        [Route("api/hospitals/AddRoom")]
        public IHttpActionResult AddRoom([FromBody] RoomDTO room)
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

        [HttpPost]
        [Route("api/hospitals/AddHospital")]
        public IHttpActionResult AddHospital([FromBody] Models.ModHospital oHospital)
        {
            BusinessLogic.BlHospitals oData = new BusinessLogic.BlHospitals();

            try
            {
                oData.AddHospital(oHospital);
                return Created("Database", oHospital.Name);
            }
            catch (Exception)
            {
                return Conflict();
            }
        }
    }
}
