using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public int BreadOrder { get; set; }
    public int PastryOrder { get; set; }

    private static List<Order> _instances = new List<Order> {};

    public Order(int breadOrder, int pastryOrder)
    {
      BreadOrder = breadOrder;
      PastryOrder = pastryOrder;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}


/*
X Create an order class
X Inside is an order constructor with
X - field for pastry order and field for bread order
When a user enters the amounts they’d like, it will instantiate the object.

Each instance will be added to a static list within the order class

User can see list of orders
User can ask for total cost of all orders
*/