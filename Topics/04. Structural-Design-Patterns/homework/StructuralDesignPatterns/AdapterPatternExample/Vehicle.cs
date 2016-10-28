namespace AdapterPatternExample
{
    using System;

    /// <summary>
    /// The 'ConcreteAdapter' class
    /// </summary>
    internal class Vehicle : IVehicle
    {
        private readonly string name;
        private readonly int numberOfWheels;
        private readonly string requiredDrivingLicense;
        
        public Vehicle(string name)
        {
            this.name = name;
            var parts = new PartsSetter();

            this.numberOfWheels = parts.GetWheelsCount(this.name);
            this.requiredDrivingLicense = parts.GetRequiredLicense(this.name);

        }

        public void Display()
        {
            Console.WriteLine("Vehicle: {0} ------ ", this.name);
            Console.WriteLine(" Number of wheels: {0}", this.numberOfWheels);
            Console.WriteLine(" Required driving license category: {0}", this.requiredDrivingLicense);
            Console.WriteLine();
        }
    }
}
