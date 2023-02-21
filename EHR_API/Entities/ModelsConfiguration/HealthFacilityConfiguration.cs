using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Extensions;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;

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
                     Title = "المستشفى العسكري بالشرقية",
                     Type = "مستشفى عسكري",
                     SubordinateTo = "المؤسسة العسكرية",
                     Phone1 = "01123456878",
                     Phone2 = "",
                     Phone3 = "",
                     Email = "m@gmail.com",
                     Address = "Address1",
                     Description = "Description1",
                     GovernorateId = 1,
                     RegistrationDataId = "12345678912345",
                     CreatedAt = DateTime.Now,
                     UpdateddAt = DateTime.Now,
                 },
                 new HealthFacility
                 {
                     Id = 2,
                     Title = "المستشفى العام بالعريش",
                     Type = "مستشفى عام",
                     SubordinateTo = "وزارة الصحة",
                     Phone1 = "01122456878",
                     Phone2 = "",
                     Phone3 = "",
                     Email = "a@gmail.com",
                     Address = "Address2",
                     Description = "Description2",
                     GovernorateId = 1,
                     RegistrationDataId = "12345678902341",
                     CreatedAt = DateTime.Now,
                     UpdateddAt = DateTime.Now,
                 },
                  new HealthFacility
                  {
                      Id = 3,
                      Title = "مستشفى الجامعة بالزقازيق",
                      Type = "مستشفى جامعي",
                      SubordinateTo = "مستشفيات الجامعة",
                      Phone1 = "01123416878",
                      Phone2 = "",
                      Phone3 = "",
                      Email = "j@gmail.com",
                      Address = "Address3",
                      Description = "Description3",
                      GovernorateId = 1,
                      RegistrationDataId = "12345678921345",
                      CreatedAt = DateTime.Now,
                      UpdateddAt = DateTime.Now,
                  });
        }
    }
}
