using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    Bread userBread = new Bread();
    Pastry userPastry = new Pastry();
    Console.WriteLine("---------------------------");
    Console.WriteLine("WELCOME TO PIERRE'S BAKERY!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Current Prices:");
    Console.WriteLine("Bread - $5.00 (bulk discounts available)");
    Console.WriteLine("Pastry - $2.00 (bulk discounts available)");
    Console.WriteLine("---------------------------");
    Console.WriteLine("How many loaves of bread would you like to purchase?");
    try
    {
      int userBreadNum = int.Parse(Console.ReadLine());
      int breadTotal = userBread.BreadCost(userBreadNum);
      Console.WriteLine("How many pastries would you like to purchase?");
      int userPastryNum = int.Parse(Console.ReadLine());
      int pastryTotal = userPastry.PastryCost(userPastryNum);
      Console.WriteLine(" ");
      Console.WriteLine("Thank you! Your Receipt:");
      int orderTotal = breadTotal + pastryTotal;
      Console.WriteLine($"Bread Total: ${breadTotal}.00");
      Console.WriteLine($"Pastry Total: ${pastryTotal}.00");
      Console.WriteLine($"ORDER TOTAL: ${orderTotal}.00");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Would you like to place another order? ['Y' for yes, 'Enter' for no]");
      string newOrderAnswer = Console.ReadLine();
      if (newOrderAnswer == "Y" || newOrderAnswer == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thanks for your business. Have a wonderful day!");
      }
    }
    catch
    {
      Console.WriteLine("Please enter a whole number only.");
      Main();
    }
  }
}