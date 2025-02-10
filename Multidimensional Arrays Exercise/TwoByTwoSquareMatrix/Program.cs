using System;
using System.Linq;
using System.Collections.Generic;

namespace TwoByTwoSquareMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = arr[0];
            int cols = arr[1];

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(line[col]);
                }
            }

            int counter = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
