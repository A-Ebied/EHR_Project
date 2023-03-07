using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;

namespace EHR_API.Repositories.Implementation
{
    public class MainRepository : IMainRepository
    {
        public MainRepository(ApplicationDbContext  db, IMapper mapper, UserManager<RegistrationData> userManager, IConfiguration configuration, IWebHostEnvironment webHost)
        {
            _governorate = new GovernorateRepository(db);
            _healthFacility = new HealthFacilityRepository(db);
            _authentication = new AuthenticationRepository(mapper, userManager, configuration, db);
            _personal = new PersonalDataRepository(db, webHost);
            _medicalTeam = new MedicalTeamRepository(db);
            _medicalData = new MedicalDataRepository(db, webHost);
             _userInsurance = new UserInsuranceRepository(db);
            _role = new RoleRepository(db);
            _allergy = new AllergyRepository(db);
            _allergyDrug = new AllergyDrugRepository(db);
            _medication = new MedicationRepository(db);
            _icd = new ICDRepository(db);
            _badHabit = new BadHabitRepository(db);
            _bloodDonation = new BloodDonationRepository(db);
            _visitVital = new VisitVitalSignRepository(db);
            _visitMedication = new VisitMedicationRepository(db);
            _visitRadLabTest = new VisitRadLabTestRepository(db);
        }

        public IGovernorateRepository _governorate { get; private set; }
        public IHealthFacilityRepository _healthFacility { get; private set; }
        public IAuthenticationRepository _authentication { get; private set; }
        public IPersonalDataRepository _personal { get; private set; }
        public IMedicalTeamRepository _medicalTeam { get; private set; }
        public IMedicalDataRepository _medicalData { get; private set; }
         public IUserInsuranceRepository _userInsurance { get; private set; }
        public IRoleRepository _role { get; private set; }
        public IAllergyRepository _allergy { get; private set; }
        public IAllergyDrugRepository _allergyDrug { get; private set; }
        public IMedicationRepository _medication { get; private set; }
        public IICDRepository _icd { get; private set; }
        public IBadHabitRepository _badHabit { get; private set; }
        public IBloodDonationRepository _bloodDonation { get; private set; }
        public IVisitVitalSignRepository _visitVital { get; private set; }
        public IVisitMedicationRepository _visitMedication { get; private set; }
        public IVisitRadLabTestRepository _visitRadLabTest { get; private set; }
    }
}
