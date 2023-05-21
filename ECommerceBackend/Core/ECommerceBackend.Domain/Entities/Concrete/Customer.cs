using ECommerceBackend.Domain.Entities.Abstraction;

namespace ECommerceBackend.Domain.Entities.Concrete
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
