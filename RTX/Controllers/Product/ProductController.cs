﻿using Microsoft.AspNetCore.Mvc;
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
        List<Product>? produtos = _productRepository.GetProducts();
        return View(produtos);
    }

    public IActionResult CreateProduct()
    {
        return View();
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

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        _productRepository.CreateProduct(product);
        return RedirectToAction("Index");
    }
}
