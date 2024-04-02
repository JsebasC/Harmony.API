using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;

namespace msvHarmony.Infrastructure.Ports;

public interface IRepositorySecurity<T> where T : IdentityUser
{
    Task<T> GetOneAsync(Guid id);
    Task<IEnumerable<T>> GetManyAsync(
        Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        string includeStringProperties = "",
        bool isTracking = false);
    Task<T> AddAsync(T entity);
    void UpdateAsync(T entity);
    void DeleteAsync(T entity);

}
