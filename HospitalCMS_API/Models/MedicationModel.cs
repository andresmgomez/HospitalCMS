namespace HospitalCMS_API.Models
{
    public class MedicationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Type { get; set; }
        public int Intake { get; set; }
        public string Duration { get; set; }
        public string Treatment { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime Prescribed { get; set; }
        public int RefillsNumber { get; set; }
    }
}
