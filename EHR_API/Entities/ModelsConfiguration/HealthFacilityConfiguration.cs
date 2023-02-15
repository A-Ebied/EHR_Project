using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;
using Microsoft.AspNetCore.Identity;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class HealthFacilityConfiguration : IEntityTypeConfiguration<HealthFacility>
    {
        private UserManager<RegistrationData> _db;
        public HealthFacilityConfiguration(UserManager<RegistrationData> db)
        {
            _db = db;
        }

        public async void Configure(EntityTypeBuilder<HealthFacility> builder)
        {
            var user =  await _db.GetUsersInRoleAsync(SD.HealthFacilityManager) as List<RegistrationData>;

            builder.HasData(
                new HealthFacility
                {
                    Id = user[0].Id,
                    Title = "المستشفى العسكري بالشرقية",
                    Type = "مستشفى عسكري",
                    SubordinateTo = "المؤسسة العسكرية",
                    Phone1 = "01123456878",
                    Phone2 = "",
                    Phone3 = "",
                    Email = "m@gmail.com",
                    Address = "Address1",
                    Description = "Description1",
                },
                 new HealthFacility
                 {
                     Id = user[1].Id,
                     Title = "المستشفى العام بالعريش",
                     Type = "مستشفى عام",
                     SubordinateTo = "وزارة الصحة",
                     Phone1 = "01122456878",
                     Phone2 = "",
                     Phone3 = "",
                     Email = "a@gmail.com",
                     Address = "Address2",
                     Description = "Description2",
                 },
                  new HealthFacility
                  {
                      Id = user[3].Id,
                      Title = "مستشفى الجامعة بالزقازيق",
                      Type = "مستشفى جامعي",
                      SubordinateTo = "مستشفيات الجامعة",
                      Phone1 = "01123416878",
                      Phone2 = "",
                      Phone3 = "",
                      Email = "j@gmail.com",
                      Address = "Address3",
                      Description = "Description3",
                  });
        }
    }
}
