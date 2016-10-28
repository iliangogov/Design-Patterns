using System;

namespace DecoratorPatternExample
{
    /// <summary>
    /// Class to be "Decorated"
    /// </summary>
    public class Beer : AlkoholicDrink
    {
        private readonly string name;
        private readonly int milliliters;

        public Beer(string name, int milliliters, int availableCount)
        {
            this.name = name;
            this.milliliters = milliliters;
            this.AvailableCount = availableCount;
            this.EmptyBotles = 0;
        }

        public override void ShowInfo()
        {
            string info = $"This is {this.GetType().Name} named {this.name} with quantity {this.milliliters} ml. Available count: {this.AvailableCount}. Empty bottles: {this.EmptyBotles}";
            Console.WriteLine(info);
        }
    }
}
