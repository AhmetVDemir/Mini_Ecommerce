using ECommerceBackend.Domain.Entities.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Application.Repositories
{
    //Base entity zaten bir class, class kısıtında getbyid gibi fonksiyonlarda id gibi field ları görmek için generic kısıta bunu verdik
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
