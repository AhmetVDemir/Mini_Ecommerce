using ECommerceBackend.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistance.Contexxt
{
    public class ECommerceApiDbContext : DbContext
    {
        public ECommerceApiDbContext(DbContextOptions options) :base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }


    }
}
