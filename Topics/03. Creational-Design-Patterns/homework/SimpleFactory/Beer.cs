using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Beer
    {
        public Beer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
