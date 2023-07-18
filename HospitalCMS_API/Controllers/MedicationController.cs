using HospitalCMS_API.Data;
using HospitalCMS_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HospitalCMS_API.Controllers
{
    [Route("api/v1/hospital/patients/medications")]
    [ApiController]
    public class MedicationController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MedicationModelDto>> FetchMedicationsData()
        {
            return Ok(SeedMedications.patientMedications);
        }

        [HttpGet("medication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<MedicationModelDto> FetchMedicationData(string medicationName)
        {

            if (medicationName == null)
            {
                return BadRequest();
            }
            var medicationData = SeedMedications.patientMedications.FirstOrDefault(
                medication => medication.Name == medicationName);

            if (medicationData == null)
            {
                ModelState.AddModelError("ValidateError", "An error has occured. Unable to find this medication");
                return BadRequest(ModelState);
            }
            return Ok(medicationData);
        }
    }
}
