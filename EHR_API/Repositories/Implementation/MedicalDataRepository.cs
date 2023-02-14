using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class MedicalDataRepository : RepositoryBase<MedicalData>, IMedicalDataRepository
    {
        public MedicalDataRepository(ApplicationDbContext db) : base(db) { }
    }
}
