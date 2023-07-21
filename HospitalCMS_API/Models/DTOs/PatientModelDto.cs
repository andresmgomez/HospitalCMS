using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class PatientModelDto
    {
        [Range(5.1, 6.5)]
        public decimal Height { get; set; }

        [Range(120.1, 250.6)]
        public decimal Weight { get; set; }

        [StringLength(20, MinimumLength = 6, ErrorMessage = "Marital Status cannot be less than 6 characters")]
        public string MaritalStatus { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
