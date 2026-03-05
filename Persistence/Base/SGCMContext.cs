using Microsoft.EntityFrameworkCore;
using SGCM.Entities.Appointments;
using SGCM.Entities.Users;
using SGCM.Entities.Insurance;
using SGCM.Entities.Notifications;

namespace SGCM.Persistence.Context
{   
    public sealed class SGCMContext : DbContext
    {
        public SGCMContext(DbContextOptions<SGCMContext> options) : base(options)
        {

        }
            public DbSet<Appointment> appointments {get;set;}
            public DbSet<MedicalRecords> medicalRecords {get;set;}
            public DbSet<DoctorSchedules> doctorSchedules {get;set;}
            
            public DbSet<Patient> patients {get;set;}
            public DbSet<Doctor> doctors {get;set;}
            public DbSet<Personal> personals {get;set;}
            
            public DbSet<InsurancePlan> insurancePlans {get;set;}
            public DbSet<InsuranceProvider> insuranceProviders {get;set;}
            
            public DbSet<Notification> notifications {get;set;}
        
    }
}