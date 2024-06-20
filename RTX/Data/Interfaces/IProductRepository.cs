using RTX.Models;

namespace RTX.Data.Interfaces;

public interface IProductRepository
{
    List<Product>? GetProducts();
    Product? GetProductById(int id);
    bool CreateProduct(Product product);
}
