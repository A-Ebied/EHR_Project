using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class BloodDonationRepository : RepositoryBase<BloodDonation>, IBloodDonationRepository
    {
        public BloodDonationRepository(ApplicationDbContext db) : base(db) { }
    }
}
