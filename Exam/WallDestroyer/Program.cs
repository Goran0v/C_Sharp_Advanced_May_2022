using System;
using System.Linq;
using System.Collections.Generic;

namespace WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            int holes = 0;
            int rodsCount = 0;
            string input;
            bool alreadyCounted = false;
            while ((input = Console.ReadLine()) != "End")
            {
                bool hasMadeAMove = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == 'V')
                        {
                            if (input == "up")
                            {
                                if (i - 1 >= 0)
                                {
                                    if (matrix[i - 1, j] == '-')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i, j] = '*';
                                        matrix[i - 1, j] = 'V';
                                        hasMadeAMove = true;
                                        alreadyCounted = false;
                                    }
                                    else if (matrix[i - 1, j] == 'R')
                                    {
                                        rodsCount++;
                                        Console.WriteLine("Vanko hit a rod!");
                                        hasMadeAMove = true;
                                    }
                                    else if (matrix[i - 1, j] == 'C')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes += 2;
                                        }
                                        else
                                        {
                                            holes++;
                                        }
                                        alreadyCounted = false;
                                        matrix[i, j] = '*';
                                        matrix[i - 1, j] = 'E';
                                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
                                        for (int e = 0; e < n; e++)
                                        {
                                            for (int q = 0; q < n; q++)
                                            {
                                                Console.Write(matrix[e, q]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else if (matrix[i - 1, j] == '*')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i - 1, j] = 'V';
                                        matrix[i, j] = '*';
                                        Console.WriteLine($"The wall is already destroyed at position [{i - 1}, {j}]!");
                                        hasMadeAMove = true;
                                        alreadyCounted = true;
                                    }
                                }
                            }
                            else if (input == "down")
                            {
                                if (i + 1 < n)
                                {
                                    if (matrix[i + 1, j] == '-')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i, j] = '*';
                                        matrix[i + 1, j] = 'V';
                                        hasMadeAMove = true;
                                        alreadyCounted = false;
                                    }
                                    else if (matrix[i + 1, j] == 'R')
                                    {
                                        rodsCount++;
                                        Console.WriteLine("Vanko hit a rod!");
                                        hasMadeAMove = true;
                                    }
                                    else if (matrix[i + 1, j] == 'C')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes += 2;
                                        }
                                        else
                                        {
                                            holes++;
                                        }
                                        alreadyCounted = false;
                                        matrix[i, j] = '*';
                                        matrix[i + 1, j] = 'E';
                                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
                                        for (int e = 0; e < n; e++)
                                        {
                                            for (int q = 0; q < n; q++)
                                            {
                                                Console.Write(matrix[e, q]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else if (matrix[i + 1, j] == '*')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i + 1, j] = 'V';
                                        matrix[i, j] = '*';
                                        Console.WriteLine($"The wall is already destroyed at position [{i + 1}, {j}]!");
                                        hasMadeAMove = true;
                                        alreadyCounted = true;
                                    }
                                }
                            }
                            else if (input == "left")
                            {
                                if (j - 1 >= 0)
                                {
                                    if (matrix[i, j - 1] == '-')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i, j] = '*';
                                        matrix[i, j - 1] = 'V';
                                        hasMadeAMove = true;
                                        alreadyCounted = false;
                                    }
                                    else if (matrix[i, j - 1] == 'R')
                                    {
                                        rodsCount++;
                                        Console.WriteLine("Vanko hit a rod!");
                                        hasMadeAMove = true;
                                    }
                                    else if (matrix[i, j - 1] == 'C')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes += 2;
                                        }
                                        else
                                        {
                                            holes++;
                                        }
                                        alreadyCounted = false;
                                        matrix[i, j] = '*';
                                        matrix[i, j - 1] = 'E';
                                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
                                        for (int e = 0; e < n; e++)
                                        {
                                            for (int q = 0; q < n; q++)
                                            {
                                                Console.Write(matrix[e, q]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else if (matrix[i, j - 1] == '*')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i, j - 1] = 'V';
                                        matrix[i, j] = '*';
                                        Console.WriteLine($"The wall is already destroyed at position [{i}, {j - 1}]!");
                                        hasMadeAMove = true;
                                        alreadyCounted = true;
                                    }
                                }
                            }
                            else if (input == "right")
                            {
                                if (j + 1 < n)
                                {
                                    if (matrix[i, j + 1] == '-')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i, j] = '*';
                                        matrix[i, j + 1] = 'V';
                                        hasMadeAMove = true;
                                        alreadyCounted = false;
                                    }
                                    else if (matrix[i, j + 1] == 'R')
                                    {
                                        rodsCount++;
                                        Console.WriteLine("Vanko hit a rod!");
                                        hasMadeAMove = true;
                                    }
                                    else if (matrix[i, j + 1] == 'C')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes += 2;
                                        }
                                        else
                                        {
                                            holes++;
                                        }
                                        alreadyCounted = false;
                                        matrix[i, j] = '*';
                                        matrix[i, j + 1] = 'E';
                                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
                                        for (int e = 0; e < n; e++)
                                        {
                                            for (int q = 0; q < n; q++)
                                            {
                                                Console.Write(matrix[e, q]);
                                            }
                                            Console.WriteLine();
                                        }
                                        return;
                                    }
                                    else if (matrix[i, j + 1] == '*')
                                    {
                                        if (!alreadyCounted)
                                        {
                                            holes++;
                                        }
                                        matrix[i, j + 1] = 'V';
                                        matrix[i, j] = '*';
                                        Console.WriteLine($"The wall is already destroyed at position [{i}, {j + 1}]!");
                                        hasMadeAMove = true;
                                        alreadyCounted = true;
                                    }
                                }
                            }

                            if (hasMadeAMove)
                            {
                                break;
                            }
                        }
                    }

                    if (hasMadeAMove)
                    {
                        break;
                    }
                }
            }

            if (!alreadyCounted)
            {
                holes++;
            }
            Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rodsCount} rod(s).");
            for (int e = 0; e < n; e++)
            {
                for (int q = 0; q < n; q++)
                {
                    Console.Write(matrix[e, q]);
                }
                Console.WriteLine();
            }
        }
    }
}
