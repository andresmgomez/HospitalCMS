using HospitalCMS_API.Models.DTOs;

namespace HospitalCMS_API.Data
{
    public class SeedDoctors
    {
        public static List<DoctorModelDto> hospitalDoctors = new List<DoctorModelDto>
        {
            new DoctorModelDto
            {
                Id = 1,
                Name = "Omar Abbasi",
                DegreeInitials = "MD",
                Specialty = "Psychiatry"
            },
             new DoctorModelDto
            {
                Id = 2,
                Name = "Anna Abraham",
                DegreeInitials = "MD",
                Specialty = "Hematology"
            },
             new DoctorModelDto
            {
                Id = 3,
                Name = "Gil Abramovici",
                DegreeInitials = "MD",
                Specialty = "Psychiatry"
            },
              new DoctorModelDto
            {
                Id = 4,
                Name = "Alan Ackerman",
                DegreeInitials = "MD",
                Specialty = "Cardiology"
            },
               new DoctorModelDto
            {
                Id = 5,
                Name = "Daniel Aghion",
                DegreeInitials = "MD",
                Specialty = "Neurosurgery"
            },
                new DoctorModelDto
            {
                Id = 6,
                Name = "Alian Aguila",
                DegreeInitials = "MD",
                Specialty = "Cardiology"
            },
        };
    }
}
