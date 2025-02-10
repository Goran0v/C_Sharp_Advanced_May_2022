using System;
using System.Linq;
using System.Collections.Generic;

namespace TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            while (true)
            {
                string[] arr = Console.ReadLine().Split(' ').ToArray();
                string move = arr[0];
                int row = int.Parse(arr[1]);
                int col = int.Parse(arr[2]);
                matrix[row, col] = 'O';

                if (move == "up")
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i, j] == 'A')
                            {
                                if (i - 1 < 0)
                                {
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i - 1, j] = 'X';
                                        Console.WriteLine($"The army was defeated at {i - 1};{j}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                                else if (matrix[i - 1, j] == 'O')
                                {
                                    armor -= 3;
                                    matrix[i, j] = '-';
                                    if (armor <= 0)
                                    {
                                        matrix[i - 1, j] = 'X';
                                        Console.WriteLine($"The army was defeated at {i - 1};{j}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else
                                    {
                                        matrix[i - 1, j] = 'A';
                                    }
                                }
                                else if (matrix[i - 1, j] == 'M')
                                {
                                    armor--;
                                    matrix[i, j] = '-';
                                    matrix[i - 1, j] = '-';
                                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                                    for (int k = 0; k < n; k++)
                                    {
                                        for (int l = 0; l < n; l++)
                                        {
                                            Console.Write(matrix[k, l]);
                                        }
                                        Console.WriteLine();
                                    }
                                    return;
                                }
                                else
                                {
                                    matrix[i, j] = '-';
                                    matrix[i - 1, j] = 'A';
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i - 1, j] = 'X';
                                        Console.WriteLine($"The army was defeated at {i - 1};{j}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (move == "down")
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i, j] == 'A')
                            {
                                if (i + 1 >= n)
                                {
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i + 1, j] = 'X';
                                        Console.WriteLine($"The army was defeated at {i + 1};{j}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                                else if (matrix[i + 1, j] == 'O')
                                {
                                    armor -= 3;
                                    matrix[i, j] = '-';
                                    if (armor <= 0)
                                    {
                                        matrix[i + 1, j] = 'X';
                                        Console.WriteLine($"The army was defeated at {i + 1};{j}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else
                                    {
                                        matrix[i + 1, j] = 'A';
                                    }
                                }
                                else if (matrix[i + 1, j] == 'M')
                                {
                                    armor--;
                                    matrix[i, j] = '-';
                                    matrix[i + 1, j] = '-';
                                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                                    for (int k = 0; k < n; k++)
                                    {
                                        for (int l = 0; l < n; l++)
                                        {
                                            Console.Write(matrix[k, l]);
                                        }
                                        Console.WriteLine();
                                    }
                                    return;
                                }
                                else
                                {
                                    matrix[i, j] = '-';
                                    matrix[i + 1, j] = 'A';
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i + 1, j] = 'X';
                                        Console.WriteLine($"The army was defeated at {i + 1};{j}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (move == "left")
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i, j] == 'A')
                            {
                                if (j - 1 < 0)
                                {
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i, j - 1] = 'X';
                                        Console.WriteLine($"The army was defeated at {i};{j - 1}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                                else if (matrix[i, j - 1] == 'O')
                                {
                                    armor -= 3;
                                    matrix[i, j - 1] = '-';
                                    if (armor <= 0)
                                    {
                                        matrix[i, j - 1] = 'X';
                                        Console.WriteLine($"The army was defeated at {i};{j - 1}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else
                                    {
                                        matrix[i, j - 1] = 'A';
                                    }
                                }
                                else if (matrix[i, j - 1] == 'M')
                                {
                                    armor--;
                                    matrix[i, j] = '-';
                                    matrix[i, j - 1] = '-';
                                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                                    for (int k = 0; k < n; k++)
                                    {
                                        for (int l = 0; l < n; l++)
                                        {
                                            Console.Write(matrix[k, l]);
                                        }
                                        Console.WriteLine();
                                    }
                                    return;
                                }
                                else
                                {
                                    matrix[i, j] = '-';
                                    matrix[i, j - 1] = 'A';
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i, j - 1] = 'X';
                                        Console.WriteLine($"The army was defeated at {i};{j - 1}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (move == "right")
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i, j] == 'A')
                            {
                                if (j + 1 >= n)
                                {
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i, j + 1] = 'X';
                                        Console.WriteLine($"The army was defeated at {i};{j + 1}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                                else if (matrix[i, j + 1] == 'O')
                                {
                                    armor -= 3;
                                    matrix[i, j + 1] = '-';
                                    if (armor <= 0)
                                    {
                                        matrix[i, j + 1] = 'X';
                                        Console.WriteLine($"The army was defeated at {i};{j + 1}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else
                                    {
                                        matrix[i, j + 1] = 'A';
                                    }
                                }
                                else if (matrix[i, j + 1] == 'M')
                                {
                                    armor--;
                                    matrix[i, j] = '-';
                                    matrix[i, j + 1] = '-';
                                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                                    for (int k = 0; k < n; k++)
                                    {
                                        for (int l = 0; l < n; l++)
                                        {
                                            Console.Write(matrix[k, l]);
                                        }
                                        Console.WriteLine();
                                    }
                                    return;
                                }
                                else
                                {
                                    matrix[i, j] = '-';
                                    matrix[i, j + 1] = 'A';
                                    armor--;
                                    if (armor <= 0)
                                    {
                                        matrix[i, j + 1] = 'X';
                                        Console.WriteLine($"The army was defeated at {i};{j + 1}.");
                                        for (int k = 0; k < n; k++)
                                        {
                                            for (int l = 0; l < n; l++)
                                            {
                                                Console.Write(matrix[k, l]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
