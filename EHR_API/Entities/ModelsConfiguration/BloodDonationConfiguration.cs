using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class BloodDonationConfiguration : IEntityTypeConfiguration<BloodDonation>
    {
        public void Configure(EntityTypeBuilder<BloodDonation> builder)
        {
            builder.HasData(
                new BloodDonation
                {
                    Id = 1,
                    DonationDateTime = DateTime.Now,
                    RegistrationDataId = "12345678912351",
                    MedicalTeamId = "12345678912347",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new BloodDonation
                {
                    Id = 2,
                    DonationDateTime = DateTime.Now,
                    MedicalTeamId = "12345678912347",
                    RegistrationDataId = "12345678912352",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
