using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class MedicationModelDto
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Type { get; set; }
        public int IntakeAmount { get; set; }
        public string IntakeTimes { get; set; }
        public string Treatment { get; set;}

    }
}
