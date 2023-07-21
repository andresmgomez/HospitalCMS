using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalCMS_API.Models
{
    public class PatientModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public decimal Height { get; set; } = 5.7M;

        [Required]
        [DefaultValue(135.5)]
        [Range(120.1, 250.6)]
        public decimal Weight { get; set; } = 135.5M;

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Legal Sex cannot be less than 4 characters")]
        [DefaultValue("Gender")]
        public string LegalSex { get; set; } = "Gender";

        [StringLength(20, MinimumLength = 6, ErrorMessage = "Marital Status cannot be less than 6 characters")]
        [DefaultValue("Single")]
        public string MaritalStatus { get; set; } = "Single";

        [Required]
        [StringLength(30, MinimumLength = 16, ErrorMessage = "Race cannot be less than 16 characters")]
        [DefaultValue("Cultural Race")]
        public string Race { get; set; } = "Cultural Race";

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Ethnicity cannot be less than 5 characters")]
        [DefaultValue("American")]
        public string Ethnicity { get; set; } = "American";

        [StringLength(15, MinimumLength = 6, ErrorMessage = "Language cannot be less than 15 characters")]
        [DefaultValue("English")]
        public string Language { get; set; } = "English";

        private DateTime? registerDate = null;
        public DateTime? UpdateDate = null;

        public DateTime RegisterDate
        {
            get
            {
                return registerDate.HasValue ? registerDate.Value : DateTime.Now;
            }

            set { registerDate = value; }
        }

    }
}
