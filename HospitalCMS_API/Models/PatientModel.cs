using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalCMS_API.Models
{
    public class PatientModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string LegalSex { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Ethnicity { get; set; }
        public string Language { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
