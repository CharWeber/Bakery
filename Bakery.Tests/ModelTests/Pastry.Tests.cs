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
  }
}