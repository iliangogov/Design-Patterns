using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public class StartUp
    {
        static void Main()
        {
            var beer = new Beer("Ariana", 500, 3);
            beer.ShowInfo();

            var sellableBeer = new Sellable(beer);
            sellableBeer.SellDrinkTo("Iliyan");
            sellableBeer.SellDrinkTo("Zahari");
            sellableBeer.ReturnBottle("Iliyan");

            sellableBeer.ShowByers();
            beer.ShowInfo();
        }
    }
}
