using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class SurgeryRepository : RepositoryBase<Surgery>, ISurgeryRepository
    {
        public SurgeryRepository(ApplicationDbContext db) : base(db) { }  

    }
}
