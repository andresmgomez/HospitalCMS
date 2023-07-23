using HospitalCMS_API.Data;
using HospitalCMS_API.Data.Storage;
using HospitalCMS_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HospitalCMS_API.Controllers
{
    [Route("api/v1/hospital/patients")]
    [ApiController]
    public class PatientController : ControllerBase 
    {
        private readonly ApplicationDbContext _storageContext;

        public PatientController(ApplicationDbContext storageContext)
        {
            _storageContext = storageContext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<PatientModel>> FetchPatientsData()
        {
            return Ok(_storageContext.Patients.ToList());
        }

        [HttpGet("patient", Name = "GetPatient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PatientModel> FetchPatientData(string lastName)
        {
            var patientData = _storageContext.Patients.FirstOrDefault(
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
        public ActionResult<PatientModel> CreatePatientData([FromBody] PatientModel newPatient)
        {
            if (newPatient == null)
            {
                return BadRequest();
            }

            else if (!ModelState.IsValid) {
                return BadRequest(newPatient); 
            };

            var existingPatient = _storageContext.Patients.FirstOrDefault(patient => patient.Id == newPatient.Id);

            if (existingPatient != null)
            {
                ModelState.AddModelError("ValidateError", "Patient already exists in the system");
                return BadRequest(ModelState);
            }
            _storageContext.Patients.Add(newPatient);
            _storageContext.SaveChanges();

            return CreatedAtRoute("GetPatient", new { id = newPatient.Id  }, newPatient);
        }

        [HttpPut("{patientId:int}", Name = "UpdatePatient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdatePatientData(int patientId, [FromBody] PatientModel currentPatient)
        {
            if (patientId == 0) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            else if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _storageContext.Update(currentPatient);
            _storageContext.SaveChanges();

            return Ok(currentPatient);
        }
    }
}
