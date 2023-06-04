using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class MedicalTeamConfiguration : IEntityTypeConfiguration<MedicalTeam>
    {
        public void Configure(EntityTypeBuilder<MedicalTeam> builder)
        {
            builder.HasData(
                new MedicalTeam
                {
                    Id = "12345678912342",
                    MedicalSpecialization = "Pulmonologist",
                    Degree = "PhD in pulmonary diseases",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912348",
                    MedicalSpecialization = "Orthopaedic Oncology Surgeon",
                    Degree = "Master of Orthopedic Oncology",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912349",
                    MedicalSpecialization = "Urologic Oncologist",
                    Degree = "PhD in urological oncology",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912350",
                    MedicalSpecialization = "Internal medicine physician",
                    Degree = "PhD in Internal medicine",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912343",
                    MedicalSpecialization = "Otolaryngology",
                    Degree = "Master of Otolaryngology",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912344",
                    MedicalSpecialization = "Pharmacist",
                    Degree = "Bachelor's degree in pharmacy",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912346",
                    MedicalSpecialization = "Radiology technician",
                    Degree = "Institute of Technical healthy",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
