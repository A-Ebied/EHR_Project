using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class PersonalDataRepository : RepositoryBase<PersonalData>, IPersonalDataRepository
    {
        public PersonalDataRepository(ApplicationDbContext db) : base(db) { }
    }
}
