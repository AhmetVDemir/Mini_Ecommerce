using ECommerceBackend.Application.Repositories.RepoProduct;
using ECommerceBackend.Domain.Entities.Concrete;
using ECommerceBackend.Persistance.Contexxt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistance.Repositories.ConcreteProduct
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceApiDbContext context) : base(context)
        {
        }
    }
}
