namespace FacadePatternExample
{
    public class StartUp
    {
        static void Main()
        {
            var sampleMap = new BulgariaMiniMap();
            sampleMap.Initialize();
            sampleMap.ShowAllCities();
            sampleMap.ShowTotalPopulation();
        }
    }
}
