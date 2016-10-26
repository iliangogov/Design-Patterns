namespace FluentInterfaceExample
{
    public class Cat
    {
        public string Name { get; private set; }

        public string FurColor { get; private set; }

        public string State { get; private set; }

        public int AgeInMonths { get; private set; }

        public Cat()
        {
        }

        public Cat(string name, string color, string state, int ageInMonths)
        {
            this.Name = name;
            this.FurColor = color;
            this.State = state;
            this.AgeInMonths = ageInMonths;
        }

        public Cat WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public Cat WithColor(string color)
        {
            this.FurColor = color;
            return this;
        }

        public Cat WithState(string state)
        {
            this.State = state;
            return this;
        }

        public Cat WithAge(int age)
        {
            this.AgeInMonths = age;
            return this;
        }

        public override string ToString()
        {
            return "The " + this.FurColor + " cat " + this.Name + " is " + this.AgeInMonths + " months old and is " + this.State;
        }
    }
}
