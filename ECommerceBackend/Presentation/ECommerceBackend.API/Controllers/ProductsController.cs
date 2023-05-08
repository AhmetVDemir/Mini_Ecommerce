using Microsoft.AspNetCore.Mvc;

namespace ECommerceBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

     

        [HttpGet]
        public IActionResult GetProducts()
        {
            
            return Ok("Okey");
        }
    }
}
