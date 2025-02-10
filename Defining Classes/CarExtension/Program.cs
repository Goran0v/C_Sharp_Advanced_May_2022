using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Opel";
            car.Model = "Vectra";
            car.Year = 1996;
            car.FuelQuantity = 50;
            car.FuelConsumption = 0.07;

            Console.WriteLine(car.WhoAmI());
        }
    }
}
