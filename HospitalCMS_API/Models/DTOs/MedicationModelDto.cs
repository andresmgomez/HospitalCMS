using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class MedicationModelDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [DefaultValue("Acetaminophen")]
        [StringLength(40, ErrorMessage = "Medication name cannot be greater than 40 characters")]
        public string Name { get; set; } = "Acetaminophen";

        [Required]
        [DefaultValue("150 mg")]
        [StringLength(30, ErrorMessage = "Medication dosage cannot be greater than 40 characters")]
        public string Dosage { get; set; }  = "150 mg";

        [Required]
        [DefaultValue("Tablet")]
        [StringLength(10, ErrorMessage = "Medication type cannot be greater than 10 characters")]
        public string Type { get; set; } = "Tablet";

        [Required]
        [DefaultValue(2)]
        [Range(1, 5)]
        public int IntakeAmount { get; set; } = 2;

        [Required]
        [DefaultValue("every 6 hours")]
        [StringLength(25, ErrorMessage = "Medication intake cannot be greater than 25 characters")]
        public string IntakeTimes { get; set; } = "every 6 hours";

        [Required]
        [DefaultValue("Pain")]
        [StringLength(20, ErrorMessage = "Medication treatment cannot be greater than 20 characters")]
        public string Treatment { get; set;} = "Pain";
    }
}
