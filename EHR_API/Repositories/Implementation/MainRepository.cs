using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;

namespace EHR_API.Repositories.Implementation
{
    public class MainRepository : IMainRepository
    {
        public MainRepository(ApplicationDbContext  db, IMapper mapper, UserManager<RegistrationData> userManager, IConfiguration configuration, IWebHostEnvironment webHost, IEmailSender emailSender)
        {
            _governorate = new GovernorateRepository(db);
            _healthFacility = new HealthFacilityRepository(db);
            _authentication = new AuthenticationRepository(mapper, userManager, configuration, db, emailSender);
            _personal = new PersonalDataRepository(db, webHost);
            _medicalTeam = new MedicalTeamRepository(db);
            _medicalData = new MedicalDataRepository(db, webHost);
            _userInsurance = new UserInsuranceRepository(db);
            _role = new RoleRepository(db);
            _allergy = new AllergyRepository(db);
            _allergyDrug = new AllergyDrugRepository(db);
            _medication = new MedicationRepository(db, webHost);
            _icd = new ICDRepository(db);
            _badHabit = new BadHabitRepository(db);
            _bloodDonation = new BloodDonationRepository(db);
            _visitVital = new VisitVitalSignRepository(db);
            _visitMedication = new VisitMedicationRepository(db);
            _visitRadLabTest = new VisitRadLabTestRepository(db);
            _physicalTherapy = new PhysicalTherapyRepository(db);
            _visit = new VisitRepository(db, webHost);
            _userVaccination = new UserVaccinationRepository(db);
            _vaccination = new VaccinationRepository(db);
            _chronicDisease = new ChronicDiseaseRepository(db);
            _chronicDiseaseDrug = new ChronicDiseaseDrugRepository(db);
            _receiveBloodData = new ReceiveBloodDataRepository(db);
            _receiveBlood = new ReceiveBloodRepository(db);
            _surgery = new SurgeryRepository(db);
            _surgeryProgressNote = new SurgeryProgressNoteRepository(db);
            _admit = new AdmitRepository(db);
            _facilityTeam = new MedicalFacilityTeamRepository(db);
            _contraindication = new ContraindicationRepository(db);
            _radLabResult = new RadLabResultRepository(db);
            _radLabResultImage = new RadLabResultImageRepository(db, webHost);
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
        public IPhysicalTherapyRepository _physicalTherapy { get; private set; }
        public IVisitRepository _visit { get; private set; }
        public IUserVaccinationRepository _userVaccination { get; private set; }
        public IVaccinationRepository _vaccination { get; private set; }
        public IChronicDiseaseRepository _chronicDisease { get; private set; }
        public IChronicDiseaseDrugRepository _chronicDiseaseDrug { get; private set; }
        public IReceiveBloodDataRepository _receiveBloodData { get; private set; }
        public IReceiveBloodRepository _receiveBlood { get; private set; }
        public ISurgeryRepository _surgery { get; private set; }
        public ISurgeryProgressNoteRepository _surgeryProgressNote { get; private set; }
        public IAdmitRepository _admit { get; private set; }
        public IMedicalFacilityTeamRepository _facilityTeam { get; private set; }
        public IContraindicationRepository _contraindication { get; private set; }
        public IRadLabResultRepository _radLabResult { get; private set; }
        public IRadLabResultImageRepository _radLabResultImage { get; private set; }
    }
}
