using ECommerceBackend.Application.Repositories.RepoCustomer;
using ECommerceBackend.Domain.Entities.Concrete;
using ECommerceBackend.Persistance.Contexxt;


namespace ECommerceBackend.Persistance.Repositories.ConcreteCustomer
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceApiDbContext context) : base(context)
        {
        }
    }
}
