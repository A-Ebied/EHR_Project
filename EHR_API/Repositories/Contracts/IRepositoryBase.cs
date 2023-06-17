using System.Linq.Expressions;

namespace EHR_API.Repositories.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, string includeProperties = null);
        Task<T> GetAsync(Expression<Func<T, bool>> expression, string includeProperties = null);
        Task CreateAsync(T entity);
        Task<T> UpdateAsync(T entity, T oldEntity = null);
        Task DeleteAsync(T entity);
    }
}
