using ECommerceBackend.Persistance.Contexxt;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerceBackend.Persistance
{
    //For cli migration
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceApiDbContext>
    {
        public ECommerceApiDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<ECommerceApiDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new ECommerceApiDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
