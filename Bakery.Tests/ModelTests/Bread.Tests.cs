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
      Bread testOrder = new Bread();
      Assert.AreEqual(testOrder.GetType(), typeof(Bread));
    }
    //Test #2
    [TestMethod]
    public void Bread_ReturnsBreadPriceForOneLoaf_Int()
    {
      Bread testOrder = new Bread();
      Bread.CalcBread(1);
      int result = Bread.Price;
      Assert.AreEqual(5, result);
    }
    //Test #3
    [TestMethod]
    public void Bread_returnBreadPriceFourLoaves_Int()
    {
      Bread testOrder = new Bread();
      Bread.CalcBread(4);
      int result = Bread.Price;
      Assert.AreEqual(15, result);
    }
    //Test #4 for Posterity
    [TestMethod]
    public void Bread_ReturnBreadPriceTenLoaves_Int()
    {
      Bread testOrder = new Bread();
      Bread.CalcBread(10);
      int result = Bread.Price;
      Assert.AreEqual(35, result);
    }  
  }
}