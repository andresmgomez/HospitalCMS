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
        public IEnumerable<PatientModelDto> FetchPatientsData()
        {
            return SeedPatients.samplePatients;
        }
        [HttpGet("patientId")]
        public PatientModelDto FetchPatientData(int patientId)
        {
            var patientData = SeedPatients.samplePatients.FirstOrDefault(
                patient => patient.Id == patientId
                );
            return patientData;
        }
    }
}
