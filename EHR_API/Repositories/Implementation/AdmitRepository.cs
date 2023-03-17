using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class AdmitRepository : RepositoryBase<Admit>, IAdmitRepository
    {
        public AdmitRepository(ApplicationDbContext db) : base(db) { }

    }
}
