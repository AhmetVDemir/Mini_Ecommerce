using ECommerceBackend.Domain.Entities.Abstraction;

namespace ECommerceBackend.Domain.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }

        public long Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
