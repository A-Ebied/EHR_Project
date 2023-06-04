using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class HealthFacilityConfiguration : IEntityTypeConfiguration<HealthFacility>
    {
        public void Configure(EntityTypeBuilder<HealthFacility> builder)
        {
            builder.HasData(
                 new HealthFacility
                 {
                     Id = 1,
                     Title = "Sharkia Military Hospital",
                     Type = "Military Hospital",
                     SubordinateTo = "The military Establishment",
                     Phone1 = "01123456878",
                     Phone2 = "",
                     Phone3 = "",
                     Email = "m@gmail.com",
                     Address = "Address1",
                     Description = "Description1",
                     GovernorateId = 1,
                     MedicalTeamId = "12345678912342",
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                 },
                 new HealthFacility
                 {
                     Id = 2,
                     Title = "Arish Hospital",
                     Type = "Government Hospital",
                     SubordinateTo = "Ministry of Health",
                     Phone1 = "01122456878",
                     Phone2 = "",
                     Phone3 = "",
                     Email = "a@gmail.com",
                     Address = "Address2",
                     Description = "Description2",
                     GovernorateId = 1,
                     MedicalTeamId = "12345678912348",
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                 },
                  new HealthFacility
                  {
                      Id = 3,
                      Title = "University Hospital, Zagazig",
                      Type = "University Hospital",
                      SubordinateTo = "University Hospitals",
                      Phone1 = "01123416878",
                      Phone2 = "",
                      Phone3 = "",
                      Email = "j@gmail.com",
                      Address = "Address3",
                      Description = "Description3",
                      GovernorateId = 1,
                      MedicalTeamId = "12345678912349",
                      CreatedAt = DateTime.Now,
                      UpdatedAt = DateTime.Now,
                  });
        }
    }
}
