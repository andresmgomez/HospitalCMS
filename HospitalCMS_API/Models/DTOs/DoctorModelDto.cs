using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class DoctorModelDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [DefaultValue("First Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First name cannot be less than 5 characters")]
        public string FirstName { get; set; } = "First Name";

        [Required]
        [DefaultValue("Last Name")]
        [StringLength(30, MinimumLength = 7, ErrorMessage = "Last name cannot be less than 7 characters")]
        public string LastName { get; set; } = "Last Name";

        [Required]
        [DefaultValue("MD")]
        [StringLength(2, ErrorMessage = "Degree initials needs to be 2 characters")]
        public string DegreeInitials { get; set; } = "MD";

        [Required]
        [DefaultValue("Primary Care")]
        [StringLength(15, ErrorMessage = "Specialty needs to be 15 characters")]
        public string Specialty { get; set; } = "Primary Care";
    }
}
