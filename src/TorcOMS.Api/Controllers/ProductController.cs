using Microsoft.AspNetCore.Mvc;
using TorcOMS.Domain.Models;
using TorcOMS.Application.Interfaces;

namespace TorcOMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(_productService.GetProducts());
        }

    }
}
