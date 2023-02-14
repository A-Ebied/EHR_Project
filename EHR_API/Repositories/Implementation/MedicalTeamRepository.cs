using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class MedicalTeamRepository : RepositoryBase<MedicalTeam>, IMedicalTeamRepository
    {
        public MedicalTeamRepository(ApplicationDbContext db) : base(db) { }
    }
}
