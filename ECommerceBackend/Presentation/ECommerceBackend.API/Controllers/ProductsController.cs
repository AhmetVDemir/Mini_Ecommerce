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
            await _productWriteRepository.AddAsync(new() { Name = "Urun1", Price = 1.500F, Stock = 10 });
            await _productWriteRepository.SaveAsync();

           var x = await _productWriteRepository.SaveAsync();
           return Ok("İşlem Tamam");
            
        }
    }
}
