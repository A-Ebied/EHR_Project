using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class UserInsuranceConfiguration : IEntityTypeConfiguration<UserInsurance>
    {
        public void Configure(EntityTypeBuilder<UserInsurance> builder)
        {
            builder.HasData(
                new UserInsurance
                {
                    Id = 1,
                    InsuranceNo = "123OP",
                    InsuranceType = "Governmental",
                    InsuranceOrganizationName = "Egyptian health insurance",
                    RegistrationDataId = "12345678912351",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new UserInsurance
                {
                    Id = 2,
                    InsuranceNo = "124OP",
                    InsuranceType = "Governmental",
                    InsuranceOrganizationName = "Egyptian health insurance",
                    RegistrationDataId = "12345678912352",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
