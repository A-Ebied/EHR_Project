using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using static System.Net.Mime.MediaTypeNames;

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
            if (entity.UserImage != null)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.UserImage, "UserImage");
                entity.UserImageUrl = path;
            }
            if (entity.IdImage != null)
            {
                var path = CreateImage.CreateFiles(_webHost, entity.UserImage, "IdImage");
                entity.IdImageUrl = path;
            }

            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public override async Task<PersonalData> UpdateAsync(PersonalData entity, PersonalData oldEntity)
        {
            if (entity.UserImage != null)
            {
                if (oldEntity.UserImageUrl != null)
                {
                    var oldPath = Path.Combine(_webHost.WebRootPath, oldEntity.UserImageUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.UserImage, "UserImage");
                entity.UserImageUrl = path;
            }
            if (entity.IdImage != null)
            {
                if (oldEntity.IdImageUrl != null)
                {
                    var oldPath = Path.Combine(_webHost.WebRootPath, oldEntity.IdImageUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

                var path = CreateImage.CreateFiles(_webHost, entity.IdImage, "IdImage");
                entity.IdImageUrl = path;
            }

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(PersonalData entity)
        {
            if (entity.UserImageUrl != null)
            {
                var oldPath = Path.Combine(_webHost.WebRootPath, entity.UserImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }
            }
            if (entity.IdImageUrl != null)
            {
                var oldPath = Path.Combine(_webHost.WebRootPath, entity.IdImageUrl.TrimStart('\\'));
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
