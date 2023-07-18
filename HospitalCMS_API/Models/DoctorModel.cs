namespace HospitalCMS_API.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DegreeInitials { get; set; }
        public string Specialty { get; set; }
        public string QuickDescription { get; set; }
        public string Education { get; set; }
        public string Certifications { get; set; }
        public string Publications { get; set; }
        public string Awards { get; set; }
    }
}
