using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class AllergyDrugConfiguration : IEntityTypeConfiguration<AllergyDrug>
    {
        public void Configure(EntityTypeBuilder<AllergyDrug> builder)
        {
            builder.HasData(
                new AllergyDrug
                {
                    AllergyId = 1,
                    MedicationId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new AllergyDrug
                {
                    AllergyId = 1,
                    MedicationId = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
