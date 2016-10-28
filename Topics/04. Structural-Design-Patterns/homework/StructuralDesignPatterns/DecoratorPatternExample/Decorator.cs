namespace DecoratorPatternExample
{
    /// <summary>
    /// The "Decorator" abstract class
    /// </summary>
    public class Decorator : AlkoholicDrink
    {
        protected Decorator(AlkoholicDrink alkoholicDrink)
        {
            this.AlkoholicDrink = alkoholicDrink;
        }

        protected AlkoholicDrink AlkoholicDrink { get; private set; }

        public override void ShowInfo()
        {
            this.AlkoholicDrink.ShowInfo();
        }
    }
}
