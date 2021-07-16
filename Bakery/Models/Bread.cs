using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumOfLoaves { get; set; }

    public static int BreadTotal(int inputtedBreadOrder) //method
    {
      NumOfLoaves = inputtedBreadOrder;
      int breadOrderCost = 0; //starting value is 0- will add to this to get bread total cost
      int singleLoafCost = 5;
    }
    public int CalculateBreadTotalCost()
    {
      breadOrderCost = singleLoafCost * NumOfLoaves;
      return breadOrderCost;
    }
  }
}

