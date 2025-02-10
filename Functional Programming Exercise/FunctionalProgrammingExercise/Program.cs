using System;
using System.Linq;
using System.Collections.Generic;

namespace FunctionalProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            Action<string> print = name => Console.WriteLine(name);
            for (int i = 0; i < names.Length; i++)
            {
                print(names[i]);
            }
        }
    }
}
