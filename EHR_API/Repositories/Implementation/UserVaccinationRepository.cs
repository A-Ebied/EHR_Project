using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class UserVaccinationRepository : RepositoryBase<UserVaccination>, IUserVaccinationRepository
    {
        public UserVaccinationRepository(ApplicationDbContext db) : base(db) { }
    }
}
