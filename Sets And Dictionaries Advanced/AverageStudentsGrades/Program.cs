using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ').ToArray();
                string name = arr[0];
                decimal grade = decimal.Parse(arr[1]);
                if (!students.ContainsKey(name))
                {
                    List<decimal> nums = new List<decimal>();
                    nums.Add(grade);
                    students.Add(name, nums);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var val in student.Value)
                {
                    Console.Write($"{val:f2} ");
                }
                Console.WriteLine($"(avg: { student.Value.Average():f2})");
            }
        }
    }
}
