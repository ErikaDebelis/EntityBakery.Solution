using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : DbContext
  {
    public DbSet<Product> Products {get; set; }
    public DbSet<Special> Specials {get; set; }
    public DbSet<ProductSpecial> ProductSpecial {get; set; }
    public DbSet<Category> Categories {get; set; }
    public DbSet<CategoryProduct> CategoryProduct {get; set; }
  
    public BakeryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}