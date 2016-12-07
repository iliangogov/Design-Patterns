using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class SomeWriter : IWriter
    {
        public void Write(string text)
        {
            //you can choose something defferent than Console
            //for testing purposess is Console.WriteLine()

            Console.WriteLine(text);
        }
    }
}
