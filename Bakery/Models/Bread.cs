using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {

    public static int Loaves {get; set;}
    public static int Price {get; set;}

    public static void CalcBread(int amt)
    {
      Loaves = amt;
      Price = amt * 5;
    }
  }
}