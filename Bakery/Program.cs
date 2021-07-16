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
    //    string bakeryChoice = Console.ReadLine().ToUpper();
    //    if (bakeryChoice == "bread")
    //      {
    //        try
    //        {
    //        Console.WriteLine("We're currently running an AMAZING bread special! Buy 2 loaves- get one FREE")
    //        Console.WriteLine("How many loaves would you like to purchase?")
    //        inputtedBreadOrder= Console.ReadLine();
    //        int totalBreadCost = Bread.BreadTotal(inputtedBreadOrder);
    //        Console.WriteLine(totalBreadCost);
    //        }
    //        catch
    //        {
    //        Console.WriteLine("Invalid input: enter a positive numeric integer to proceed.")
    //        }
    //      }
    //      else if (bakeryChoice = "pastries")
    //      {
    //        try
    //        {
    //        Console.WriteLine("We're currently running an PHENOMENAL pastry special! Buy 1 pastry for $2 or 3 pastries for $5!")
    //        Console.WriteLine("How many pastries would you like to purchase?")
    //        inputtedPastryOrder= Console.ReadLine();
    //        int totalPastryCost = Pastry.PastryTotal(inputtedPastryOrder);
    //        Console.WriteLine(totalPastryCost);
    //        }
    //        catch
    //        {
    //        Console.WriteLine("Invalid input: enter a positive numeric integer to proceed.")
    //        }
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