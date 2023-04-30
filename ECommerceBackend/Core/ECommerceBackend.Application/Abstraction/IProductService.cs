using ECommerceBackend.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();


    }
}
