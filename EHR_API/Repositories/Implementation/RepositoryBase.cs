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

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? exception = null, bool track = true)
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

            return await entity.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> exception, bool track = true)
        {
            IQueryable<T> entity = _dbSet;
            if (!track)
            {
                entity = entity.AsNoTracking();
            }

            entity = entity.Where(exception);
            
            return await entity.SingleOrDefaultAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
