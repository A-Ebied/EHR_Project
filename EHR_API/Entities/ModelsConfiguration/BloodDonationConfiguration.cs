//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using EHR_API.Entities.Models;

//namespace EHR_API.Entities.ModelsConfiguration
//{
//    public class BloodDonationConfiguration : IEntityTypeConfiguration<BloodDonation>
//    {
//        public void Configure(EntityTypeBuilder<BloodDonation> builder)
//        {
//            builder.HasData(
//                new BloodDonation
//                {
//                    Id = 1,
//                    DonationDateTime = DateTime.Now,
//                    RegistrationDataId = "12345678912351",
//                    MedicalTeamId = "12345678912351",
//                    CreatedAt = DateTime.Now,
//                    UpdatedAt = DateTime.Now,
//                },
//                new BloodDonation
//                {
//                    Id = 2,
//                    Type = "حساسية الطعام",
//                    Allergen = "الفول السوداني والحليب والبيض",
//                    Reaction = "طفح جلدي",
//                    Instruction = "",
//                    IsChronic = true,
//                    RegistrationDataId = "12345678912352",
//                    CreatedAt = DateTime.Now,
//                    UpdatedAt = DateTime.Now,
//                },
//                new BloodDonation
//                {
//                    Id = 3,
//                    Type = "حساسية الحيوانات الأليفة",
//                    Allergen = "فراء الحيوانات ، وخاصة من الحيوانات الأليفة مثل القطط والكلاب",
//                    Reaction = "ضيق في الصدر وفقدان أنفاسك",
//                    Instruction = "الابتعاد عن الحيوانات الأليفة",
//                    IsChronic = true,
//                    RegistrationDataId = "12345678912353",
//                    CreatedAt = DateTime.Now,
//                    UpdatedAt = DateTime.Now,
//                });
//        }
//    }
//}
