using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class BadHabitConfiguration : IEntityTypeConfiguration<BadHabit>
    {
        public void Configure(EntityTypeBuilder<BadHabit> builder)
        {
            builder.HasData(
                new BadHabit
                {
                    Id = 1,
                    Habit = "Smoking",
                    Notes = "",
                    RegistrationDataId = "12345678912351",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new BadHabit
                {
                    Id = 2,
                    Habit = "Smoking",
                    Notes = "",
                    RegistrationDataId = "12345678912352",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new BadHabit
                {
                    Id = 3,
                    Habit = "Drink Wine",
                    Notes = "",
                    RegistrationDataId = "12345678912353",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
