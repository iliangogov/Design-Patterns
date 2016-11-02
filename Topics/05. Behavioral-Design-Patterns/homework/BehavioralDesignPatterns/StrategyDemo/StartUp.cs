namespace StrategyDemo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var db = new DbContext();  // can be always switched with MySqlDbContext in another strategy
            var extractor = new ExcelExtractor();
            var importer = new DbImporter(db, extractor);

            importer.ImportDataToDb();
        }
    }
}
