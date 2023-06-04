using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class AllergyConfiguration : IEntityTypeConfiguration<Allergy>
    {
        public void Configure(EntityTypeBuilder<Allergy> builder)
        {
            builder.HasData(
                new Allergy
                {
                    Id = 1,
                    Type = "Dust allergy",
                    Allergen = "Dust mites, Pollen, Pet hair, fur, feathers",
                    Reaction = "Sneezing ,Runny or stuffy nose, coughing, tightness in the chest, shortness of breath",
                    Instruction = "Avoid allergens",
                    IsChronic = true,
                    RegistrationDataId = "12345678912351",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Allergy
                {
                    Id = 2,
                    Type = "حساسية الطعام",
                    Allergen = "الفول السوداني والحليب والبيض",
                    Reaction = "طفح جلدي",
                    Instruction = "",
                    IsChronic = true,
                    RegistrationDataId = "12345678912352",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Allergy
                {
                    Id = 3,
                    Type = "حساسية الحيوانات الأليفة",
                    Allergen = "فراء الحيوانات ، وخاصة من الحيوانات الأليفة مثل القطط والكلاب",
                    Reaction = "ضيق في الصدر وفقدان أنفاسك",
                    Instruction = "الابتعاد عن الحيوانات الأليفة",
                    IsChronic = true,
                    RegistrationDataId = "12345678912353",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
