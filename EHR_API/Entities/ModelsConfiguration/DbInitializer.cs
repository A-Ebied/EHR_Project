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
        private UserManager<RegistrationData> _dbUsers;
        public DbInitializer(ApplicationDbContext db, UserManager<RegistrationData> dbUsers)
        {
            _db = db;
            _dbUsers= dbUsers;
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

            // Look for any Users.
            if (_db.Governorates.Any())
            {
                return;   // DB has been seeded
            }
             
            //var icds = new ICD[]
            //{
            //    new ICD
            //    {
            //        Code = "A00.0",
            //        DiagnosisName = "Cholera due to Vibrio cholerae 01, biovar cholerae",
            //    },

            //    new ICD
            //    {
            //        Code = "A00.1",
            //        DiagnosisName = "Cholera due to Vibrio cholerae 01, biovar eltor",
            //    },

            //    new ICD
            //    {
            //        Code = "A00.9",
            //        DiagnosisName = "Cholera, unspecified",
            //    },

            //    new ICD
            //    {
            //        Code = "A01.00",
            //        DiagnosisName = "Typhoid fever, unspecified",
            //    },
            //};
            //foreach (ICD i in icds)
            //{
            //    _context.ICDs.Add(i);
            //}
            //_context.SaveChanges();

            var govers = new Governorate[]
            {
                new Governorate
                {
                    Title = "القاهرة",
                },
                new Governorate
                {
                    Title = "الجيزة",
                },
                 new Governorate
                {
                    Title = "مطروح",
                },
                new Governorate
                {
                    Title = "شمال سيناء",
                },
                 new Governorate
                {
                    Title = "الشرقية",
                },
                new Governorate
                {
                    Title = "الدقهلية",
                },
            };
            foreach (var i in govers)
            {
                _db.Governorates.Add(i);
            }
            _db.SaveChanges();

            var user = (_dbUsers.GetUsersInRoleAsync(SD.HealthFacilityManager) as IEnumerable<RegistrationData>).ToList();
            var healthFacilities = new HealthFacility[]
            {
                new HealthFacility
                {
                     Id = user[0].Id,
                    Title = "المستشفى العسكري بالشرقية",
                    Type = "مستشفى عسكري",
                    SubordinateTo = "المؤسسة العسكرية",
                    Phone1 = "01123456878",
                    Phone2 = "",
                    Phone3 = "",
                    Email = "m@gmail.com",
                    Address = "Address1",
                    Description = "Description1",
                },
                 new HealthFacility
                 {
                     Id = user[1].Id,
                     Title = "المستشفى العام بالعريش",
                     Type = "مستشفى عام",
                     SubordinateTo = "وزارة الصحة",
                     Phone1 = "01122456878",
                     Phone2 = "",
                     Phone3 = "",
                     Email = "a@gmail.com",
                     Address = "Address2",
                     Description = "Description2",
                 },
                  new HealthFacility
                  {
                      Id = user[3].Id,
                      Title = "مستشفى الجامعة بالزقازيق",
                      Type = "مستشفى جامعي",
                      SubordinateTo = "مستشفيات الجامعة",
                      Phone1 = "01123416878",
                      Phone2 = "",
                      Phone3 = "",
                      Email = "j@gmail.com",
                      Address = "Address3",
                      Description = "Description3",
                  }
            };
            foreach (var i in healthFacilities)
            {
                _db.HealthFacilities.Add(i);
            }
            _db.SaveChanges();

            //var badHbits = new BadHabit[]
            //{
            //    new BadHabit
            //    {
            //        Habit = "التدخين",
            //    },
            //    new BadHabit
            //    {
            //        Habit = "شرب الخمور",
            //    },
            //};
            //foreach (var i in badHbits)
            //{
            //    _context.BadHabits.Add(i);
            //}
            //_db.SaveChanges();

            // var vaccinations = new Vaccination[]
            //{
            //     new Vaccination
            //     {
            //        Code="1",
            //        Name="Influvac tetra",
            //        Type="موسمي",
            //        Reason="للعلاج من البرد",
            //        Route="حقن",
            //        AgeRange="من 15 ل 60",
            //        Duration="-",
            //        NumberOfTimes="غير محدد",
            //        Dosage="-",
            //        DosageNote="-",
            //        Quantity="-",
            //        Contraindication="-",
            //        SideEffects="ارتفاع درجة الحرارة",
            //        IsMandatory=false,
            //        Note="-",
            //        CreatedAt=DateTime.Now,
            //     },
            //};
            // foreach (var i in vaccinations)
            // {
            //     _context.Vaccinations.Add(i);
            // }
            // _db.SaveChanges();

            // var vitalSigns = new VitalSign[]
            //{
            //     new VitalSign
            //     {
            //        Title="ضغط الدم",
            //     },
            //    new VitalSign
            //     {
            //        Title="درجة الحرارة",
            //     },
            //    new VitalSign
            //     {
            //        Title="النبض",
            //     },
            //};
            // foreach (var i in vitalSigns)
            // {
            //     _context.VitalSigns.Add(i);
            // }
            // _db.SaveChanges();

            //var radLabTests = new RadLabTest[]
            //{
            //     new RadLabTest
            //     {
            //        Type="تحاليل",
            //        TestType="دم"
            //     },
            //    new RadLabTest
            //     {
            //        Type="أشعة",
            //        TestType="عظام"
            //     },
            //};
            //foreach (var i in radLabTests)
            //{
            //    _context.RadLabTests.Add(i);
            //}
            //_db.SaveChanges();

            //var medicalSpecializations = new MedicalSpecialization[]
            //{
            //    new MedicalSpecialization
            //    {
            //        Title="جراحة المسالك البولية النسائية",
            //        MedicalDepartmentId = 2
            //    },
            //   new MedicalSpecialization
            //    {
            //        Title="طب الذكورة",
            //        MedicalDepartmentId = 2
            //    },
            //   new MedicalSpecialization
            //   {
            //       Title="أورام المسالك البولية",
            //       MedicalDepartmentId = 2
            //   },
            //   new MedicalSpecialization
            //   {
            //       Title="جراحة عظام الأطفال",
            //       MedicalDepartmentId = 3
            //   },
            //   new MedicalSpecialization
            //   {
            //       Title="جراحة العمود الفقري",
            //       MedicalDepartmentId = 3
            //   },
            //   new MedicalSpecialization
            //   {
            //       Title="أورام العظام",
            //       MedicalDepartmentId = 3
            //   },
            //};
            //foreach (var i in medicalSpecializations)
            //{
            //    _context.MedicalSpecializations.Add(i);
            //}
            //_db.SaveChanges();
        }
    }
}

