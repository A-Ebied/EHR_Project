using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using Microsoft.AspNetCore.Identity;
using EHR_API.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class UsersConfiguration : IEntityTypeConfiguration<RegistrationData>
    {
        private ApplicationDbContext _db;
        public UsersConfiguration(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Configure(EntityTypeBuilder<RegistrationData> builder)
        {
            builder.HasData(
               new RegistrationData
               {
                   Id = "12345678912345",
                   IdType = "الهوية الوطنية",
                   Nationality = "مصري",
                   FullName = "أحمد محمد كمال",
                   UserName = "@Kamal123",
                   Email = "k@gmail.com",
                   PasswordHash = "123@Kk",
                   PhoneNumber = "01234567890",
               },
                new RegistrationData
                {
                    Id = "12345678912341",
                    IdType = "الهوية الوطنية",
                    Nationality = "مصري",
                    FullName = "أحمد محمد أحمد",
                    UserName = "@Ahmed123",
                    Email = "A@gmail.com",
                    PasswordHash = "123@Aa",
                    PhoneNumber = "01234567891"
                },
                new RegistrationData
                {
                    Id = "12345678921345",
                    IdType = "الهوية الوطنية",
                    Nationality = "مصري",
                    FullName = "أحمد محمد محمد",
                    UserName = "@Muhammad123",
                    Email = "M@gmail.com",
                    PasswordHash = "123@Mm",
                    PhoneNumber = "01234567899"
                },
               new RegistrationData
               {
                   Id = "12345678912345",
                   IdType = "الهوية الوطنية",
                   Nationality = "مصري",
                   FullName = "أحمد محمد كمال",
                   UserName = "@Kamal123",
                   Email = "k@gmail.com",
                   PasswordHash = "123@Kk",
                   PhoneNumber = "01234567890"
               });
        }
    }
}
