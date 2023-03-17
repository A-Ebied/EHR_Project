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
                    Name = "Fexofenadine (الفيكسوفينادين)",
                    Description = "أقراص",
                    Contraindication = "ممنوع على مرضى الكلى والكبد",
                    ImageUrl = "/Medication/fexofenadine.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 2,
                    Name = "Nasonex (نازونكس)",
                    Description = "بخاخ أنف",
                    Contraindication = "لا يستخدم مع مرضى السكري.....الخ",
                    ImageUrl = "/Medication/NASONEX.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 3,
                    Name = "Panadol Advance (بانادول أدفانس)",
                    Description = "أقراص",
                    Contraindication = "لا تستخدم مع أي منتجات أخرى تحتوي على الباراسيتامول. يزيد مرض الكبد الأساسي من خطر تلف الكبد المرتبط بالباراسيتامول. يجب على المرضى الذين تم تشخيص إصابتهم بضعف في الكبد أو الكلى طلب المشورة الطبية قبل تناول هذا الدواء.",
                    ImageUrl = "/Medication/advance.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Medication
                {
                    Id = 4,
                    Name = "Kerovit (كيروفيت)",
                    Description = "أقراص",
                    Contraindication = "فرط الحساسية لأي من المكونات",
                    ImageUrl = "/Medication/Kerovit.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}
