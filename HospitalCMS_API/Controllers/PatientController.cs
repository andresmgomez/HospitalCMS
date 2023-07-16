using HospitalCMS_API.Data;
using HospitalCMS_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HospitalCMS_API.Controllers
{
    [Route("api/v1/hospital/patients")]
    [ApiController]
    public class PatientController : ControllerBase 
    {
        [HttpGet]
        public ActionResult<IEnumerable<PatientModelDto>> FetchPatientsData()
        {
            return Ok(SeedPatients.samplePatients);
        }

        [HttpGet("{patientId:int}")]
        public ActionResult<PatientModelDto> FetchPatientData(int patientId)
        {

            if (patientId == 0)
            {
                return BadRequest();

            }

            var patientData = SeedPatients.samplePatients.FirstOrDefault(
                patient => patient.Id == patientId
                );
 
            if (patientData == null)
            {
                return NotFound();
            }

            return Ok(patientData);
        }
    }
}
