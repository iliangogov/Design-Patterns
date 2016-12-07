namespace Adapter
{
    /// <summary>
    /// The client code
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            var water = new ChemicalDatabank();
            System.Console.WriteLine( water.GetCriticalPoint("water","M"));

            //ICompound water = new RichCompound("Water");
            //water.Display();

            //ICompound benzene = new RichCompound("Benzene");
            //benzene.Display();

            //ICompound ethanol = new RichCompound("Ethanol");
            //ethanol.Display();
        }
    }
}
