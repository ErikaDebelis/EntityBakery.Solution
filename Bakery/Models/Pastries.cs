using System;
using System.Collections.Generic;
namespace Bakery.Pastries
{
  public class Pastry
  {
    public void PastryTotal()
    {
      Console.WriteLine("what about this one?");
    }
  }
}






    // public int NumOfPastries { get; set; }

    // public static int PastryTotal(int inputtedPastryOrder) //method
    // {
    //   NumOfPastries = inputtedBreadOrder;
    //   int pastryOrderCost = 0; //starting value is 0- will add to this to get pastry total cost
    //   int singlePastryCost = 5;
    //   int pastryDiscount = 0// starting value is 0- will add to this to get pastry total discount amount
    // }
    // public int CalculateBreadTotalCost()
    // {
    //   pastryOrderCost = singlepastryCost * NumOfPastries;
    //   return pastryOrderCost;
    // }
    // public int PastriesDiscounted()
    // {
      //int freePastry = NumOfPastries / 3;
      //PastriesDiscounted = (NumOfPastries - freePastry) * singlePastryCost;
    // }

  //buy 2 get 1 free:
  //Total cost =2x
  //Discount =3x−2x=x
  //Discount percentage =x/(3x)=0.333=33 1/3%