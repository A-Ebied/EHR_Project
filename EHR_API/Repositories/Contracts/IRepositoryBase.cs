using System.Linq.Expressions;

namespace EHR_API.Repositories.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? exception = null, bool track = true);
        Task<T> GetAsync(Expression<Func<T, bool>> exception, bool track = true);
        Task CreateAsync(T entity);
        //Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task SaveAsync();
    }
}
