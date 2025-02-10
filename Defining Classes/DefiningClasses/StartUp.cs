using System;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Subaru";
            car.Model = "Impreza";
            car.Year = 1999;
            Console.WriteLine($"Make: {car.Make}; Model: {car.Model}; Year: {car.Year}");
        }
    }
}
