using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
            };

            Engine engine = new Engine(265, 1994);

            var car = new Car("Subaru", "Impreza", 1998, 45, 0.12, engine, tires);
        }
    }
}
