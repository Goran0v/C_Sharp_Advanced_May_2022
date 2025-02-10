using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = arr[0];
            int cols = arr[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            long maxSum = long.MinValue;
            string strMatrix = string.Empty;
            for (int row = 1; row < rows - 1; row++)
            {
                for (int col = 1; col < cols - 1; col++)
                {
                    if (maxSum < (matrix[row, col] + matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] + matrix[row, col - 1] + matrix[row, col + 1] + matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1]))
                    {
                        maxSum = matrix[row, col] + matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] + matrix[row, col - 1] + matrix[row, col + 1] + matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        strMatrix = matrix[row - 1, col - 1] + " " + matrix[row - 1, col] + " " + matrix[row - 1, col + 1] + "\r\n" + matrix[row, col - 1] + " " + matrix[row, col] + " " + matrix[row, col + 1] + "\r\n" + matrix[row + 1, col - 1] + " " + matrix[row + 1, col] + " " + matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(strMatrix);
        }
    }
}
