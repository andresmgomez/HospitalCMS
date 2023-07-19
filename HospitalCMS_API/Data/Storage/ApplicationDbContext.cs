using HospitalCMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalCMS_API.Data.Storage
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<MedicationModel> Medications { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
    }
}
