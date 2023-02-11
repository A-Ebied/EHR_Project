using EHR_API.Entities;
using EHR_API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EHR_API.Repositories.Implementation
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        internal DbSet<T> _dbSet { get; set; }
        private readonly ApplicationDbContext _db;

        public RepositoryBase(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await SaveAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> exception = null, bool track = true, string includeProperties = null, int pageNumber = 1, int pageSize = 0)
        {
            IQueryable<T> entities = track==true? _dbSet : _dbSet.AsNoTracking();

            entities = exception!=null? entities.Where(exception) : entities;

            if (pageSize > 0)
            {
                entities = entities.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            }

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    entities = entities.Include(item);
                }
            }

           



            return await entities.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> exception, bool track = true, string includeProperties = null)
        {
            IQueryable<T> entity = _dbSet;
            if (!track)
            {
                entity = entity.AsNoTracking();
            }

            if (exception != null)
            {
                entity = entity.Where(exception);
            }

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    entity = entity.Include(item);
                }
            }

            return await entity.SingleOrDefaultAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
