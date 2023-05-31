using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class RadLabResultImageRepository : RepositoryBase<RadLabResultImage>, IRadLabResultImageRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;
        public RadLabResultImageRepository(ApplicationDbContext db, IWebHostEnvironment webHost) : base(db)
        {
            _db = db;
            _webHost = webHost;
        }

        public async Task CreateRangeAsync(List<IFormFile> entities, int id)
        {
            List<RadLabResultImage> newEntities = new();
            RadLabResultImage temp;
            foreach (var entity in entities)
            {
                if (entity != null && entity.Length > 0)
                {
                    temp = new();
                    temp.RadLabResultId = id;
                    temp.ResultImageUrl = CreateImage.CreateFiles(_webHost, entity, "RadLabResultImage");
                    temp.CreatedAt = DateTime.Now;
                    temp.UpdatedAt = DateTime.Now;

                    newEntities.Add(temp);
                }
            }

            await _dbSet.AddRangeAsync(newEntities);
            await _db.SaveChangesAsync();
        }

        public override async Task CreateAsync(RadLabResultImage entity)
        {
            if (entity.Image != null && entity.Image.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.Image, "RadLabResultImage");
                entity.ResultImageUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<RadLabResultImage> UpdateAsync(RadLabResultImage entity, RadLabResultImage oldEntity)
        {
            if (entity.Image != null && entity.Image.Length > 0)
            {
                if (oldEntity.Image != null)
                {
                    var oldPath = Path.Combine(_webHost.WebRootPath, oldEntity.ResultImageUrl.TrimStart('\\'));
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.Image, "RadLabResultImage");
                entity.ResultImageUrl = path;
            }

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(RadLabResultImage entity)
        {
            if (entity.Image != null && entity.Image.Length > 0)
            {
                var oldPath = Path.Combine(_webHost.WebRootPath, entity.ResultImageUrl.TrimStart('\\'));
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
