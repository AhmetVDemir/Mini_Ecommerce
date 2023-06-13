
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
            
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();

            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}
