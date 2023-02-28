using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Extensions;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class GovernorateConfiguration : IEntityTypeConfiguration<Governorate>
    {
        public void Configure(EntityTypeBuilder<Governorate> builder)
        {
            builder.HasData(
                new Governorate
                {
                    Id = 1,
                    Title = "القاهرة",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                },
                new Governorate
                {
                    Id = 2,
                    Title = "الجيزة",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                },
                new Governorate
                {
                    Id = 3,
                    Title = "مطروح",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                },
                new Governorate
                {
                    Id = 4,
                    Title = "شمال سيناء",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                },
                new Governorate
                {
                    Id = 5,
                    Title = "الشرقية",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                }, 
                new Governorate
                {
                    Id = 6,
                    Title = "الدقهلية",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                });
        }
    }
}
