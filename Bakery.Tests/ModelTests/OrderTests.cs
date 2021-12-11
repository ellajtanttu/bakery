using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order(0,0);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

   [TestMethod]
    public void GetBreadNum_ReturnBNum_Int()
    {
      int breadOrder = 0;
      Order testOrder = new Order(breadOrder,0);
      int bOrderRes = testOrder.BreadOrder;
      Assert.AreEqual(breadOrder, bOrderRes);
    }

    [TestMethod]
    public void GetPastryNum_ReturnPNum_Int()
    {
      int pastryOrder = 0;
      Order testOrder = new Order(0,pastryOrder);
      int pOrderRes = testOrder.PastryOrder;
      Assert.AreEqual(pastryOrder, pOrderRes);
    }

    [TestMethod]
    public void SetBreadOrder_SetBreadOrder_Int()
    {
      int breadOrder = 0;
      Order testOrder = new Order(breadOrder,0);
      int updatedBreadOrder = 1;
      testOrder.BreadOrder = updatedBreadOrder;
      int bOrderRes = testOrder.BreadOrder;
      Assert.AreEqual(updatedBreadOrder, bOrderRes);
    }
  }
}

/*
1. create an object
2. instantiate object with properties
*/