using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class MedicalFacilityTeamRepository : RepositoryBase<MedicalFacilityTeam>, IMedicalFacilityTeamRepository
    {
        public MedicalFacilityTeamRepository(ApplicationDbContext db) : base(db) { }

    }
}
