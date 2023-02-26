using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class PersonalDataRepository : RepositoryBase<PersonalData>, IPersonalDataRepository
    {
        private ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;

        public PersonalDataRepository(ApplicationDbContext db, IWebHostEnvironment webHost) : base(db) 
        { 
            _db= db;
            _webHost = webHost;
        }

        public override async Task CreateAsync(PersonalData entity)
        {
            

            if (entity.UserImage.Length > 0)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.UserImage, entity.ImageName, "UserImage");
                entity.UserImageUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<PersonalData> UpdateAsync(PersonalData entity, PersonalData oldEntity)
        {
            if (entity.UserImage != null && entity.UserImage.Length > 0)
            {
                if (oldEntity.UserImageUrl != null)
                {
                    var oldPath = Path.Combine(_webHost.WebRootPath, oldEntity.UserImageUrl.TrimStart('\\'));
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.UserImage, entity.ImageName, "UserImage");
                entity.UserImageUrl = path;
            }

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(PersonalData entity)
        {
            if (entity.UserImage != null && entity.UserImageUrl.Length > 0)
            {
                var oldPath = Path.Combine(_webHost.WebRootPath, entity.UserImageUrl.TrimStart('\\'));
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
