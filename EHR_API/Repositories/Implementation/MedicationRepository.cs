using EHR_API.Entities;
using EHR_API.Entities.Models;
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
            if (entity.MedicationImage != null && entity.MedicationImage.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.MedicationImage, /*entity.ImageName, */"Medication");
                entity.ImageUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<Medication> UpdateAsync(Medication entity, Medication oldEntity)
        {
            if (entity.MedicationImage != null && entity.MedicationImage.Length > 0)
            {
                if (oldEntity.ImageUrl != null)
                {
                    var oldPath = _webHost.WebRootPath + "\\images" + oldEntity.ImageUrl.Replace("/", "\\");
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.MedicationImage, "Medication");
                entity.ImageUrl = path;
            }

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(Medication entity)
        {
            if (entity.ImageUrl != null)
            {
                var oldPath = _webHost.WebRootPath + "\\images" + entity.ImageUrl.Replace("/", "\\");
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            }

            _dbSet.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}

