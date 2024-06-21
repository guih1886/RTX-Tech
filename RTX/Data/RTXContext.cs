using Microsoft.EntityFrameworkCore;
using RTX.Models;

namespace RTX.Data;

public class RTXContext : DbContext
{
    public RTXContext(DbContextOptions<RTXContext> opts) : base(opts) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Photo = "https://superprix.vteximg.com.br/arquivos/ids/208274-600-600/7898215151784--1-.jpg?v=637915926153930000", Name = "Creme de leite", Description = "Creme de leite ideal para preparo de um belo strognoff.", Price = 2.59 },
            new Product { Id = 2, Photo = "https://ibassets.com.br/ib.item.image.large/l-a61c4723589c44c1b15c32685f5cee67.png", Name = "Achocolatado Toddy", Description = "Achocolado da vaquinha.", Price = 12.99 },
            new Product { Id = 3, Photo = "https://ibassets.com.br/ib.item.image.large/l-0bb27cf2a14c450ead9ab29f0fa2b4d1.jpeg", Name = "Maionese Heinz", Description = "Maionese premium feita com ingredientes selecionados.", Price = 19.99 },
            new Product { Id = 4, Photo = "https://atacadaobr.vtexassets.com/arquivos/ids/252509/g.jpg?v=638353972719200000", Name = "Salgadinho Doritos", Description = "Salgadinho sabor cheddar, o melhor de todos.", Price = 10.00 },
            new Product { Id = 5, Photo = "https://www.paodeacucar.com/img/uploads/1/120/24982120.png", Name = "Coca-Cola 2L", Description = "Refrigerante de cola mais famoso do mundo", Price = 8.99 }
        );
    }
    public DbSet<Product> Products { get; set; }
}