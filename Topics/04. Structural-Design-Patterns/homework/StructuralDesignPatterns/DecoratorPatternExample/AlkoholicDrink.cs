namespace DecoratorPatternExample
{
    /// <summary>
    /// The "Component" abstract class
    /// </summary>
    public abstract class AlkoholicDrink
    {
        public int AvailableCount { get; set; }

        public int EmptyBotles { get; set; }

        public abstract void ShowInfo();
    }
}