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

        public virtual async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, string includeProperties = null)
        {
            IQueryable<T> entities = expression != null ? _dbSet.Where(expression) : _dbSet;

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    entities = entities.Include(item);
                }
            }

            return await entities.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, string includeProperties = null)
        {
            IQueryable<T> entity = expression != null ? _dbSet.Where(expression) : _dbSet;

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    entity = entity.Include(item);
                }
            }

            return await entity.SingleOrDefaultAsync();
        }

        public virtual async Task<T> UpdateAsync(T entity, T oldEntity = null)
        {
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
