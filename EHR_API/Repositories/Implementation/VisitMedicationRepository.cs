using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class VisitMedicationRepository : RepositoryBase<VisitMedication>, IVisitMedicationRepository
    {
        public VisitMedicationRepository(ApplicationDbContext db) : base(db) { }
    }
}
