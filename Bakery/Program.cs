using System;
using System.Collections.Generic;
using Bakery.Breads;
using Bakery.Pastries;
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
    //   Console.WriteLine("Welcome to Pierre's Bakery Web Application");
    //   Console.WriteLine("__________________________________________");
    //   Console.WriteLine("Would you like to order bread or pastries? Type 'bread' for bread and 'pastries' for pastries.");
    //    string bakeryChoice = Console.ReadLine();
    //    if (bakeryChoice == "bread")
    //      {
    //        int totalBreadCost = Bread.BreadTotal(inputtedBreadOrder);
    //        Console.WriteLine(totalBreadCost);
    //      }
    //      else if (bakeryChoice = "pastries")
    //      {
    //        int totalPastryCost = Pastry.PastryTotal(inputtedPastryOrder);
    //        Console.WriteLine(totalPastryCost);
    //      }
    //      else
    //      {
    //        Console.WriteLine("Error: please only input either 'bread' of 'pastries'.)
    //      }
    //      
      Bread newBreadOrder = new Bread();
    // Pastry newPastryOrder = new Pastry();
      newBreadOrder.BreadTotal();
    // newPastryOrder.PastryTotal();
    }
  }
}