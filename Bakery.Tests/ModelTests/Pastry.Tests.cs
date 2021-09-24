using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    //test #1
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_True()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(testPastry.GetType(), typeof(Pastry));
    }
    //test #2
    [TestMethod]
    public void Pastry_SetsPriceForOnePastry_Int()
    {
      Pastry testPastry = new Pastry();
      Pastry.CalcPastry(1);
      int result = Pastry.Price;
      Assert.AreEqual(2, result);
    }
  }
}