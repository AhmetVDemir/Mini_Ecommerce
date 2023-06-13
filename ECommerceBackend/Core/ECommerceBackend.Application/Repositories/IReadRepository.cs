
using ECommerceBackend.Domain.Entities.Abstraction;
using System.Linq.Expressions;

namespace ECommerceBackend.Application.Repositories
{
    public interface IReadRepository<T> :IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T,bool>> expressionMethod, bool tracking = true);

        Task<T> GetSingleAsyn(Expression<Func<T,bool>> expressionMethod, bool tracking = true);

        Task<T> GetByIdAsync(string id, bool tracking = true); 
    }
}


#region

/*
  Tracking(izleme mekanizması) ef corun nesneler üzerindeki değişimleri izleyip işlemi anlaması için gerekli olan bir takip yapısıdır. Üzerinde değişiklik olmayan
nesnelerde çalışması işlem maliyeti olacağından. Tracking mekanizmasında delete update gibi operasyonların olmadığı işlemlerde optimizasyon için kaldıracağız. Bunu get operasyonlarınınn içine tracking isminde bir kontrol değişkeni koyarak yapıyoruz (IQueryable.asnotraking());
 
 */

#endregion