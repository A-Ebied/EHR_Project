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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

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

            //modelBuilder.Entity<RegistrationData>(b =>
            //{
            //    b.Property(u => u.PhoneNumber).d;
                
            //});

        }
    }
}
