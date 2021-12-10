using System; // directive - tells it what code it needs in order to function.
using System.Collections.Generic; // if using list objects

namespace Bakery.Models
{
  public class Bread//class
  {

    public int BreadCost(int userBread)
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


  }
}