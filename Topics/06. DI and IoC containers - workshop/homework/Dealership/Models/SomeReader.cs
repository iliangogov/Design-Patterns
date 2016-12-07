using System;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class SomeReader : IReader
    {
        public string ReadLine()
        {
            //you can choose something defferent than Console
            //for testing purpose is Console.ReadLine()

           return Console.ReadLine();
        }
    }
}
