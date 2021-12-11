using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("---------------------------");
    Console.WriteLine("WELCOME TO PIERRE'S BAKERY!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Current Prices:");
    Console.WriteLine("Bread - $5.00 (bulk discounts available)");
    Console.WriteLine("Pastry - $2.00 (bulk discounts available)");
    Console.WriteLine("---------------------------");
    SubMain();
    static void SubMain()
    {
      Bread userBread = new Bread();
      Pastry userPastry = new Pastry();
      int breadTotal = 0;
      int pastryTotal = 0;
      int breadAllTotal = 0;
      int pastryAllTotal = 0;
      Console.WriteLine("Would you like to place an order? ['Y' for yes, 'Enter' for no]");
      string newOrderAnswer = Console.ReadLine();
      if (newOrderAnswer == "Y" || newOrderAnswer == "y")
      {
        try
        {
          Console.WriteLine("How many loaves of bread would you like to purchase?");
          int userBreadNum = int.Parse(Console.ReadLine());
          Console.WriteLine("How many pastries would you like to purchase?");
          int userPastryNum = int.Parse(Console.ReadLine());
          new Order(userBreadNum, userPastryNum);
          Console.WriteLine("---------------------------");
          SubMain();
        }
        catch
        {
          Console.WriteLine("---------------------------");
          Console.WriteLine("Please enter a whole number only.");
          Console.WriteLine("---------------------------");
          SubMain();
        }
      }
      else
      {
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Would you like to see a list of your orders? ['Y' for yes, 'Enter' for no]");
        string seeAllOrders = Console.ReadLine();
        Console.WriteLine("---------------------------");
        if (seeAllOrders == "Y" || seeAllOrders == "y")
        {
          if (Order.GetAll().Count == 0)
          {
            Console.WriteLine("---------------------------");
            Console.WriteLine("It looks like you haven't placed an order yet! Please place one first. ");
            Console.WriteLine("---------------------------");
            SubMain();
          }
          else
          {
            foreach (Order thisOrder in Order.GetAll())
            {
              Console.WriteLine("---------------------------");
              Console.WriteLine("--ORDER--");
              Console.WriteLine($"Loaves of Bread: {thisOrder.BreadOrder}");
              breadTotal = userBread.BreadCost(thisOrder.BreadOrder);
              Console.WriteLine($"${breadTotal}.00");
              Console.WriteLine($"Pastries: {thisOrder.PastryOrder}");
              pastryTotal = userPastry.PastryCost(thisOrder.PastryOrder);
              Console.WriteLine($"${pastryTotal}.00");
              Console.WriteLine("---------------------------");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Would you like to clear your orders list? ['Y' for yes, 'Enter' for no]");
            string clearOrders = Console.ReadLine();
            Console.WriteLine("---------------------------");
            if (clearOrders == "Y" || clearOrders == "y")
            {
              Order.ClearAll();
              SubMain();
            }
            else
            {
              Console.WriteLine(" ");
              Console.WriteLine("---------------------------");
              Console.WriteLine("Are you ready to check out? ['Y' for yes, 'Enter' for no]");
              string checkOut = Console.ReadLine();
              Console.WriteLine("---------------------------");
              if (checkOut == "Y" || checkOut == "y")
              {
                Console.WriteLine("Your Receipt:");
                foreach (Order thisOrder in Order.GetAll())
                {
                  breadAllTotal += userBread.BreadCost(thisOrder.BreadOrder);
                  pastryAllTotal += userPastry.PastryCost(thisOrder.PastryOrder);
                }
                Console.WriteLine($"Bread Total: ${breadAllTotal}.00");
                Console.WriteLine($"Pastry Total: ${pastryAllTotal}.00");
                Console.WriteLine($"ORDER TOTAL: ${breadAllTotal + pastryAllTotal}.00");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Thanks for your business. Have a wonderful day!");
                Console.WriteLine("---------------------------");
                Order.ClearAll();
                Main();
              }
              else
              {
                Main();
              }
            }
          }
        }
        else
        {
          Main();
        }
      }
    }
  }
}