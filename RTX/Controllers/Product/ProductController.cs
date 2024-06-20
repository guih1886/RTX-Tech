using Microsoft.AspNetCore.Mvc;
using RTX.Data.Interfaces;
using RTX.Models;

namespace RTX.Controllers.Product;

[ApiController]
[Route("Products")]
public class ProductController : ControllerBase
{
    private IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_productRepository.GetProducts());
    }

    [HttpGet("{id}")]
    public IActionResult GetProductDetails(int id)
    {
        Models.Product? produto = _productRepository.GetProductById(id);
        if (produto != null)
        {
            return Ok(produto);
        }
        return NotFound("Produto não encontrado.");
    }
}
