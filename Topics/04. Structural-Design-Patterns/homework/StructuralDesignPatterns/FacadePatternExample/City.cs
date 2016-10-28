namespace FacadePatternExample
{
    public class City
    {
        private readonly string name;
        private readonly int population;

        public City(string name, int population)
        {
            this.name = name;
            this.population = population;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Population
        {
            get { return this.population; }
        }

    }
}
