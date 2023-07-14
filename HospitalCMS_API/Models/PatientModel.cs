namespace HospitalCMS_API.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string LegalSex { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Ethnicity { get; set; }
        public string Language { get; set; }
    }
}
