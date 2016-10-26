using System;

namespace SimpleFactory
{
    class Run
    {
        static void Main()
        {
            var greedyBarman = new BeerFactory();
            var usualBeer = greedyBarman.GetBeer(BeerType.Dark);

            Console.WriteLine(usualBeer.Name);
        }
    }
}
