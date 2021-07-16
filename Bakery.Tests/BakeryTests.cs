using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CreateConstructor_InitializesBreadTotalCostCorrectly()
    {
      Bread breadOrder = new Bread(3);
      Assert.AreEqual();
    }
  }
}