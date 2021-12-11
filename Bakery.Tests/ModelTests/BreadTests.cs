using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CalculateTotalBreadCost_Int()
    {
      Bread testBread = new Bread();
      int breadInput = 0;
      int expectedResult = 0;
      int actualResult = testBread.BreadCost(breadInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_CalculateOneLoaf_Int()
    {
      Bread testBread = new Bread();
      int breadInput = 1;
      int expectedResult = 5;
      int actualResult = testBread.BreadCost(breadInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate2Loaves_Int()
    {
      Bread testBread = new Bread();
      int breadInput = 2;
      int expectedResult = 10;
      int actualResult = testBread.BreadCost(breadInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate3Loaves_Int()
    {
      Bread testBread = new Bread();
      int breadInput = 3;
      int expectedResult = 10;
      int actualResult = testBread.BreadCost(breadInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate4Loaves_Int()
    {
      Bread testBread = new Bread();
      int breadInput = 4;
      int expectedResult = 15;
      int actualResult = testBread.BreadCost(breadInput);
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate36Loaves_Int()
    {
      Bread testBread = new Bread();
      int breadInput = 36;
      int expectedResult = 120;
      int actualResult = testBread.BreadCost(breadInput);
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}