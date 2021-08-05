using System.Collections.Generic;

namespace Bakery.Models
{
  public class Special
  {
    public Special()
    {
      this.JointEntities = new HashSet<ProductSpecial>();
    }

    public int SpecialId { get; set; }
    public double Discount { get; set; }

    public virtual ICollection<ProductSpecial> JointEntities { get; set; }
  }
}
