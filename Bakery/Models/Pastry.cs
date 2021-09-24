using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static int Pastries {get;set;}
    public static int Price {get;set;}
    public static int DiscountedPastries {get;set;}

    public static void CalcPastry(int amt)
    {
      if (amt >= 3)
      {
        Pastries = amt % 3;
        DiscountedPastries = (amt - Pastries)/3;
        Price = (Pastries * 2) + (DiscountedPastries * 5);
      }
      else
      {
      Pastries = amt;
      Price = Pastries * 2;
      }
    }
  }
}