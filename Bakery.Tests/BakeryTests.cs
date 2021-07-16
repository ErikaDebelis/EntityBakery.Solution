using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;


namespace BakeryTests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_InitializesBread_Bread()
    {
      Bread newBreadOrder = new Bread();
      Assert.AreEqual(typeof(bread), newBreadOrder.GetType());
    }
  }
}