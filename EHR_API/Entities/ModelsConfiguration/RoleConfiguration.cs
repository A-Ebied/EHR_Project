using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Extensions;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = "1", Name = SD.SystemManager, NormalizedName = "SYSTEMMANAGER" }, 
                new IdentityRole { Id = "2", Name = SD.HealthFacilityManager, NormalizedName = "HEALTHFACILITYAMANAGER" },
                new IdentityRole { Id = "3", Name = SD.Physician, NormalizedName = "PHYSICIAN" },
                new IdentityRole { Id = "4", Name = SD.Nurse, NormalizedName = "NURSE" },
                new IdentityRole { Id = "5", Name = SD.Pharmacist, NormalizedName = "PHARMACIST" },
                new IdentityRole { Id = "6", Name = SD.Patient, NormalizedName = "PATIENT" },
                new IdentityRole { Id = "7", Name = SD.Technician, NormalizedName = "TECHNICIAN" }
                );
        }
    }
}
