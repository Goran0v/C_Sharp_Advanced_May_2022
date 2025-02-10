using System;
using System.Linq;
using System.Collections.Generic;

namespace MultiDimensionalArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int primarySum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        primarySum += matrix[row, col];
                    }
                }
            }

            int secondarySum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if ((row + col) == n - 1)
                    {
                        secondarySum += matrix[row, col];
                    }
                }
            }

            int absolutSum = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(absolutSum);
        }
    }
}
