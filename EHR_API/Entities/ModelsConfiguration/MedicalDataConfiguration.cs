using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class MedicalDataConfiguration : IEntityTypeConfiguration<MedicalData>
    {
        public void Configure(EntityTypeBuilder<MedicalData> builder)
        {
            builder.HasData(
                new MedicalData
                {
                    Id = "12345678912351",
                    BloodGroup = "A+",
                    FamilyHistory = "Paternal grandfather had diabetes",
                    MedicalHistory = "",
                    DNAImageResultUrl = "",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalData
                {
                    Id = "12345678912352",
                    BloodGroup = "O+",
                    FamilyHistory = "The paternal grandfather had a mental illness.",
                    MedicalHistory = "The patient had hallucinations twice previously.",
                    DNAImageResultUrl = "",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalData
                {
                    Id = "12345678912353",
                    BloodGroup = "AB+",
                    FamilyHistory = "",
                    MedicalHistory = "",
                    DNAImageResultUrl = "",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
