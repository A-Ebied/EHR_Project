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
                new IdentityUserRole<string>() 
                { 
                    UserId = "12345678912345",
                    RoleId = "3"
                },
                new IdentityUserRole<string>() 
                { 
                    UserId = "12345678902341",
                    RoleId = "3"
                },
                new IdentityUserRole<string>() 
                { 
                    UserId = "12345678921345",
                    RoleId = "3"
                },
                new IdentityUserRole<string>() 
                { 
                    UserId = "92345678912345",
                    RoleId = "1"
                });
        }
    }
}
