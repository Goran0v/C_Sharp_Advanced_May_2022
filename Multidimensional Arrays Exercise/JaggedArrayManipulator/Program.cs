using System;
using System.Linq;
using System.Collections.Generic;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];

            for (int row = 0; row < n; row++)
            {
                jagged[row] = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                    }
                    for (int i = 0; i < jagged[row + 1].Length; i++)
                    {
                        jagged[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] /= 2;
                    }
                    for (int i = 0; i < jagged[row + 1].Length; i++)
                    {
                        jagged[row + 1][i] /= 2;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arr = command.Split(' ');
                string cmd = arr[0];
                if (cmd == "Add")
                {
                    int row = int.Parse(arr[1]);
                    int col = int.Parse(arr[2]);
                    int value = int.Parse(arr[3]);
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (cmd == "Subtract")
                {
                    int row = int.Parse(arr[1]);
                    int col = int.Parse(arr[2]);
                    int value = int.Parse(arr[3]);
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            foreach (double[] line in jagged)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
