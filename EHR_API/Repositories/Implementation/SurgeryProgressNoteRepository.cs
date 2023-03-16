using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class SurgeryProgressNoteRepository : RepositoryBase<SurgeryProgressNote>, ISurgeryProgressNoteRepository
    {
       // public SurgeryProgressNoteRepository(ApplicationDbContext db) : base(db) { }
        private readonly ApplicationDbContext _db;
        public SurgeryProgressNoteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task CreateRangeAsync(List<SurgeryProgressNote> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        }


    }
}
