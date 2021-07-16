using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Breads;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_InitializesBread_Bread()
    {
      Breads newBreadOrder = new Breads("Test");
      Assert.AreEqual(typeof(bread), newBreadOrder.GetType());
    }
  }
}