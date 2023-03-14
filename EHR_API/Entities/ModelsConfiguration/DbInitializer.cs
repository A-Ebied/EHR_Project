using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _db;
        public DbInitializer(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception) { throw; }

             

            //            //var badHbits = new BadHabit[]
            //            //{
            //            //    new BadHabit
            //            //    {
            //            //        Habit = "التدخين",
            //            //    },
            //            //    new BadHabit
            //            //    {
            //            //        Habit = "شرب الخمور",
            //            //    },
            //            //};
            //            //foreach (var i in badHbits)
            //            //{
            //            //    _context.BadHabits.Add(i);
            //            //}
            //            //_db.SaveChanges();

            //            // var vaccinations = new Vaccination[]
            //            //{
            //            //     new Vaccination
            //            //     {
            //            //        Code="1",
            //            //        Name="Influvac tetra",
            //            //        Type="موسمي",
            //            //        Reason="للعلاج من البرد",
            //            //        Route="حقن",
            //            //        AgeRange="من 15 ل 60",
            //            //        Duration="-",
            //            //        NumberOfTimes="غير محدد",
            //            //        Dosage="-",
            //            //        DosageNote="-",
            //            //        Quantity="-",
            //            //        Contraindication="-",
            //            //        SideEffects="ارتفاع درجة الحرارة",
            //            //        IsMandatory=false,
            //            //        Note="-",
            //            //        CreatedAt=DateTime.Now,
            //            //     },
            //            //};
            //            // foreach (var i in vaccinations)
            //            // {
            //            //     _context.Vaccinations.Add(i);
            //            // }
            //            // _db.SaveChanges();

            //            // var vitalSigns = new VitalSign[]
            //            //{
            //            //     new VitalSign
            //            //     {
            //            //        Title="ضغط الدم",
            //            //     },
            //            //    new VitalSign
            //            //     {
            //            //        Title="درجة الحرارة",
            //            //     },
            //            //    new VitalSign
            //            //     {
            //            //        Title="النبض",
            //            //     },
            //            //};
            //            // foreach (var i in vitalSigns)
            //            // {
            //            //     _context.VitalSigns.Add(i);
            //            // }
            //            // _db.SaveChanges();

            //            //var radLabTests = new RadLabTest[]
            //            //{
            //            //     new RadLabTest
            //            //     {
            //            //        Type="تحاليل",
            //            //        TestType="دم"
            //            //     },
            //            //    new RadLabTest
            //            //     {
            //            //        Type="أشعة",
            //            //        TestType="عظام"
            //            //     },
            //            //};
            //            //foreach (var i in radLabTests)
            //            //{
            //            //    _context.RadLabTests.Add(i);
            //            //}
            //            //_db.SaveChanges();

            //            //var medicalSpecializations = new MedicalSpecialization[]
            //            //{
            //            //    new MedicalSpecialization
            //            //    {
            //            //        Title="جراحة المسالك البولية النسائية",
            //            //        MedicalDepartmentId = 2
            //            //    },
            //            //   new MedicalSpecialization
            //            //    {
            //            //        Title="طب الذكورة",
            //            //        MedicalDepartmentId = 2
            //            //    },
            //            //   new MedicalSpecialization
            //            //   {
            //            //       Title="أورام المسالك البولية",
            //            //       MedicalDepartmentId = 2
            //            //   },
            //            //   new MedicalSpecialization
            //            //   {
            //            //       Title="جراحة عظام الأطفال",
            //            //       MedicalDepartmentId = 3
            //            //   },
            //            //   new MedicalSpecialization
            //            //   {
            //            //       Title="جراحة العمود الفقري",
            //            //       MedicalDepartmentId = 3
            //            //   },
            //            //   new MedicalSpecialization
            //            //   {
            //            //       Title="أورام العظام",
            //            //       MedicalDepartmentId = 3
            //            //   },
            //            //};
            //            //foreach (var i in medicalSpecializations)
            //            //{
            //            //    _context.MedicalSpecializations.Add(i);
            //            //}
            //            //_db.SaveChanges();
        }
    }
}

