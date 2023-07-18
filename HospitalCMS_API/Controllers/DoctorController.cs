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

        [HttpGet("doctorId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DoctorModelDto> FetchDoctorData(int doctorId)
        {
            if (doctorId == 0) return BadRequest();

            var doctorData = SeedDoctors.hospitalDoctors.FirstOrDefault(
                doctor => doctor.Id == doctorId);

            if (doctorData == null) return NotFound();

            return Ok(doctorData);
        }
    }
}
