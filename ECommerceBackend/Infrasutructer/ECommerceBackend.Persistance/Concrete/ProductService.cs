using ECommerceBackend.Application.Abstraction;
using ECommerceBackend.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistance.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new() { 
            new() {Id = Guid.NewGuid(), Name =  "Urun 1", Price=100,Stock=5,CreatedDate = DateTime.Now},
            new() {Id = Guid.NewGuid(), Name =  "Urun 2", Price=140,Stock=50,CreatedDate = DateTime.Now},
            new() {Id = Guid.NewGuid(), Name =  "Urun 3", Price=150,Stock=1,CreatedDate = DateTime.Now},
            new() {Id = Guid.NewGuid(), Name =  "Urun 4", Price=160,Stock=10,CreatedDate = DateTime.Now},
            new() {Id = Guid.NewGuid(), Name =  "Urun 5", Price=1070,Stock=140,CreatedDate = DateTime.Now},
            new() {Id = Guid.NewGuid(), Name =  "Urun 6", Price=102,Stock=120,CreatedDate = DateTime.Now},
        };
    }
}
