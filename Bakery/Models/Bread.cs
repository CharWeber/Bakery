using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public static int BreadOrdered {get;set;}
    public static int BreadPrice {get;set;}
    public static int BreadDiscountLoaves {get; set;}
    public static int BreadNormalPrice {get;set;}

  public int calcBread()
  {
    return 5;
  }
  }
}