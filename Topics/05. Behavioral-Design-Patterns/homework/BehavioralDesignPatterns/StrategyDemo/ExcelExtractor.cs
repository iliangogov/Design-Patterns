using System;

namespace StrategyDemo
{
    public class ExcelExtractor : IExcelExtractor
    {
        public void ExtractDataFromXcell()
        {
            Console.WriteLine("Excel data extracted successful");
        }
    }
}
