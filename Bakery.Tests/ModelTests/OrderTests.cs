using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> testList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      int breadOrderOne = 0;
      int breadOrderTwo = 1;
      Order testOrder1 = new Order(breadOrderOne,0);
      Order testOrder2 = new Order(breadOrderTwo,0);
      List<Order> newOrderList = new List<Order> {testOrder1, testOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}