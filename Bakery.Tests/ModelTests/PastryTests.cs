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
      //Arrange
      Pastry testPastry = new Pastry();
      int pastryInput = 0;
      int expectedResult = 0;
      //Act
      int actualResult = testPastry.PastryCost(pastryInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }
    [TestMethod]
    public void PastryCost_Calculate1Pastry_Int()
    {
      //Arrange
      Pastry testPastry = new Pastry();
      int pastryInput = 1;
      int expectedResult = 2;
      //Act
      int actualResult = testPastry.PastryCost(pastryInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}

/*
Pastry:
Example input: PastryCost(1)
Example output: 2

Example input: PastryCost(2)
Example output: 4

Example input: PastryCost(3)
Example output: 5

Example input: PastryCost(4)
Example output: 7

Example input: PastryCost(5)
Example output: 9

Example input: PastryCost(6)
Example output: 10
*/