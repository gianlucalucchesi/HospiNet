using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace WebApi.Controllers
{
    public class DoctorsController : ApiController
    {
        [HttpGet]
        [Route("api/doctors/GetAll")]
        public IHttpActionResult GetAll()
        {
            BusinessLogic.BlDoctors oData = new BusinessLogic.BlDoctors();
            var doctors = oData.GetAllDoctors();

            if (doctors != null)
                return Ok(doctors);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("api/doctors/specialities")]
        public IHttpActionResult GetAllSpecialities()
        {
            BusinessLogic.BlDoctors oData = new BusinessLogic.BlDoctors();
            var specialities = oData.GetAllSpecialities();

            //return specialities != null ? Ok(specialities) : NotFound(); //Not available in C#7

            if (specialities != null)
                return Ok(specialities);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("api/doctors/getDoctorBasedOnSpeciality")]
        public IHttpActionResult GetDoctorBasedOnSpeciality(string speciality)
        {
            BusinessLogic.BlDoctors oData = new BusinessLogic.BlDoctors();
            var doctor = oData.GetDoctorBasedOnSpeciality(speciality);

            if (doctor != null)
                return Ok(doctor);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("api/doctors/GetAppointments")]
        public IHttpActionResult GetAppointments(Guid doctorId)
        {
            BusinessLogic.BlDoctors oData = new BusinessLogic.BlDoctors();
            var appointments = oData.GetAppointments(doctorId);

            if (appointments != null)
                return Ok(appointments);
            else
                return NotFound();
        }

        [HttpPost]
        [Route("api/doctors/Add")]
        public IHttpActionResult AddDoctor(Models.ModDoctor oDoctor)
        {
            BusinessLogic.BlDoctors oData = new BusinessLogic.BlDoctors();

            try
            {
                oData.AddDoctor(oDoctor);
                return Created("Database", oDoctor);
            }
            catch (Exception)
            {
                return Conflict();
            }
        }

        [HttpGet]
        [Route("api/doctors/ConfirmAppointment")]
        public IHttpActionResult ConfirmAppointment(int appointmentId)
        {
            BusinessLogic.BlDoctors oData = new BusinessLogic.BlDoctors();

            try
            {
                oData.ConfirmAppointment(appointmentId);
                return Ok(appointmentId);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}