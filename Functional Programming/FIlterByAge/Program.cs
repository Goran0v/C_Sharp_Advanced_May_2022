using System;
using System.Linq;
using System.Collections.Generic;

namespace FIlterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            Func<string, int> parser = x => int.Parse(x);
            int n = parser(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = parser(input[1]);
                people.Add(name, age);
            }

            string condition = Console.ReadLine();
            int ageCondition = parser(Console.ReadLine());
            string writeCondition = Console.ReadLine();

            if (condition == "older")
            {
                if (writeCondition == "name")
                {
                    foreach (var human in people)
                    {
                        if (human.Value >= ageCondition)
                        {
                            Console.WriteLine(human.Key);
                        }
                    }
                }
                else if (writeCondition == "age")
                {
                    foreach (var human in people)
                    {
                        if (human.Value >= ageCondition)
                        {
                            Console.WriteLine(human.Value);
                        }
                    }
                }
                else if (writeCondition == "name age")
                {
                    foreach (var human in people)
                    {
                        if (human.Value >= ageCondition)
                        {
                            Console.WriteLine($"{human.Key} - {human.Value}");
                        }
                    }
                }
            }
            else if (condition == "younger")
            {
                if (writeCondition == "name")
                {
                    foreach (var human in people)
                    {
                        if (human.Value < ageCondition)
                        {
                            Console.WriteLine(human.Key);
                        }
                    }
                }
                else if (writeCondition == "age")
                {
                    foreach (var human in people)
                    {
                        if (human.Value < ageCondition)
                        {
                            Console.WriteLine(human.Value);
                        }
                    }
                }
                else if (writeCondition == "name age")
                {
                    foreach (var human in people)
                    {
                        if (human.Value < ageCondition)
                        {
                            Console.WriteLine($"{human.Key} - {human.Value}");
                        }
                    }
                }
            }
        }
    }
}
