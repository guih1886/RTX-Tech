using Microsoft.EntityFrameworkCore;
using RTX.Models;

namespace RTX.Data;

public class RTXContext : DbContext
{
    public RTXContext(DbContextOptions<RTXContext> opts) : base(opts) { }


    public DbSet<Product> Products { get; set; }
}
