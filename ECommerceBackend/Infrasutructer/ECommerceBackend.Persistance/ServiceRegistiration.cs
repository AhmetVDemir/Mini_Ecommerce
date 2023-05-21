
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ECommerceBackend.Persistance.Contexxt;

namespace ECommerceBackend.Persistance
{
    public static class ServiceRegistiration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceApiDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
