using HospitalCMS_API.Models;

namespace HospitalCMS_API.Data
{
    public class SeedPatients
    {
        public static List<PatientModel> samplePatients = new List<PatientModel>
        {
             new PatientModel
                {
                    Id = 1,
                    FirstName = "Trinidad",
                    LastName = "Franklin",
                    Age = 55,
                    Height = 5.1M,
                    Weight = 210.5M,
                    LegalSex = "Female",
                    MaritalStatus = "Married",
                    Race = "African American",
                    Ethnicity = "Caribbean",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                      new PatientModel
                {
                    Id = 2,
                    FirstName = "Ashley",
                    LastName = "Castaneda",
                    Age = 23,
                    Height = 5.5M,
                    Weight = 131.8M,
                    LegalSex = "Female",
                    MaritalStatus = "Single",
                    Race = "Hispanic",
                    Ethnicity = "American",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                      new PatientModel
                {
                    Id = 3,
                    FirstName = "Josh",
                    LastName = "McGlade",
                    Age = 32,
                    Height = 5.7M,
                    Weight = 248.8M,
                    LegalSex = "Male",
                    MaritalStatus = "Married",
                    Race = "European American",
                    Ethnicity = "Irish",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                       new PatientModel
                {
                    Id = 4,
                    FirstName = "Shanon",
                    LastName = "Anderson",
                    Age = 68,
                    Height = 5.6M,
                    Weight = 109.3M,
                    LegalSex = "Female",
                    MaritalStatus = "Divorced",
                    Race = "White American",
                    Ethnicity = "American",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                       new PatientModel
                {
                    Id = 5,
                    FirstName = "Wilson",
                    LastName = "Li",
                    Age = 51,
                    Height = 5.11M,
                    Weight = 139.2M,
                    LegalSex = "Male",
                    MaritalStatus = "Married",
                    Race = "Asian American",
                    Ethnicity = "American",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                },
                       new PatientModel
                {
                    Id = 6,
                    FirstName = "Miguel",
                    LastName = "Pena",
                    Age = 39,
                    Height = 5.9M,
                    Weight = 197.3M,
                    LegalSex = "Male",
                    MaritalStatus = "Divorced",
                    Race = "Hispanic",
                    Ethnicity = "South American",
                    Language = "Spanish",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                },
                       new PatientModel
                {
                    Id = 7,
                    FirstName = "Robert",
                    LastName = "Bush",
                    Age = 47,
                    Height = 5.8M,
                    Weight = 233.2M,
                    LegalSex = "Male",
                    MaritalStatus = "Divorced",
                    Race = "European American",
                    Ethnicity = "American",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                },
                       new PatientModel
                {
                    Id = 8,
                    FirstName = "Michelle",
                    LastName = "Hagen",
                    Age = 39,
                    Height = 5.6M,
                    Weight = 210.3M,
                    LegalSex = "Female",
                    MaritalStatus = "Single",
                    Race = "European American",
                    Ethnicity = "Norwegian",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                },
                       new PatientModel
                {
                    Id = 9,
                    FirstName = "Norris",
                    LastName = "McKenney",
                    Age = 55,
                    Height = 6.0M,
                    Weight = 173.8M,
                    LegalSex = "Male",
                    MaritalStatus = "Divorced",
                    Race = "European American",
                    Ethnicity = "Scottish",
                    Language = "English",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now

                },
                       new PatientModel
                {
                    Id = 10,
                    FirstName = "Krista",
                    LastName = "Thomas",
                    Age = 62,
                    Height = 5.3M,
                    Weight = 190.5M,
                    LegalSex = "Female",
                    MaritalStatus = "Married",
                    Race = "Native American",
                    Ethnicity = "American",
                    RegisterDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                }
        };
    }
}
