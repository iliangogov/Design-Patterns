namespace AdapterPatternExample
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IVehicle car = new Vehicle("Car");
            car.Display();

            IVehicle motorcycle = new Vehicle("Motorcycle");
            motorcycle.Display();

            IVehicle truck = new Vehicle("Truck");
            truck.Display();
        }
    }
}
