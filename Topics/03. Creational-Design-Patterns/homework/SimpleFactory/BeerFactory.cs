using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class BeerFactory
    {
        private const string LIGHT_BEER_NAME = "Ariana";
        private const string DARK_BEER_NAME = "Kozel";

        public Beer GetBeer(BeerType beerType)
        {
            switch (beerType)
            {
                case BeerType.Light:
                    return new LightBeer(LIGHT_BEER_NAME);
                case BeerType.Dark:
                    return new DarkBeer(DARK_BEER_NAME);
                default: throw new ArgumentException("Not such a beer in our Bar !");
            }
        }
    }
}
