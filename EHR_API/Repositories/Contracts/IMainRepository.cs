namespace EHR_API.Repositories.Contracts
{
    public interface IMainRepository
    {
        IGovernorateRepository _governorate { get; }
        IHealthFacilityRepository _healthFacility { get; }
        IAuthenticationRepository _authentication { get; }
        IPersonalDataRepository _personal { get; }
        IMedicalTeamRepository _medicalTeam { get; }
        IMedicalDataRepository _medicalData { get; }
        IUserInsuranceRepository _userInsurance { get; }
        IRoleRepository _role { get; }
        IAllergyRepository _allergy { get; }
        IAllergyDrugRepository _allergyDrug { get; }
        IMedicationRepository _medication { get; }
        IICDRepository _icd { get; }
        IBadHabitRepository _badHabit { get; }
        IBloodDonationRepository _bloodDonation { get; }
        IVisitVitalSignRepository _visitVital { get; }
        IVisitMedicationRepository _visitMedication { get; }
        IPhysicalTherapyRepository _physicalTherapy { get; }
        IVisitRepository _visit { get; }
        IUserVaccinationRepository _userVaccination { get; }
        IVisitRadLabTestRepository _visitRadLabTest { get; }
        IVaccinationRepository _vaccination { get; }
        IChronicDiseaseRepository _chronicDisease { get; }
        IChronicDiseaseDrugRepository _chronicDiseaseDrug { get; }
        IReceiveBloodRepository _receiveBlood { get; }
        IReceiveBloodDataRepository _receiveBloodData { get; }
        ISurgeryRepository _surgery { get; }
        ISurgeryProgressNoteRepository _surgeryProgressNote { get; }
        IAdmitRepository _admit { get; }
        IMedicalFacilityTeamRepository _facilityTeam { get; }
        IContraindicationRepository _contraindication { get; }
        IRadLabResultRepository _radLabResult { get; }
        IRadLabResultImageRepository _radLabResultImage { get; }
    }
}
