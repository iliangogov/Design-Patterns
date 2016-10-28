using System;
using System.Collections.ObjectModel;
using System.Text;

namespace FacadePatternExample
{
    /// <summary>
    /// Facade class
    /// </summary>
    public class BulgariaMiniMap
    {
        private Collection<City> cities;

        public void Initialize()
        {
            Console.WriteLine("Bulgarian map has been created");
            var allCities = CityFactory.GetAllCities();
            this.cities = new Collection<City>(allCities);
        }

        public void ShowAllCities()
        {
            var builder = new StringBuilder();
            foreach (var city in this.cities)
            {
                builder.Append("City: ");
                builder.AppendLine(city.Name);
            }
            Console.WriteLine("Biggest cities in Bulgaria:");
            Console.WriteLine(builder);
        }

        public void ShowTotalPopulation()
        {
            var totalPopulation = 0;
            foreach(var city in this.cities)
            {
                totalPopulation += city.Population;
            }

            Console.WriteLine($"Biggest cities in Bulgaria has population: {totalPopulation} people");
        }
    }
}
