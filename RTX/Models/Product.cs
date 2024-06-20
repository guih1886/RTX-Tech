using System.ComponentModel.DataAnnotations;

namespace RTX.Models;

public class Product
{
    public Product() {    }

    public Product(int id, string photo, string name, string description, double price)
    {
        Id = id;
        Photo = photo;
        Name = name;
        Description = description;
        Price = price;
    }

    [Key]
    public int Id { get; set; }
    public string Photo { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}
