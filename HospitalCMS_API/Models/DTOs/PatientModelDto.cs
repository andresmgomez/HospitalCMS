using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class PatientModelDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First name cannot be less than 5 characters")]
        [DefaultValue("First Name")]
        public string FirstName { get; set; } = "First Name";

        [Required]
        [StringLength(30, MinimumLength = 7, ErrorMessage = "Last name cannot be less than 7 characters")]
        [DefaultValue("Last Name")]
        public string LastName { get; set; } = "Last Name";

        [Required]
        [DefaultValue(57)]
        [Range(5, 100)]
        public int Age { get; set; } = 57;

        [Required]
        [DefaultValue(5.7)]
        [Range(5.1, 6.5)]
        public double Height { get; set; } = 5.7;

        [Required]
        [DefaultValue("American")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Ethnicity cannot be less than 8 characters")]
        public string Ethnicity { get; set; } = "American";
        
        [DefaultValue("English")]
        public string Language { get; set; } = "English";
    }
}
