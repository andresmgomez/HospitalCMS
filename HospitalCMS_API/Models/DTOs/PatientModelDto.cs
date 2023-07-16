using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class PatientModelDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First name cannot be less than 5 characters")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 7, ErrorMessage = "Last name cannot be less than 7 characters")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(2)]
        public int Age { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Ethnicity cannot be less than 8 characters")]
        public string Ethnicity { get; set; }
        [DefaultValue("English")]
        public string Language { get; set; } = "English";
    }
}
