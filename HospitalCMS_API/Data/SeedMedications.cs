using HospitalCMS_API.Models.DTOs;

namespace HospitalCMS_API.Data
{
    public class SeedMedications
    {
        public static List<MedicationModelDto> patientMedications = new List<MedicationModelDto>
        {
            new MedicationModelDto
            {
                Id = 1,
                Name = "Acetaminophen",
                Dosage = "650 mg",
                Type = "Tablet",
                IntakeAmount = 2,
                IntakeTimes = "every 12 hours",
                Treatment = "Pain"
            },
             new MedicationModelDto
            {
                Id = 2,
                Name = "Fluticasone",
                Dosage = "50 mcg",
                Type = "Spray",
                IntakeAmount = 1,
                IntakeTimes = "by nasal daily",
                Treatment = "Pain"
            },
              new MedicationModelDto
            {
                Id = 3,
                Name = "Lidocaine",
                Dosage = "5 mls",
                Type = "Liquid",
                IntakeAmount = 5,
                IntakeTimes = "every 4 hours",
                Treatment = "Pain"
            }
        };
    }
}
