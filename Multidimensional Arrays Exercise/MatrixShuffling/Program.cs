using System;
using System.Linq;
using System.Collections.Generic;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = arr[0];
            int cols = arr[1];

            string[,] matrix = new string[rows, cols];

            for(int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    if (line[col].ToString() != " ")
                    {
                        matrix[row, col] = line[col].ToString();
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split(' ');
                if (arguments[0] == "swap" && arguments.Length == 5)
                {
                    int row1 = int.Parse(arguments[1]);
                    int col1 = int.Parse(arguments[2]);
                    int row2 = int.Parse(arguments[3]);
                    int col2 = int.Parse(arguments[4]);

                    if (row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols && row2 >= 0 && row2 < rows && col2 >= 0 && col2 < cols)
                    {
                        string firstValue = matrix[row1, col1];
                        string secondValue = matrix[row2, col2];
                        matrix[row2, col2] = firstValue;
                        matrix[row1, col1] = secondValue;
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}