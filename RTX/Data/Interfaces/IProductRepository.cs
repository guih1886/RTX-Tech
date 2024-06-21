using RTX.Models;

namespace RTX.Data.Interfaces;

public interface IProductRepository
{
    List<Product> GetProducts();
    Product? GetProductById(int id);
    List<Product> FilterProductsByNameAndDescription(string filterTerm);
    bool CreateProduct(Product product);
    bool DeleteProduct(int id);
}
