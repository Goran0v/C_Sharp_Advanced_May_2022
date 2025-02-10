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
            Family family = new Family();
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
                people.Add(person);
            }

            List<Person> ordered = family.OrderMembers(people);
            ordered.Sort((x, y) => string.Compare(x.Name, y.Name));
            foreach (var order in ordered)
            {
                Console.WriteLine($"{order.Name} - {order.Age}");
            }
        }
    }
}
