using System;
using System.Collections.Generic;
using System.Linq;
namespace StrategyDemo
{
    public class DbImporter
    {
        public DbImporter(IDbContext db,IExcelExtractor extractor)
        {
            this.Db = db;
            this.Extractor = extractor;
        }

        public IDbContext Db { get; set; }

        public IExcelExtractor Extractor { get; set; }

        public void ImportDataToDb()
        {
            this.Extractor.ExtractDataFromXcell();
            this.Db.SeedData();
        }
    }
}
