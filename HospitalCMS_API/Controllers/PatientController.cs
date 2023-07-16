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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<PatientModelDto>> FetchPatientsData()
        {
            return Ok(SeedPatients.samplePatients);
        }

        [HttpGet("patientId", Name = "GetPatient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PatientModelDto> FetchPatientData(int patientId)
        {

            if (patientId == 0) return BadRequest();

            var patientData = SeedPatients.samplePatients.FirstOrDefault(
                patient => patient.Id == patientId
                );
 
            if (patientData == null) return NotFound();
            
            return Ok(patientData);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PatientModelDto> CreatePatientData([FromBody] PatientModelDto newPatient)
        {
            if (newPatient == null || newPatient.Id == 0) return BadRequest(newPatient);
          
            SeedPatients.samplePatients.Add(newPatient);
     
            return CreatedAtRoute("GetPatient", new { id = newPatient.Id  }, newPatient);
           
        }
    }
}
