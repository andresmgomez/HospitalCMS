namespace HospitalCMS_API.Models.DTOs
{
    public class MedicationModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Type { get; set; }
        public int Intake { get; set; }
        public string Duration { get; set; }
        public string Treatment { get; set;}

    }
}
