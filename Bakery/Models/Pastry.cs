using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static int Pastries {get;set;}
    public static int Price {get;set;}

    public static void CalcPastry(int amt)
    {
      Pastries = amt;
      Price = Pastries * 2;
    }
  }
}