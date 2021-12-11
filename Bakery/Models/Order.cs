using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public int BreadOrder { get; set; }
    public int PastryOrder { get; set; }

    public Order(int breadOrder, int pastryOrder)
    {
      BreadOrder = breadOrder;
      PastryOrder = pastryOrder;
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