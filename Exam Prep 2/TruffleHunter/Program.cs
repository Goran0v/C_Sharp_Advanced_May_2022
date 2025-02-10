using System;
using System.Linq;
using System.Collections.Generic;

namespace TruffleHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            Dictionary<char, int> truffels = new Dictionary<char, int>
            {
                {'B', 0},
                {'S', 0},
                {'W', 0}
            };

            for (int i = 0; i < n; i++)
            {
                char[] line = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int eatenTruffels = 0;
            string input;
            while ((input = Console.ReadLine()) != "Stop the hunt")
            {
                string[] arr = input.Split(' ').ToArray();
                string action = arr[0];
                if (action == "Collect")
                {
                    int row = int.Parse(arr[1]);
                    int col = int.Parse(arr[2]);
                    if (row >= 0 && row < n && col >=0 && col < n)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            truffels['B']++;
                            matrix[row, col] = '-';
                        }
                        else if (matrix[row, col] == 'S')
                        {
                            truffels['S']++;
                            matrix[row, col] = '-';
                        }
                        else if (matrix[row, col] == 'W')
                        {
                            truffels['W']++;
                            matrix[row, col] = '-';
                        }
                    }
                }
                else if (action == "Wild_Boar")
                {
                    int row = int.Parse(arr[1]);
                    int col = int.Parse(arr[2]);
                    string direction = arr[3];

                    if (direction == "up")
                    {
                        for (int i = row; i >= 0; i -= 2)
                        {
                            if (matrix[i, col] == 'B' || matrix[i, col] == 'S' || matrix[i, col] == 'W')
                            {
                                eatenTruffels++;
                            }
                            matrix[i, col] = '-';
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = row; i < n; i += 2)
                        {
                            if (matrix[i, col] == 'B' || matrix[i, col] == 'S' || matrix[i, col] == 'W')
                            {
                                eatenTruffels++;
                            }
                            matrix[i, col] = '-';
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int j = col; j >= 0; j -= 2)
                        {
                            if (matrix[row, j] == 'B' || matrix[row, j] == 'S' || matrix[row, j] == 'W')
                            {
                                eatenTruffels++;
                            }
                            matrix[row, j] = '-';
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int j = col; j < n; j += 2)
                        {
                            if (matrix[row, j] == 'B' || matrix[row, j] == 'S' || matrix[row, j] == 'W')
                            {
                                eatenTruffels++;
                            }
                            matrix[row, j] = '-';
                        }
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {truffels['B']} black, {truffels['S']} summer, and {truffels['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatenTruffels} truffles.");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
