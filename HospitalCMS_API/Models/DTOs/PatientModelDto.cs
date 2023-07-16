namespace HospitalCMS_API.Models.DTOs
{
    public class PatientModelDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string Ethnicity { get; set; }
        public string Language { get; set; }
    }
}
