using System;
using System.Linq;
using System.Collections.Generic;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < dimensions[0]; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            long sum = 0;
            for (int row = 0; row < dimensions[0]; row++)
            {
                for (int col = 0; col < dimensions[1]; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(dimensions[0]);
            Console.WriteLine(dimensions[1]);
            Console.WriteLine(sum);
        }
    }
}
