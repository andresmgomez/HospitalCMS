using HospitalCMS_API.Data;
using HospitalCMS_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HospitalCMS_API.Controllers
{
    [Route("api/v1/hospital/patients/medications")]
    [ApiController]
    public class MedicationController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MedicationModelDto>> FetchMedicationsData()
        {
            return Ok(SeedMedications.patientMedications);
        }

        [HttpGet("medication", Name = "GetMedication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<MedicationModelDto> FetchMedicationData(string medicationName)
        {
            var medicationData = SeedMedications.patientMedications.FirstOrDefault(
                medication => medication.Name == medicationName);

            if (medicationData == null)
            {
                ModelState.AddModelError("ValidateError", "An error has occured. Unable to find this medication");
                return BadRequest(ModelState);
            }
            return Ok(medicationData);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<MedicationModelDto> CreatePatientData([FromBody] MedicationModelDto newMedication)
        {
            if (newMedication == null || newMedication.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            else if (!ModelState.IsValid)
            {
                return BadRequest(newMedication);
            };

            var existingMedication = SeedMedications.patientMedications.FirstOrDefault(medication => medication.Id == newMedication.Id);

            if (existingMedication != null)
            {
                ModelState.AddModelError("ValidateError", "Medication already exists in the system");
                return BadRequest(ModelState);
            }

            SeedMedications.patientMedications.Add(newMedication);
            return CreatedAtRoute("GetMedication", new { id = newMedication.Id }, newMedication);
        }
    }
}
