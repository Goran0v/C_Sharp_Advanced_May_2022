using System;
using System.Linq;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();
            string input;
            int counter = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    people.Enqueue(input);
                    counter++;
                }
                else
                {
                    for (int i = 0; i < counter; i++)
                    {
                        string car = people.Dequeue();
                        Console.WriteLine(car);
                    }
                    counter = 0;
                }
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
