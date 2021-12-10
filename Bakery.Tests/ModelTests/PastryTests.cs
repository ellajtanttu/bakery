using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]

  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_CalculateTotalPastryCost_Int()
    {
      Pastry testPastry = new Pastry();
      int pastryInput = 0;
      int expectedResult = 0;
      int actualResult = testPastry.PastryCost(pastryInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void PastryCost_Calculate1Pastry_Int()
    {
      Pastry testPastry = new Pastry();
      int pastryInput = 1;
      int expectedResult = 2;
      int actualResult = testPastry.PastryCost(pastryInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void PastryCost_Calculate2Pastry_Int()
    {
      Pastry testPastry = new Pastry();
      int pastryInput = 2;
      int expectedResult = 4;
      int actualResult = testPastry.PastryCost(pastryInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void PastryCost_Calculate3Pastry_Int()
    {
      Pastry testPastry = new Pastry();
      int pastryInput = 3;
      int expectedResult = 5;
      int actualResult = testPastry.PastryCost(pastryInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Item()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
  }
}

/*
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
*/