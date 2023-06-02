using ECommerceBackend.Application.Repositories.RepoProduct;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Threading.Tasks.Dataflow;

namespace ECommerceBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            await _productWriteRepository.AddRangeAsync(new() {
                new() {Id = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, Name = "Urun1", Price = 100, Stock = 10},
                new() {Id = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, Name = "Urun2", Price = 150, Stock = 15},
                new() {Id = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, Name = "Urun3", Price = 200, Stock = 20},
            });

           var x = await _productWriteRepository.SaveAsync();
           return Ok("İşlem Tamam");
            
        }
    }
}
