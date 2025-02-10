using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareWithMaxSum
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

            long maxSum = long.MinValue;
            string bestMatrix = string.Empty;
            for (int row = 0; row < dimensions[0] - 1; row++)
            {
                for (int col = 0; col < dimensions[1] - 1; col++)
                {
                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestMatrix = matrix[row, col] + " " + matrix[row, col + 1] + "\r\n" + matrix[row + 1, col] + " " + matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine(bestMatrix);
            Console.WriteLine(maxSum);
        }
    }
}
