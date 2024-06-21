using Microsoft.AspNetCore.Mvc;
using RTX.Data.Interfaces;
using RTX.Models;

namespace RTX.Controllers.ProductController;

public class ProductController : Controller
{
    private IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        List<Product>? products = _productRepository.GetProducts();
        return View(products);
    }

    public IActionResult CreateProduct()
    {
        return View();
    }

    public IActionResult FilterProducts(string filterTerm)
    {
        if (filterTerm == null) return RedirectToAction("Index");
        List<Product> products = _productRepository.FilterProductsByNameAndDescription(filterTerm);
        return View(products);
    }

    public IActionResult DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        Product? product = _productRepository.GetProductById(id);
        if (product != null)
        {
            var json = Json(new
            {
                id = product.Id,
                name = product.Name,
                description = product.Description,
                price = product.Price,
                photo = product.Photo
            });
            return Ok(json);
        }
        return NotFound(); 
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_productRepository.GetProducts());
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            _productRepository.CreateProduct(product);
            return RedirectToAction("Index");
        }
        return View(product);
    }
}
