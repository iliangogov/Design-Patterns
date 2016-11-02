using System;

namespace TemplateMethodDemo
{
    public class AmateurLifter : HeavyLifter
    {
        public AmateurLifter(string name) : base(name)
        {
        }

        public override void SayHowMuchYouLift()
        {
            base.SayHowMuchYouLift();
            Console.WriteLine("I can lift 20kg now :)");
        }
    }
}
