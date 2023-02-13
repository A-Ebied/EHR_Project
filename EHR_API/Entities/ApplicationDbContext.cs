using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.ModelsConfiguration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Entities
{
    public class ApplicationDbContext : IdentityDbContext<RegistrationData>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            InitalizeContext();
        }

        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<HealthFacility> HealthFacilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ApplyConfiguration
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            // ToTable
            modelBuilder.Entity<Governorate>().ToTable("Governorate");
            modelBuilder.Entity<HealthFacility>().ToTable("HealthFacility");

            //one-to-one
            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.PersonalData)
               .WithOne(p => p.RegistrationData)
               .HasForeignKey<PersonalData>(p => p.Id);

            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.MedicalData)
               .WithOne(p => p.RegistrationData)
               .HasForeignKey<MedicalData>(p => p.Id);

            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.InsuranceData)
               .WithOne(p => p.RegistrationData)
               .HasForeignKey<InsuranceData>(p => p.Id);

        }


        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            Database.SetCommandTimeout(360);
        }
    }
}
