using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class PersonalDataConfiguration : IEntityTypeConfiguration<PersonalData>
    {
        public void Configure(EntityTypeBuilder<PersonalData> builder)
        {
            builder.HasData(
                new PersonalData
                {
                    Id = "12345678912351",
                    UserImageUrl = "",
                    Occupation = "مدرس",
                    NumOfChildren = 3,
                    BirthDate = DateTime.Parse("1990/1/1"),
                    GovernorateId = 1,
                    Address = "",
                    Phone1 = "01234546787",                  
                    EmergencyPhone1 = "01234546788",                  
                    EmergencyPhone2 = "",
                    Gender = "ذكر",                  
                    AgeGroup = "",                  
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new PersonalData
                {
                    Id = "12345678912352",
                    UserImageUrl = "",
                    Occupation = "دكتور جامعي",
                    NumOfChildren = 1,
                    BirthDate = DateTime.Parse("1960/1/1"),
                    GovernorateId = 3,
                    Address = "",
                    Phone1 = "01234544487",
                    EmergencyPhone1 = "01234746788",
                    EmergencyPhone2 = "",
                    Gender = "ذكر",
                    AgeGroup = "",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new PersonalData
                {
                    Id = "12345678912353",
                    UserImageUrl = "",
                    Occupation = "عمل حر",
                    NumOfChildren = 3,
                    BirthDate = DateTime.Parse("1980/1/1"),
                    GovernorateId = 2,
                    Address = "",
                    Phone1 = "01234500787",
                    EmergencyPhone1 = "01234506788",
                    EmergencyPhone2 = "",
                    Gender = "ذكر",
                    AgeGroup = "",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
