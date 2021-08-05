using System.Collections.Generic;

namespace Bakery.Models
{
  public class Product
  {
    public Product()
    {
    this.JointEntities = new HashSet<ProductSpecial>();
    }

    public int ProductId { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Cost { get; set; }

    public virtual ICollection<ProductSpecial> JointEntities { get; }
  }
}
