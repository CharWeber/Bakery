using Bakery.Models;
using System;
using System.Threading;

namespace ProjectTest
{
  class Order
  {
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("   ____                                    ?~~bL");
        Console.WriteLine("  z@~ b                                    |  `U,");
        Console.WriteLine(" ]@[  |                                   ]'  z@'");
        Console.WriteLine(" d@~' `|, .__     _----L___----, __, .  _t'   `@j");
        Console.WriteLine("`@L_,   '-~ `--'~-a,           `C.  ~","O_    ._`@");
        Console.WriteLine("q@~'   ]P       ]@[            `Y=,   `H+z_  `a@");
        Console.WriteLine("`@L  _z@        d@               Ya     `-@b,_a'");
        Console.WriteLine("  `-@d@a'       )@[               `VL      `a@@'");
        Console.WriteLine("    aa~'   ],  .a@'                qqL  ), ./~");
        Console.WriteLine("     @@_  _z~  _d@[                 .V@  .L_d'");
        Console.WriteLine("     '~@@@'  ]@@@'        __      )@n@bza@-'");
        Console.WriteLine("       `-@zzz@@@L        )@@z     ]@@=%-'");
        Console.WriteLine("          ~~@@@@@bz_    _a@@@@z___a@K");
        Console.WriteLine("             '~-@@@@@@@@@@@@@@@@@@~'");
        Console.WriteLine("                `~~~-@~~-@@~~~~~'");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("~~~~~~~~Pierre's Bakery~~~~~~~~~");
        Console.WriteLine("Welcome to the bakery!");
        Console.WriteLine(" ");
        Console.WriteLine("---------MENU--------");
        Console.WriteLine("Loaf of Bread: $5");
        Console.WriteLine("~~~~~SALE: Buy 3 for the price of 2!");
        Console.WriteLine("Pastry: $2");
        Console.WriteLine("~~~~~SALE: Buy 3 for $5!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(" ");
        Console.WriteLine("Would you like to start an order?");
        Console.WriteLine("Y/N");
        string action = Console.ReadLine();
        if (action == "y" || action == "Y")
        {
          NewOrder();
        }
        else
        {
          Console.Write("Fine. Maybe next time.");
        }
    }
    static void NewOrder()
    {
      
      Console.Clear();
      Console.WriteLine("How much Bread would you like? Buy 2 and get the third loaf free!");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many Pastries? 1 for $2 or 3 for $5!");
      int pastryOrder = int.Parse(Console.ReadLine());
      if (breadOrder < 0 || pastryOrder < 0)
      {
        Console.WriteLine("I can't bake negative goods, Maybe try again?");
        Thread.Sleep(4000);
        NewOrder();
      }
      else if (breadOrder > 50 || pastryOrder > 50)
      {
        Console.WriteLine("You really should have called ahead for an order that large. I can give you a quote but we can't deliver that order without a 3 day notice");
        Console.WriteLine("Want the quote? Y/N?");
        string quote = Console.ReadLine();
        if (quote == "y" || quote == "Y")
        {
          Console.WriteLine("alright then, lets calculate this");
          TotalPrice(breadOrder, pastryOrder);
        }
      }
      else
      {
          Console.WriteLine("alright then, lets calculate this");
          TotalPrice(breadOrder, pastryOrder);
      }
    }
    static void TotalPrice(int breadQty, int pastryQty)
    {
      Console.WriteLine($"so you'd like {breadQty} loaves of bread and {pastryQty} pastries?");
      Pastry.CalcPastry(pastryQty);
      Bread.CalcBread(breadQty);
      int breadPrice = Bread.Price; 
      int pastryPrice = Pastry.Price;
      int totalPrice = breadPrice + pastryPrice;
      Console.WriteLine($"That'll be ${totalPrice} for {breadQty} loaves and {pastryQty} pastries.");
      Console.WriteLine("confirm order? Y/N");
      string confirm = Console.ReadLine();
      if (confirm =="y" || confirm == "Y")
      {
        Console.Clear();
        Console.WriteLine("Sure thing, here is your reciept. The order will be ready soon. Unless its massive which it'll be done when its done");
        Console.WriteLine("~~~~~~~Pierres Bakery~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~Thank you!~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");
        Console.WriteLine("Order:");
        Console.WriteLine($"Loaves: {breadQty}------------${breadPrice}");
        Console.WriteLine($"Pastries: {pastryQty}-------------${pastryPrice}");
        Console.WriteLine($"Total Price-------------${totalPrice}");
        Console.WriteLine("");
        Console.WriteLine("~~~~~~~~~~come again!~~~~~~~~~~");
      }
      else
      {
        Console.WriteLine("Would you like to change your order? or cancel it?");
        Console.WriteLine("Y for yes, N for Cancel");

        string change = Console.ReadLine();
        if (change == "y" || change == "Y")
        {
          Console.WriteLine("No problem, lets start over");
          NewOrder();
        }
        else
        {
        Console.Write("Fine. Maybe next time.");
        }
      }
      Console.WriteLine("Would you like to try again?");
      Console.WriteLine("Y/N");
      string tryAgain = Console.ReadLine();
      if (tryAgain == "y" || tryAgain == "Y")
      {
        Main();
      }
      else
      {
      Console.WriteLine("Thanks so much! Goodbye!");
      }
    }
  }
}