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
    //test #3
    [TestMethod]
    public void Pastry_setPriceForFourPastries_Int()
    {
      Pastry testPastry = new Pastry();
      Pastry.CalcPastry(4);
      int result = Pastry.Price;
      Assert.AreEqual(7, result);
    }
    //test #4
    [TestMethod]
    public void Pastry_setPriceForThirteenPastries_Int()
    {
      Pastry testPastry = new Pastry();
      Pastry.CalcPastry(13);
      int result = Pastry.Price;
      Assert.AreEqual(22, result);
    }
  }
}