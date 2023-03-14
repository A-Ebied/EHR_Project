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
                Id = "12345678912341",
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
                Id = "12345678912342",
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
                Id = "12345678912343",
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
                Id = "12345678912344",
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
             
            user = new RegistrationData
            {
                Id = "12345678912346",
                Nationality = "مصري",
                FullName = "أحمد خاطر علي",
                UserName = "@Khater123",
                NormalizedUserName = "@KHATER123",
                Email = "Ka@gmail.com",
                NormalizedEmail = "KA@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912347",
                Nationality = "مصري",
                FullName = "منال خاطر علي",
                UserName = "@Manal123",
                NormalizedUserName = "@MANAL123",
                Email = "Ma@gmail.com",
                NormalizedEmail = "MA@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912348",
                Nationality = "مصري",
                FullName = "منال خاطر أحمد",
                UserName = "@Manal2123",
                NormalizedUserName = "@MANAL2123",
                Email = "Ma2@gmail.com",
                NormalizedEmail = "MA2@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912349",
                Nationality = "مصري",
                FullName = "خاطر أحمد",
                UserName = "@Khater2123",
                NormalizedUserName = "@KHATER2123",
                Email = "Ka2@gmail.com",
                NormalizedEmail = "KA2@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912350",
                Nationality = "مصري",
                FullName = "test",
                UserName = "@Test2123",
                NormalizedUserName = "@TEST2123",
                Email = "TE@gmail.com",
                NormalizedEmail = "TE@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912351",
                Nationality = "مصري",
                FullName = "أحمد فوزي محمد",
                UserName = "@Fawzy123",
                NormalizedUserName = "@FAWZY123",
                Email = "Fa@gmail.com",
                NormalizedEmail = "FA@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912352",
                Nationality = "مصري",
                FullName = "علي فوزي محمد",
                UserName = "@AliFawzy123",
                NormalizedUserName = "@ALIFAWZY123",
                Email = "AlFa@gmail.com",
                NormalizedEmail = "ALFA@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912353",
                Nationality = "مصري",
                FullName = "علي فوزي أحمد",
                UserName = "@AFawzy123",
                NormalizedUserName = "@AFAWZY123",
                Email = "AFa@gmail.com",
                NormalizedEmail = "AFA@GMAIL.COM",
                PhoneNumber = "",
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            builder.HasData(registrations);
        }
    }
}
