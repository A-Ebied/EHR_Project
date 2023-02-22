using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Extensions;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class UsersConfiguration : IEntityTypeConfiguration<RegistrationData>
    {
        public void Configure(EntityTypeBuilder<RegistrationData> builder)
        {
            List<RegistrationData> registrations = new();
            var user = new RegistrationData
            {
                Id = "12345678912345",
                Nationality = "مصري",
                FullName = "أحمد محمد كمال",
                UserName = "@Kamal123",
                NormalizedUserName = "@KAMAL123",
                Email = "k@gmail.com",
                NormalizedEmail = "K@GMAIL.COM",
                PhoneNumber = "01234567890",
            };

            PasswordHasher<string> pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678902341",
                Nationality = "مصري",
                FullName = "أحمد محمد أحمد",
                UserName = "@Ahmed123",
                NormalizedUserName = "@AHMED123",
                Email = "A@gmail.com",
                NormalizedEmail = "A@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);
            
            user = new RegistrationData
            {
                Id = "12345678921345",
                Nationality = "مصري",
                FullName = "أحمد محمد محمد",
                UserName = "@Muhammad123",
                NormalizedUserName = "@MUHAMMAD123",
                Email = "M@gmail.com",
                NormalizedEmail = "M@GMAIL.COM",
                PhoneNumber = "01234567899",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);
             
            user = new RegistrationData
            {
                Id = "92345678912345",
                Nationality = "مصري",
                FullName = "أحمد محمد علي",
                UserName = "@Ali123",
                NormalizedUserName = "@ALI123",
                Email = "Al@gmail.com",
                NormalizedEmail = "AL@GMAIL.COM",
                PhoneNumber = "01234567890",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            builder.HasData(registrations);
        }
    }
}
