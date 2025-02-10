using System;
using System.Collections.Generic;

namespace ComparingOpjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(' ');
                if (tokens[0] == "END")
                {
                    break;
                }

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                people.Add(new Person(name, age, town));
            }

            int index = int.Parse(Console.ReadLine());
            var equal = 0;
            var notEqual = 0;
            foreach (var person in people)
            {
                if (people[index - 1].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }
        }
    }
}
