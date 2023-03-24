using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class MedicationRepository : RepositoryBase<Medication>, IMedicationRepository
    {
        private ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;

        public MedicationRepository(ApplicationDbContext db, IWebHostEnvironment webHost) : base(db)
        {
            _db = db;
            _webHost = webHost;
        }

        public override async Task CreateAsync(Medication entity)
        {
            if (entity.MedicationImage.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.MedicationImage, entity.ImageName, "Medication");
                entity.ImageUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }
    }
}
