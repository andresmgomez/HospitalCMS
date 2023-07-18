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
                FirstName = "Omar",
                LastName = "Abbasi",
                DegreeInitials = "MD",
                Specialty = "Psychiatry"
            },
             new DoctorModelDto
            {
                Id = 2,
                FirstName = "Anna",
                LastName = "Abraham",
                DegreeInitials = "MD",
                Specialty = "Hematology"
            },
             new DoctorModelDto
            {
                Id = 3,
                FirstName = "Gil",
                LastName = "Abramovici",
                DegreeInitials = "MD",
                Specialty = "Psychiatry"
            },
              new DoctorModelDto
            {
                Id = 4,
                FirstName = "Alan",
                LastName = "Ackerman",
                DegreeInitials = "MD",
                Specialty = "Cardiology"
            },
               new DoctorModelDto
            {
                Id = 5,
                FirstName = "Daniel",
                LastName = "Aghion",
                DegreeInitials = "MD",
                Specialty = "Neurosurgery"
            },
                new DoctorModelDto
            {
                Id = 6,
                FirstName = "Alan",
                LastName = "Aguila",
                DegreeInitials = "MD",
                Specialty = "Cardiology"
            },
        };
    }
}
