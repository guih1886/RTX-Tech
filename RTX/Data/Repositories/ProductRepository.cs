using RTX.Data.Interfaces;
using RTX.Models;

namespace RTX.Data.Repository;

public class ProductRepository : IProductRepository
{
    private RTXContext _context;

    public ProductRepository(RTXContext context)
    {
        _context = context;
    }

    public bool CreateProduct(Product product)
    {
        try
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public Product? GetProductById(int id)
    {
        Product? product = _context.Products.FirstOrDefault(p => p.Id == id);
        return product;
    }
    public List<Product>? GetProducts()
    {
        List<Product>? product = _context.Products.ToList();
        return product;
    }
}