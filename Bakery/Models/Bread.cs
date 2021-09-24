using System;

namespace Bakery.Models
{
  public class Bread
  {

    public static int Loaves {get; set;}
    public static int Price {get; set;}
    public static int DiscountedLoaves {get;set;}
    

    public static void CalcBread(int amt)
    {
      if (amt >=3)
      {
        Loaves = amt % 3;
        DiscountedLoaves = (amt - Loaves)/3;
        Price = (Loaves * 5) + (DiscountedLoaves * 10); 
      }
      else
      {
      Loaves = amt;
      Price = Loaves * 5;
      }
    }
  }
}