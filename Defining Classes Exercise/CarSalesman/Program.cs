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
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string engineModel = line[0];
                int power = int.Parse(line[1]);
                Engine engine = new Engine(engineModel, power);
                if (line.Length == 3)
                {
                    string word = line[2];
                    if (char.IsLetter(word[0]))
                    {
                        engine.Efficiency = word;
                    }
                    else if (char.IsDigit(word[0]))
                    {
                        engine.Displacement = int.Parse(word);
                    }
                }
                else if (line.Length == 4)
                {
                    engine.Displacement = int.Parse(line[2]);
                    engine.Efficiency = line[3];
                }
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string carModel = input[0];
                string engineModel = input[1];
                Engine realEngine = engines.First(eng => eng.Model == engineModel);
                Car car = new Car(carModel, realEngine);
                if (input.Length == 3)
                {
                    string word = input[2];
                    if (char.IsLetter(word[0]))
                    {
                        car.Color = word;
                    }
                    else if (char.IsDigit(word[0]))
                    {
                        car.Weight = int.Parse(word);
                    }
                }
                else if (input.Length == 4)
                {
                    car.Weight = int.Parse(input[2]);
                    car.Color = input[3];
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($" {car.Engine.Model}:");
                Console.WriteLine($"  Power: {car.Engine.Power}");
                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"  Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"  Displacement: n/a");
                }

                if (car.Engine.Efficiency != "none")
                {
                    Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"  Efficiency: n/a");
                }

                if (car.Weight != 0)
                {
                    Console.WriteLine($" Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($" Weight: n/a");
                }

                if (car.Color != "none")
                {
                    Console.WriteLine($" Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($" Color: n/a");
                }
            }
        }
    }
}
