namespace Bakery.Pastries
{
  public class Pastry
  {
    public int NumOfPastries { get; set; }
    public int CostOfPastry {get; set; }
    public int PastryDiscount {get; set; }

    public static int PastryTotal(int inputtedPastryOrder) //method
    {
      NumOfPastries = inputtedBreadOrder;
      int pastryOrderCost = 0; //starting value is 0- will add to this to get bread total cost
      int singlePastryCost = 5;
    }
    public int CalculateBreadTotalCost()
    {
      pastryOrderCost = singlepastryCost * NumOfPastries;
      return pastryOrderCost;
    }
  }
}