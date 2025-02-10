using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            List<Tire[]> allTires = new List<Tire[]>();
            Dictionary<Tire[], double> tirePressure = new Dictionary<Tire[], double>();
            while ((input = Console.ReadLine()) != "No more tires")
            {
                Tire[] tires = new Tire[4];
                double[] tiress = input.Split(' ').Select(double.Parse).ToArray();
                double sum = 0;
                int counter = 0;
                for (int i = 0; i < tiress.Length - 1; i += 2)
                {
                    sum += tiress[i + 1];
                    Tire tire = new Tire((int)tiress[i], tiress[i + 1]);
                    tires[counter] = tire;
                    if (counter < 4)
                    {
                        counter++;
                    }
                }
                allTires.Add(tires);
                tirePressure.Add(tires, sum);
            }

            string command;
            while ((command = Console.ReadLine()) != "Engines done")
            {
                double[] engineSpecs = command.Split(' ').Select(double.Parse).ToArray();
                int hp = (int)engineSpecs[0];
                double cubics = engineSpecs[1];
                Engine engine = new Engine(hp, cubics);
                engines.Add(engine);
            }

            string cmd;
            int count = 0;
            while ((cmd = Console.ReadLine()) != "Show special")
            {
                string[] carSpecs = cmd.Split(' ').ToArray();
                string make = carSpecs[0];
                string model = carSpecs[1];
                int year = int.Parse(carSpecs[2]);
                double fuelQuantity = double.Parse(carSpecs[3]);
                double fuelConsumption = double.Parse(carSpecs[4]);
                int engineIndex = int.Parse(carSpecs[5]);
                int tiresIndex = int.Parse(carSpecs[6]);
                Car car = new Car();
                car.Make = make;
                car.Model = model;
                car.Year = year;
                car.FuelQuantity = fuelQuantity;
                car.FuelConsumption = fuelConsumption;
                car.EngineIndex = engineIndex;
                car.TiresIndex = tiresIndex;
                car.Engine = engines[count];
                car.Tires = allTires[count];
                car.SumOfTirePressure = tirePressure[allTires[count]];
                count++;
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && car.SumOfTirePressure > 9 && car.SumOfTirePressure < 10)
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
                
            }
        }
    }
}