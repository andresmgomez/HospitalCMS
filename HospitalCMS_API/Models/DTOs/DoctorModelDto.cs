using System.ComponentModel.DataAnnotations;

namespace HospitalCMS_API.Models.DTOs
{
    public class DoctorModelDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DegreeInitials { get; set; }
        public string Specialty { get; set; }

    }
}
