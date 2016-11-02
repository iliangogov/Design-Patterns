using System;

namespace StrategyDemo
{
    public class DbContext : IDbContext
    {
        public void SeedData()
        {
            Console.WriteLine("Data imported to db successful");
        }
    }
}
