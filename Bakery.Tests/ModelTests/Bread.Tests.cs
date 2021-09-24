using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bakery.TestTools
{
  [TestClass]
  public class BakeryTests
  {
    // Test #1
    [TestMethod]
    public void Bread_createInstanceOfBread_True()
    {
      Bread testOrder = new Bread
      Assert.AreEqual(testOrder.GetType(), typeof(Bread))
    }
  }
}