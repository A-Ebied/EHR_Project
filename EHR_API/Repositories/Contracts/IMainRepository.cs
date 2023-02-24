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
    }
}
