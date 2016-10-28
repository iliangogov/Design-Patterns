using System;
using System.Collections.ObjectModel;

namespace FacadePatternExample
{
    public static class CityFactory
    {
        public static Collection<City>GetAllCities()
        {
            var collectionOfCities = new Collection<City>();
            var sofia = new City("Sofia", 1500000);
            var plovdiv = new City("Plovdiv", 500000);
            var varna = new City("Varna", 700000);
            var burgas = new City("Burgas", 600000);
            var ruse = new City("Ruse", 200000);
            collectionOfCities.Add(sofia);
            collectionOfCities.Add(plovdiv);
            collectionOfCities.Add(varna);
            collectionOfCities.Add(burgas);
            collectionOfCities.Add(ruse);
            Console.WriteLine("Cities has been imported to the map");
            return collectionOfCities;
        }
    }
}
