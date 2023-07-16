using HospitalCMS_API.Models.DTOs;

namespace HospitalCMS_API.Data
{
    public class SeedPatients
    {
        public static List<PatientModelDto> samplePatients = new List<PatientModelDto>
        {
             new PatientModelDto
                {
                    Id = 1,
                    FirstName = "Barbara",
                    LastName = "Leonard",
                    Age = 34,
                    // LegalSex = "Female",
                    // MaritalStatus = "Married",
                    // Race = "Caucasian",
                    Ethnicity = "American",
                    Language = "English"
                },
                 new PatientModelDto
                {
                    Id = 2,
                    FirstName = "Walter",
                    LastName = "Albritton",
                    Age = 75,
                    // LegalSex = "Male",
                    // MaritalStatus = "Divorced",
                    // Race = "Caucasian",
                    Ethnicity = "European",
                    Language = "English"
                },
                  new PatientModelDto
                {
                    Id = 3,
                    FirstName = "Jacques",
                    LastName = "Brown",
                    Age = 46,
                    // LegalSex = "Female",
                    // MaritalStatus = "Married",
                    // Race = "African American",
                    Ethnicity = "Caribbean",
                    Language = "English"
                },
                     new PatientModelDto
                {
                    Id = 4,
                    FirstName = "Willie",
                    LastName = "Smith",
                    Age = 73,
                    // LegalSex = "Male",
                    // MaritalStatus = "Widowed",
                    // Race = "Caucasian",
                    Ethnicity = "American",
                    Language = "English"
                },
                       new PatientModelDto
                {
                    Id = 5,
                    FirstName = "Herbert",
                    LastName = "Ortega",
                    Age = 70,
                    // LegalSex = "Male",
                    // MaritalStatus = "Married",
                    // Race = "Hispanic",
                    Ethnicity = "South American",
                    Language = "Spanish"
                },
                         new PatientModelDto
                {
                    Id = 6,
                    FirstName = "Edna",
                    LastName = "Garret",
                    Age = 63,
                    // LegalSex = "Female",
                    // MaritalStatus = "Divorced",
                    // Race = "Native American",
                    Ethnicity = "American",
                    Language = "English"
                },
                          new PatientModelDto
                {
                    Id = 7,
                    FirstName = "Beryl",
                    LastName = "Coello",
                    Age = 28,
                    // LegalSex = "Female",
                    // MaritalStatus = "Single",
                    // Race = "Caucasian",
                    Ethnicity = "European",
                    Language = "Portuguese"
                },
                           new PatientModelDto
                {
                    Id = 8,
                    FirstName = "Timothy",
                    LastName = "Ford",
                    Age = 65,
                    // LegalSex = "Male",
                    // MaritalStatus = "Divorced",
                    // Race = "Caucasian",
                    Ethnicity = "American",
                    Language = "English"
                },
                             new PatientModelDto
                {
                    Id = 9,
                    FirstName = "Norris",
                    LastName = "McKenney",
                    Age = 74,
                    // LegalSex = "Male",
                    // MaritalStatus = "Widowed",
                    // Race = "Caucasian",
                    Ethnicity = "European",
                    Language = "English"
                },
                             new PatientModelDto
                {
                    Id = 10,
                    FirstName = "Louise",
                    LastName = "Alarcon",
                    Age = 30,
                    // LegalSex = "Female",
                    // MaritalStatus = "Single",
                    // Race = "White Hispanic",
                    Ethnicity = "American",
                    Language = "English"
                }
        };
    }
}
