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
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(input[4], int.Parse(input[3]));
                double pressure1 = double.Parse(input[5]);
                double pressure2 = double.Parse(input[7]);
                double pressure3 = double.Parse(input[9]);
                double pressure4 = double.Parse(input[11]);
                int tireAge1 = int.Parse(input[6]);
                int tireAge2 = int.Parse(input[8]);
                int tireAge3 = int.Parse(input[10]);
                int tireAge4 = int.Parse(input[12]);
                Tires tire1 = new Tires(tireAge1, pressure1);
                Tires tire2 = new Tires(tireAge2, pressure2);
                Tires tire3 = new Tires(tireAge3, pressure3);
                Tires tire4 = new Tires(tireAge4, pressure4);
                Tires[] tires = new Tires[4];
                tires[0] = tire1;
                tires[1] = tire2;
                tires[2] = tire3;
                tires[3] = tire4;
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string word = Console.ReadLine();
            if (word == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "fragile" && (car.Tires[0].Pressure < 1 || car.Tires[1].Pressure < 1 || car.Tires[2].Pressure < 1 || car.Tires[3].Pressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (word == "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
