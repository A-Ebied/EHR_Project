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
                    Name = "Measles, Mumps, and Rubella (MMR)",
                    Type = "Live attenuated vaccine",
                    Route = "Subcutaneous injection",
                    Reason = "Protection against measles, mumps, and rubella",
                    AgeRange = "Typically given in two doses during childhood",
                    VaccinationEffectiveness = "Highly effective in preventing the target diseases",
                    Dosage = "Two doses, usually administered at 12-15 months and 4-6 years of age",
                    Contraindication = "Severe allergic reaction to a previous dose or vaccine components",
                    SideEffects = "Mild side effects include fever, rash, and temporary joint pain",
                    Note = "MMR vaccination is an important part of Egypt's immunization program.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Vaccination
                {
                    Id = 2,
                    Name = "Polio",
                    Type = "Inactivated vaccine (inactivated polio vaccine or IPV)",
                    Route = "Intramuscular injection or oral administration",
                    Reason = "Protection against poliovirus infection",
                    AgeRange = "Multiple doses given during infancy and childhood",
                    VaccinationEffectiveness = "Highly effective in preventing polio",
                    Dosage = "Typically administered as a series of four doses",
                    Contraindication = "Severe allergic reaction to a previous dose",
                    SideEffects = "Mild side effects include pain or swelling at the injection site",
                    Note = "Polio vaccination is crucial for maintaining Egypt's polio-free status.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Vaccination
                {
                    Id = 3,
                    Name = "Hepatitis A",
                    Type = "Inactivated vaccine",
                    Route = "Intramuscular injection",
                    Reason = "Protection against hepatitis A virus infection",
                    AgeRange = "Usually given during childhood or as a catch-up vaccine for older individuals",
                    VaccinationEffectiveness = "Highly effective in preventing hepatitis A",
                    Dosage = "Typically administered as a series of two doses",
                    Contraindication = "Allergy to vaccine components",
                    SideEffects = "Mild side effects include pain at the injection site, headache, and fatigue",
                    Note = "Hepatitis A vaccination is recommended for individuals traveling to areas with a high prevalence of the disease.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Vaccination
                {
                    Id = 4,
                    Name = "Influenza (Flu)",
                    Type = "Inactivated vaccine (influenza vaccine)",
                    Route = "Intramuscular injection or nasal spray",
                    Reason = "Protection against seasonal influenza viruses",
                    AgeRange = "Recommended for individuals six months of age and older",
                    VaccinationEffectiveness = "Varies each year due to different strains, but overall effective in reducing the severity of flu symptoms",
                    Dosage = "Annual vaccination, as the flu strains change every year",
                    Contraindication = "Severe allergic reaction to a previous dose or vaccine components",
                    SideEffects = "Mild side effects include soreness at the injection site, low-grade fever, and muscle aches",
                    Note = "Annual influenza vaccination is recommended, especially for high-risk groups.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Vaccination
                {
                    Id = 5,
                    Name = "Pneumococcal Conjugate Vaccine (PCV13)",
                    Type = "Conjugate vaccine",
                    Route = "Intramuscular injection",
                    Reason = " Protection against infections caused by Streptococcus pneumoniae, including pneumonia, meningitis, and bloodstream infections.",
                    AgeRange = "It is recommended for infants and young children, as well as adults with certain medical conditions or risk factors. The specific age recommendations may vary by country.",
                    VaccinationEffectiveness = "PCV13 has been shown to be highly effective in preventing pneumococcal disease caused by the serotypes included in the vaccine.",
                    Dosage = "The number of doses and schedule can vary depending on the age at initial vaccination and the individual's risk factors.",
                    Contraindication = "Severe allergic reaction (anaphylaxis) to a previous dose of PCV13 or any vaccine component.",
                    SideEffects = "Common side effects include pain, redness, or swelling at the injection site, as well as fever, fussiness, and fatigue.",
                    Note = "PCV13 is often given as a series of doses during infancy and early childhood, followed by a booster dose in some individuals.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
        }
    }
}
