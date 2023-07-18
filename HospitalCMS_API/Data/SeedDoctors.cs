using HospitalCMS_API.Models.DTOs;

namespace HospitalCMS_API.Data
{
    public class SeedDoctors
    {
        public static List<DoctorModelDto> hospitalDoctors = new List<DoctorModelDto>
        {
            new DoctorModelDto
            {
                Name = "Omar Abbasi",
                DegreeInitials = "MD",
                Specialty = "Psychiatry"
            },
             new DoctorModelDto
            {
                Name = "Anna Abraham",
                DegreeInitials = "MD",
                Specialty = "Hematology"
            },
             new DoctorModelDto
            {
                Name = "Gil Abramovici",
                DegreeInitials = "MD",
                Specialty = "Psychiatry"
            },
              new DoctorModelDto
            {
                Name = "Alan Ackerman",
                DegreeInitials = "MD",
                Specialty = "Cardiology"
            },
               new DoctorModelDto
            {
                Name = "Daniel Aghion",
                DegreeInitials = "MD",
                Specialty = "Neurosurgery"
            },
                new DoctorModelDto
            {
                Name = "Alian Aguila",
                DegreeInitials = "MD",
                Specialty = "Cardiology"
            },
        };
    }
}
