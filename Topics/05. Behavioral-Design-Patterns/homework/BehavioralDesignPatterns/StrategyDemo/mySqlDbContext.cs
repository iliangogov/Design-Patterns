using System;

namespace StrategyDemo
{
    public class MySqlDbContext : IDbContext
    {
        public void SeedData()
        {
            Console.WriteLine("Data imported to MySQL db successful");
        }
    }
}
