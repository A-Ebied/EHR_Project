using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class MedicationConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure(EntityTypeBuilder<Medication> builder)
        {
            builder.HasData(
                new Medication
                {
                    Id = 1,
                    Name = "Fexofenadine",
                    Description = "Route, Oral",
                    Contraindication = "Forbidden for patients with kidneys and liver.",
                    ImageUrl = "/files/Medication/fexofenadine.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 2,
                    Name = "Nasonex",
                    Description = "Nasal Spray",
                    Contraindication = "-",
                    ImageUrl = "/files/Medication/NASONEX.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 3,
                    Name = "Panadol Advance",
                    Description = "Route, Oral",
                    Contraindication = "Do not use with any other paracetamol containing products.",
                    ImageUrl = "/files/Medication/advance.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 4,
                    Name = "Kerovit",
                    Description = "Route, Oral",
                    Contraindication = "-",
                    ImageUrl = "/files/Medication/Kerovit.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 5,
                    Name = "Cipro",
                    Description = "Route, Oral",
                    Contraindication = "Allergy to any of the components of the drug",
                    ImageUrl = "/files/Medication/CiproCoupons.png",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 5,
                    Name = "Oracea",
                    Description = "Route, Oral",
                    Contraindication = "Allergy to any of the components of the drug",
                    ImageUrl = "/files/Medication/Oracea.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
