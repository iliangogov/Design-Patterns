namespace SingletonExample
{
    class Program
    {
        static void Main()
        {
            string textExample = "Singleton example works!";
            var writer = SpecificWriter.Instance;

            writer.WriteTextToConsole(textExample);
        }
    }
}
