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
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceApiDbContext context) : base(context)
        {
        }
    }
}
