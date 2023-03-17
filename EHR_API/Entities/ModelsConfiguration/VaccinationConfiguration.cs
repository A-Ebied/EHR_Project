using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class VaccinationConfiguration : IEntityTypeConfiguration<Vaccination>
    {
        public void Configure(EntityTypeBuilder<Vaccination> builder)
        {
            builder.HasData(
                new Vaccination
                {
                    Id = 1,
                    Name = "Vaxchora",
                    Type = "حبوب",
                    Route ="عن طريق الفم",
                    Reason = "لقاح يستخدم للوقاية من الكوليرا",
                    AgeRange = "2-64 عام",
                    VaccinationEffectiveness = "3-6 أشهر",
                    Dosage = "1 dose",
                    Contraindication = "",
                    SideEffects = "",
                    Note = "",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Vaccination
                {
                    Id = 2,
                    Name = "Dukoral",
                    Type = "حبوب",
                    Route = "عن طريق الفم",
                    Reason = "لقاح يستخدم للوقاية من الكوليرا",
                    AgeRange = "من عامين وأكبر",
                    VaccinationEffectiveness = "عامين",
                    Dosage = "2 doses, given 1–6 weeks apart ",
                    Contraindication = "",
                    SideEffects = "",
                    Note = "Children aged 2–5 years need 3 doses, given 1 to 6 weeks apart",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
