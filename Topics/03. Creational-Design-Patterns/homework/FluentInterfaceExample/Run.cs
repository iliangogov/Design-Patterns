using System;

namespace FluentInterfaceExample
{
    class Run
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cats: ");

            var catOne = new Cat("Maca", "black", "purring", 2);
            var catTwo = new Cat()
                              .WithName("Masha")
                              .WithAge(2)
                              .WithColor("black")
                              .WithState("purring");

            Console.WriteLine("Cat 1: " + catOne);
            Console.WriteLine("Cat 2: " + catTwo);

            // fluent switch

            Console.WriteLine("\nSwitch demo: ");

            // switch arg
            var person = "Pesho";

            // enable/disable fallthrough
            var fallThrough = true;

            new Switch<string>(person, fallThrough)
                .Case("Pesho", () => Console.WriteLine("Pesho is used for examples"))
                .Case(name => name == "Ivan", () => Console.WriteLine("Ivan is dude"))
                .Case(person.Length == 5, () => Console.WriteLine("I like names with 5 symbols"))
                .Default(() => Console.WriteLine("Thats enough ,fallThrough is over"));
        }
    }
}
