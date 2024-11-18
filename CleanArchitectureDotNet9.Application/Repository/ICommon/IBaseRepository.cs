using CleanArchitectureDotNet9.Domain.Common;

namespace CleanArchitectureDotNet9.Application.Repository.ICommon
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
