using System;
using System.Linq;
using System.Collections.Generic;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] text = command.Split(' ');
                string function = text[0];
                if (function == "Add")
                {
                    int row = int.Parse(text[1]);
                    int col = int.Parse(text[2]);
                    int value = int.Parse(text[3]);
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (function == "Subtract")
                {
                    int row = int.Parse(text[1]);
                    int col = int.Parse(text[2]);
                    int value = int.Parse(text[3]);
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
