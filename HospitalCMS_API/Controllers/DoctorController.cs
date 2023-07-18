using HospitalCMS_API.Data;
using HospitalCMS_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HospitalCMS_API.Controllers
{
    [Route("api/v1/hospital/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<DoctorModelDto>> FetchDoctorsData()
        {
            return Ok(SeedDoctors.hospitalDoctors);
        }

        [HttpGet("doctorName", Name = "GetDoctor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DoctorModelDto> FetchDoctorData(string lastName)
        {
            var doctorData = SeedDoctors.hospitalDoctors.FirstOrDefault(
                doctor => doctor.LastName == lastName);

            if (doctorData == null) return NotFound();

            return Ok(doctorData);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateDoctorData([FromBody] DoctorModelDto newDoctor)
        {
            if (newDoctor == null || newDoctor.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            else if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingDoctor = SeedDoctors.hospitalDoctors.FirstOrDefault(doctor => doctor.Id == newDoctor.Id);

            if (existingDoctor != null)
            {
                ModelState.AddModelError("ValidateError", "Doctor already exists in the system");
                return BadRequest(ModelState);
            }

            SeedDoctors.hospitalDoctors.Add(newDoctor);
            return CreatedAtRoute("GetDoctor", new { id = newDoctor.Id }, newDoctor);
        }
    }
}
