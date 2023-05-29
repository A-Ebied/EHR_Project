using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class AdmitProgressNoteRepository : RepositoryBase<AdmitProgressNote>, IAdmitProgressNoteRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;
        public AdmitProgressNoteRepository(ApplicationDbContext db, IWebHostEnvironment webHost) : base(db)
        {
            _db = db;
            _webHost = webHost;
        }

        public async Task CreateRangeAsync(List<AdmitProgressNote> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        }

        public override async Task CreateAsync(AdmitProgressNote entity)
        {
            if (entity.File != null && entity.File.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.File, "AdmitProgressNote");
                entity.FileUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<AdmitProgressNote> UpdateAsync(AdmitProgressNote entity, AdmitProgressNote oldEntity)
        {
            if (entity.File != null && entity.File.Length > 0)
            {
                if (oldEntity.FileUrl != null)
                {
                    var oldPath = _webHost.WebRootPath + "\\images" + oldEntity.FileUrl.Replace("/", "\\");
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.File, "AdmitProgressNote");
                entity.FileUrl = path;
            }

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(AdmitProgressNote entity)
        {
            if (entity.FileUrl != null)
            {
                var oldPath = _webHost.WebRootPath + "\\images" + entity.FileUrl.Replace("/", "\\");
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
