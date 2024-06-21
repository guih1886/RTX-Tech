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
    [Required(ErrorMessage = "Digite a url da imagem.")]
    [Url(ErrorMessage = "A url da imagem é inválida.")]
    public string Photo { get; set; }
    [Required(ErrorMessage = "Digite a nome do produto.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Digite a descrição do produto.")]
    public string Description { get; set; }
    public double Price { get; set; }
}
