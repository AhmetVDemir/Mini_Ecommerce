
using ECommerceBackend.Domain.Entities.Abstraction;
using System.Linq.Expressions;

namespace ECommerceBackend.Application.Repositories
{
    public interface IReadRepository<T> :IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> expressionMethod);

        Task<T> GetSingleAsyn(Expression<Func<T,bool>> expressionMethod);

        Task<T> GetByIdAsync(string id); 
    }
}
