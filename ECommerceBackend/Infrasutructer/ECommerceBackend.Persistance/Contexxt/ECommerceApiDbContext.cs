using ECommerceBackend.Domain.Entities.Abstraction;
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

        //   eklemek için ef nin savechanges fonksiyonunu manipüle ediyoruz. (ortak dataları (time gibi) otomatik doldurmak için sürece entegre ediyoruz)
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //yapılan değişiklikleri ve yeni entitileri yakalamak için,  Track edilen verileri yakalamamızı sağlar.
            var data = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in data)
            {
                DateTime dateTime = entry.State switch
                {
                    EntityState.Added => entry.Entity.CreatedAt = DateTime.UtcNow,
                    EntityState.Modified => entry.Entity.UpdatedAt = DateTime.UtcNow,
                };
                _ = dateTime;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }


    }
}
