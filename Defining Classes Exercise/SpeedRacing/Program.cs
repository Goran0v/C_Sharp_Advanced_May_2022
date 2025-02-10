using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsump = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsump);
                cars.Add(car);
            }

            string command; 
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmd = command.Split(' ').ToArray();
                string action = cmd[0];
                if (action == "Drive")
                {
                    string model = cmd[1];
                    double km = double.Parse(cmd[2]);
                    Car carToDrive = cars.First(car => car.Model == model);
                    carToDrive.Drive(km);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
