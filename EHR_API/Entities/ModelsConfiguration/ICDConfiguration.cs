using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Extensions;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class ICDConfiguration : IEntityTypeConfiguration<ICD>
    {
        public void Configure(EntityTypeBuilder<ICD> builder)
        {
            builder.HasData(
                new ICD
                {
                    Code = "A00.0",
                    DiagnosisName = "Cholera due to Vibrio cholerae 01, biovar cholerae",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new ICD
                {
                    Code = "A00.1",
                    DiagnosisName = "Cholera due to Vibrio cholerae 01, biovar eltor",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new ICD
                {
                    Code = "A00.9",
                    DiagnosisName = "Cholera, unspecified",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new ICD
                {
                    Code = "A01.00",
                    DiagnosisName = "Typhoid fever, unspecified",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                }
                ,
                new ICD
                {
                    Code = "J18.9",
                    DiagnosisName = "Pneumonia",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                },
                new ICD
                {
                    Code = " I10",
                    DiagnosisName = "Essential (primary) hypertension",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                }
                );
        }
    }
}
