using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < dimensions[0]; row++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            long[] sum = new long[dimensions[1]];
            for (int row = 0; row < dimensions[0]; row++)
            {
                for (int col = 0; col < dimensions[1]; col++)
                {
                    sum[col] += matrix[row, col];
                }
            }

            foreach (long item in sum)
            {
                Console.WriteLine(item);
            }
        }
    }
}
