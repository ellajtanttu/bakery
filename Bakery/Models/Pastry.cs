using System;
using System.Collections.Generic; // if using list objects

namespace Bakery.Models
{
  public class Pastry
  {
    public int ReqPastryNum { get; set; }

    // public Pastry(int reqPastryNum)
    // {
    //   ReqPastryNum = reqPastryNum;
    // }
    public int PastryCost(int userPastry)
    {
      int remAfterThrees = userPastry % 3;
      int numberOfThrees = (userPastry - remAfterThrees) / 3;
      int costTotal = (userPastry * 2) - numberOfThrees;
      return costTotal;
    }
  }
}


/*
public string MakeModel { get; set; }
public int Price { get; set; }
public int Miles { get; set; }

public Car(string makeModel, int price, int miles)
{
  MakeModel = makeModel;
  Price = price;
  Miles = miles;
}
*/