using Dealership.Contracts;
using Dealership.Engine;
using Dealership.Factories;
using Dealership.Models;
using Dealership.Ninject;
using Ninject;
using System.Reflection;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel(new DealershipModule());

            var engine = kernel.Get<DealershipEngine>();
            engine.Start();

            //DealershipEngine.Instance.Start();
        }
    }
}
