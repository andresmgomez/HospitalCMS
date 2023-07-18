using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class DoctorModelDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First name cannot be less than 5 characters")]
        public string FirstName { get; set; }
        [StringLength(30, MinimumLength = 7, ErrorMessage = "Last name cannot be less than 7 characters")]
        [Required]
        public string LastName { get; set; }
        [Required]
        [StringLength(2, ErrorMessage = "Degree initials needs to be 2 characters")]
        public string DegreeInitials { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Specialty needs to be at most 15 characters")]
        public string Specialty { get; set; }

    }
}
