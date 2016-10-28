using System;
using System.Collections.Generic;

namespace DecoratorPatternExample
{
    /// <summary>
    /// Concrete decoration
    /// </summary>
    public class Sellable : Decorator
    {
        private readonly Dictionary<string, string> byersBotles = new Dictionary<string, string>();

        public Sellable(AlkoholicDrink alkoholicDrink) : base(alkoholicDrink)
        {
        }

        public void SellDrinkTo(string name)
        {
            this.byersBotles.Add(name,"has baught a Beer but still own the bottle");
            this.AlkoholicDrink.AvailableCount--;
        }

        public void ReturnBottle(string name)
        {
            this.byersBotles[name] = "has baught a Beer and allready returned the empty bottle";
            this.AlkoholicDrink.EmptyBotles++;
        }

        public void ShowByers()
        {
            foreach (var byer in byersBotles)
            {
                Console.WriteLine($"{byer.Key} {byer.Value}");
            }
        }
    }
}
