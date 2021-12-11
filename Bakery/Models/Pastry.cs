namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost(int userPastry)
    {
      int remAfterThrees = userPastry % 3;
      int numberOfThrees = (userPastry - remAfterThrees) / 3;
      int costTotal = (userPastry * 2) - numberOfThrees;
      return costTotal;
    }
  }
}