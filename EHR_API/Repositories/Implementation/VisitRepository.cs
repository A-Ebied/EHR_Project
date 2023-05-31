using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class VisitRepository : RepositoryBase<Visit>, IVisitRepository
    {
        private ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;

        public VisitRepository(ApplicationDbContext db, IWebHostEnvironment webHost) : base(db)
        {
            _db = db;
            _webHost = webHost;
        }

        public override async Task CreateAsync(Visit entity)
        {
            if (entity.ReportImage != null && entity.ReportImage.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.ReportImage, "ReportImage");
                entity.ReportImageUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<Visit> UpdateAsync(Visit entity, Visit oldEntity)
        {
            if (entity.ReportImage != null && entity.ReportImage.Length > 0)
            {
                if (oldEntity.ReportImageUrl != null)
                {
                    var oldPath = _webHost.WebRootPath + "\\files" + oldEntity.ReportImageUrl.Replace("/", "\\");
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.ReportImage, "ReportImage");
                entity.ReportImageUrl = path;
            }

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(Visit entity)
        {
            if (entity.ReportImageUrl != null)
            {
                var oldPath = _webHost.WebRootPath + "\\files" + entity.ReportImageUrl.Replace("/", "\\");
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
