using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class RadLabResultRepository : RepositoryBase<RadLabResult>, IRadLabResultRepository
    {
        private ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;
        public RadLabResultRepository(ApplicationDbContext db, IWebHostEnvironment webHost) : base(db)
        {
            _db = db;
            _webHost = webHost;
        }

        public override async Task CreateAsync(RadLabResult entity)
        {
            if (entity.Image != null && entity.Image.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.Image, "RadLabResultImage");
                entity.ImageUrl = path;
            }

            if (entity.File != null && entity.File.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.File, "RadLabResultFile");
                entity.FileUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<RadLabResult> UpdateAsync(RadLabResult entity, RadLabResult oldEntity)
        {
            if (entity.Image != null && entity.Image.Length > 0)
            {
                if (oldEntity.ImageUrl != null)
                {
                    var oldPath = _webHost.WebRootPath + "\\files" + oldEntity.ImageUrl.Replace("/", "\\");
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.Image, "RadLabResultImage");
                entity.ImageUrl = path;
            }
            
            if (entity.File != null && entity.File.Length > 0)
            {
                if (oldEntity.FileUrl != null)
                {
                    var oldPath = _webHost.WebRootPath + "\\files" + oldEntity.FileUrl.Replace("/", "\\");
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.File, "RadLabResultFile");
                entity.FileUrl = path;
            }

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(RadLabResult entity)
        {
            if (entity.ImageUrl != null)
            {
                var oldPath = _webHost.WebRootPath + "\\files" + entity.ImageUrl.Replace("/", "\\");
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            } 
            
            if (entity.FileUrl != null)
            {
                var oldPath = _webHost.WebRootPath + "\\files" + entity.FileUrl.Replace("/", "\\");
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
