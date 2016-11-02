using System;

namespace TemplateMethodDemo
{
    public abstract class HeavyLifter
    {
        public HeavyLifter(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }

        public virtual void SayHowMuchYouLift()
        {
            Console.WriteLine("I'm lifting weights ");
        }
    }
}
