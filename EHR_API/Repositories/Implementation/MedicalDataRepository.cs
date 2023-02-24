using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class MedicalDataRepository : RepositoryBase<MedicalData>, IMedicalDataRepository
    {
        private ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;

        public MedicalDataRepository(ApplicationDbContext db, IWebHostEnvironment webHost) : base(db)
        {
            _db = db;
            _webHost = webHost;
        }

        public override async Task CreateAsync(MedicalData entity)
        {
            if (entity.DNAImageResult != null)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.DNAImageResult, entity.ImageName, "DNAImageResult");
                entity.DNAImageResultUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<MedicalData> UpdateAsync(MedicalData entity, MedicalData oldEntity = null)
        {
            if (entity.DNAImageResult != null)
            {
                if (oldEntity.DNAImageResultUrl != null)
                {
                    var oldPath = Path.Combine(_webHost.WebRootPath, oldEntity.DNAImageResultUrl.TrimStart('\\'));
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.DNAImageResult, entity.ImageName, "DNAImageResult");
                entity.DNAImageResultUrl = path;
            }
             
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(MedicalData entity)
        {
            if (entity.DNAImageResultUrl != null)
            {
                var oldPath = Path.Combine(_webHost.WebRootPath, entity.DNAImageResultUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }
            }
            
            _dbSet.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
