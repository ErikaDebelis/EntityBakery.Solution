namespace Bakery.Models{
  public class ProductSpecial
  {
    public int ProductSpecialId { get; set; }
    public int SpecialId { get; set; }
    public int ProductId { get; set; }
    public virtual Special Special { get; set; }
    public virtual Product Product { get; set; }
  }
}