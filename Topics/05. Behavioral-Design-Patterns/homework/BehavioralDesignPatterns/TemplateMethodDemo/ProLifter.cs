using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDemo
{
    public class ProLifter : HeavyLifter
    {
        public ProLifter(string name) : base(name)
        {
        }

        public override void SayHowMuchYouLift()
        {
            base.SayHowMuchYouLift();
            Console.WriteLine("I can lift more then amateurs");
        }
    }
}
