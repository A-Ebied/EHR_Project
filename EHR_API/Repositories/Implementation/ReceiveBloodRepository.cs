using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class ReceiveBloodRepository : RepositoryBase<ReceiveBlood>, IReceiveBloodRepository
    {
        public ReceiveBloodRepository(ApplicationDbContext db) : base(db) { }
    }
}
