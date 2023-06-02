
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ECommerceBackend.Persistance.Contexxt;
using ECommerceBackend.Application.Repositories.RepoCustomer;
using ECommerceBackend.Persistance.Repositories.ConcreteCustomer;
using ECommerceBackend.Application.Repositories.RepoOrder;
using ECommerceBackend.Persistance.Repositories.ConcreteOrder;
using ECommerceBackend.Application.Repositories.RepoProduct;
using ECommerceBackend.Persistance.Repositories.ConcreteProduct;

namespace ECommerceBackend.Persistance
{
    public static class ServiceRegistiration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceApiDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
            
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddSingleton<IOrderReadRepository,OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository,OrderWriteRepository>();

            services.AddSingleton<IProductReadRepository,ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}
