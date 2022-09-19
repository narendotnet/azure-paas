using BigPurpleBankWebApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BigPurpleBankWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductService _service;
        public ProductController(IProductService service)
        {
            this._service = service;
        }

        [EnableCors("test")]
        [HttpGet("[action]")]
        public IActionResult GetProducts()
        {
            var products = _service.GetProducts();
            return Ok(products);
        }
    }
}