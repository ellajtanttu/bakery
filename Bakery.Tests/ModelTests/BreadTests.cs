using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CalculateTotalBreadCost_Int()
    {
      //Arrange
      Bread testBread = new Bread();
      int breadInput = 0;
      int expectedResult = 0;
      //Act
      int actualResult = testBread.BreadCost(breadInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_CalculateOneLoaf_Int()
    {
      //Arrange
      Bread testBread = new Bread();
      int breadInput = 1;
      int expectedResult = 5;
      //Act
      int actualResult = testBread.BreadCost(breadInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate2Loaves_Int()
    {
      //Arrange
      Bread testBread = new Bread();
      int breadInput = 2;
      int expectedResult = 10;
      //Act
      int actualResult = testBread.BreadCost(breadInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate3Loaves_Int()
    {
      //Arrange
      Bread testBread = new Bread();
      int breadInput = 3;
      int expectedResult = 10;
      //Act
      int actualResult = testBread.BreadCost(breadInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate4Loaves_Int()
    {
      //Arrange
      Bread testBread = new Bread();
      int breadInput = 4;
      int expectedResult = 15;
      //Act
      int actualResult = testBread.BreadCost(breadInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BreadCost_Calculate36Loaves_Int()
    {
      //Arrange
      Bread testBread = new Bread();
      int breadInput = 36;
      int expectedResult = 120;
      //Act
      int actualResult = testBread.BreadCost(breadInput);
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }


  }
}
/*
X Example input: BreadCost(0)
Example output: 0

X Example input: BreadCost(1)
Example output: 5

X Example input: BreadCost(2)
Example output: 10

XExample input: BreadCost(3)
Example output: 10, Deal! - add "Deal!" only for mults of 3

X5
Example input: BreadCost(4)
Example output: 15,

6
Example input: BreadCost(6)
Example output: 20

7
Example input: BreadCost(20)
Example output: 70

8
Example input: BreadCost(36)
Example output: 120
*/

/*



NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()

Create a C# console application for a bakery that includes the
following functionality:

X - There should be two classes: one for Bread and one for Pastry.

- When the user runs the application, they should receive a prompt
with a welcome message along with the cost for both Bread and Pastry.

- A user should be able to specify how many loaves of Bread and how
many Pastrys they'd like.

The application will return the total cost of the order.

Pierre offers the following deals:

Bread:
- Buy 2, get 1 free (every 3rd loaf of bread is free.)
- A single loaf costs $5, two loaves costs $10, and three loaves cost $10.

Pastry:
- Buy 1 for $2 or 3 for $5.
- Four pastries costs $7, five pastries costs $9, and six pastries costs $10.

All functionality for the models should be tested.


Order of events:
1. prompt with a welcome message along with the cost for both Bread and
Pastry, and question of how much of each
2. User enters amounts of each type
3. TO FIGURE OUT: logic separation for the total cost
  - BreadCost():
    - logic for the cost of bread
  - pastryCost():
    - logic for the cost of pastry
  - both will take a number as a parameter

4. return message with final cost to user, (and details of discount)

Specs Plain English:
Bread:
Example input: BreadCost(0)
Example output: 0

Example input: BreadCost(1)
Example output: 5

Example input: BreadCost(2)
Example output: 10

Example input: BreadCost(3)
Example output: 10, Deal! - add "Deal!" only for mults of 3

Example input: BreadCost(4)
Example output: 15,

Example input: BreadCost(6)
Example output: 20

Example input: BreadCost(20)
Example output: 70

Example input: BreadCost(36)
Example output: 120


*/