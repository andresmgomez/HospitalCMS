using HospitalCMS_API.Data;
using HospitalCMS_API.Models.DTOs;
using Microsoft.AspNetCore.JsonPatch;
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

        [HttpGet("patient", Name = "GetPatient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PatientModelDto> FetchPatientData(string lastName)
        {
            var patientData = SeedPatients.samplePatients.FirstOrDefault(
                patient => patient.LastName == lastName
                );

            if (patientData == null)
            {
                ModelState.AddModelError("ValidateError", "An error has occured. Last name is case sensitive");
                return BadRequest(ModelState);
            }

            return Ok(patientData);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<PatientModelDto> CreatePatientData([FromBody] PatientModelDto newPatient)
        {
            if (newPatient == null || newPatient.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            else if (!ModelState.IsValid) {
                return BadRequest(newPatient); 
            };

            var existingPatient = SeedPatients.samplePatients.FirstOrDefault(patient => patient.Id == newPatient.Id);

            if (existingPatient != null)
            {
                ModelState.AddModelError("ValidateError", "Patient already exists in the system");
                return BadRequest(ModelState);
            }
 
            SeedPatients.samplePatients.Add(newPatient);
            return CreatedAtRoute("GetPatient", new { id = newPatient.Id  }, newPatient);
        }

        [HttpPatch("{patientId:int}", Name = "UpdatePatient")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePatientData(int patientId, JsonPatchDocument<PatientModelDto> updatePatient)
        {
            if (updatePatient == null || patientId == 0) return BadRequest();
           
            var patientRecord = SeedPatients.samplePatients.FirstOrDefault(patient => patient.Id == patientId);

            if (patientRecord == null) return BadRequest();

            updatePatient.ApplyTo(patientRecord, ModelState);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return NoContent();
        }
    }
}
