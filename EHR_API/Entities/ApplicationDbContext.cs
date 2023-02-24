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
            modelBuilder.ApplyConfiguration(new GovernorateConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new HealthFacilityConfiguration());

            //one-to-one
            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.PersonalData)
               .WithOne(r => r.RegistrationData)
               .HasForeignKey<PersonalData>(p => p.Id);

            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.MedicalData)
               .WithOne(r => r.RegistrationData)
               .HasForeignKey<MedicalData>(m => m.Id);

            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.InsuranceData)
               .WithOne(r => r.RegistrationData)
               .HasForeignKey<InsuranceData>(i => i.Id);
 
            modelBuilder.Entity<RegistrationData>()
               .HasOne(m => m.MedicalTeam)
               .WithOne(r => r.RegistrationData)
               .HasForeignKey<MedicalTeam>(m => m.Id);
             
           // modelBuilder.Entity<HealthFacility>()
           //.HasAlternateKey(c => c.RegistrationDataId)
           //.HasName("AlternateKey_RegistrationDataId");
        }


        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            Database.SetCommandTimeout(360);
        }
    }
}
