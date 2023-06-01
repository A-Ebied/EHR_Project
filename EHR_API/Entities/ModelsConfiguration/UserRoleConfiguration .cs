using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                //SystemManager
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912341",
                    RoleId = "1"
                },
                //HealthFacilityManagers
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912342",
                    RoleId = "2"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912348",
                    RoleId = "2"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912349",
                    RoleId = "2"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912350",
                    RoleId = "2"
                },
                //Physician
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912343",
                    RoleId = "3"
                },
                //Pharmacist
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912344",
                    RoleId = "5"
                },
                //Patients
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912351",
                    RoleId = "6"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912352",
                    RoleId = "6"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912353",
                    RoleId = "6"
                },
                //Technician
                new IdentityUserRole<string>()
                {
                    UserId = "12345678912346",
                    RoleId = "7"
                });
        }
    }
}
