using System.Collections.Generic;

namespace Bakery.Models{
  public class Category{
    public Category()
    {
      this.JointEntities = new HashSet<CategoryProduct>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<CategoryProduct> JointEntities { get; set; }
  }
}