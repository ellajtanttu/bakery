using System; // directive - tells it what code it needs in order to function.
using System.Collections.Generic; // if using list objects

namespace Bakery.Models
{
  public class Pastry//class
  {
    public int PastryCost(int userPastry) // 12
    {
      int remAfterThrees = userPastry % 3; // 0
      int numberOfThrees = (userPastry - remAfterThrees) / 3; // 4
      int discountTotal = (userPastry * 2) - numberOfThrees; // 20
      int nonDiscountTotal = remAfterThrees * 2; // 0
      return discountTotal + nonDiscountTotal; // 20


    }
  }
}

/*
    {
      int simplifiedOrder = userBread / 3;
      int discLoafPrice = simplifiedOrder * 10;

      if (userBread % 3 == 0)
      {
        return discLoafPrice;
      }
      else
      {
        int orderRemainder = userBread % 3;
        int nonDiscount = orderRemainder * 5;
        return discLoafPrice + nonDiscount;
      }
    }
*/