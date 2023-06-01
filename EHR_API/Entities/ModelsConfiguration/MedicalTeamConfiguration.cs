using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;
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
                    MedicalSpecialization = "جراحة العمود الفقري",
                    Degree = "ماجستير جراحة العمود الفقري",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912348",
                    MedicalSpecialization = "أورام العظام",
                    Degree = "ماجستير أورام العظام",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912349",
                    MedicalSpecialization = "أورام المسالك البولية",
                    Degree = "دكتوراة أورام المسالك البولية",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912350",
                    MedicalSpecialization = "جراحة القلب",
                    Degree = "دكتوراة جراحة القلب",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912343",
                    MedicalSpecialization = "أنف وأذن وحنجرة",
                    Degree = "ماجستير أنف وأذن وحنجرة",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912344",
                    MedicalSpecialization = "طب الصيدلة",
                    Degree = "بكالوريوس الصيدلة",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new MedicalTeam
                {
                    Id = "12345678912346",
                    MedicalSpecialization = "فني أشعة",
                    Degree = "معهد فني صحي",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
