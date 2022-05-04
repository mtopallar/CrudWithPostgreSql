using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        { 
            return Ok(_productService.GetById(id));
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return Ok(product);
        }
        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return Ok(product);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            _productService.Delete(product);
            return Ok("Silindi");
        }
    }
}
