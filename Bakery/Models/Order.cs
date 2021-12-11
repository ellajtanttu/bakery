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