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
                new IdentityRole { Name = SD.SystemManager, NormalizedName = "SYSTEMMANAGER" }, 
                new IdentityRole { Name = SD.HealthFacilitiesAdministrator, NormalizedName = "HEALTHFACILITIESADMINISTRATOR" },
                new IdentityRole { Name = SD.HealthFacilityManager, NormalizedName = "HEALTHFACILITYAMANAGER" },
                new IdentityRole { Name = SD.Physician, NormalizedName = "PHYSICIAN" },
                new IdentityRole { Name = SD.Nurse, NormalizedName = "NURSE" },
                new IdentityRole { Name = SD.Pharmacist, NormalizedName = "PHARMACIST" },
                new IdentityRole { Name = SD.Patient, NormalizedName = "PATIENT" }
                );
        }
    }
}
