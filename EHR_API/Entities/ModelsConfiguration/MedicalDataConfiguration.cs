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
                    FamilyHistory = "الجد من الأب كان مصاب بالسكري",
                    MedicalHistory = "",
                    DNAImageResultUrl = "",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalData
                {
                    Id = "12345678912352",
                    BloodGroup = "O+",
                    FamilyHistory = "الجد من الأب كان مصاب بمرض ذهني",
                    MedicalHistory = "المريض أصيب بحالة من الهلوسة مرتين سابقا",
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
