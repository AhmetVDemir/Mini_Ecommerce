using ECommerceBackend.Application.Repositories.RepoOrder;
using ECommerceBackend.Domain.Entities.Concrete;
using ECommerceBackend.Persistance.Contexxt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistance.Repositories.ConcreteOrder
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceApiDbContext context) : base(context)
        {
        }
    }
}
