using System;
using System.Linq;
using System.Collections.Generic;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int i = 0; i < commands; i++)
            {
                bool hasMoved = false;
                string move = Console.ReadLine();
                for (int k = 0; k < n; k++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (matrix[k, l] == 'f')
                        {
                            if (move == "up")
                            {
                                if (k - 1 < 0)
                                {
                                    matrix[k, l] = '-';
                                    if (matrix[n - 1, l] == 'F')
                                    {
                                        matrix[n - 1, l] = 'f';
                                        Console.WriteLine("Player won!");
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
                                    else
                                    {
                                        matrix[n - 1, l] = 'f';
                                    }
                                    hasMoved = true;
                                }
                                else if (matrix[k - 1, l] == 'B')
                                {
                                    if (k - 2 < 0)
                                    {
                                        matrix[k, l] = '-';
                                        if (matrix[n - 1, l] == 'F')
                                        {
                                            matrix[n - 1, l] = 'f';
                                            Console.WriteLine("Player won!");
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
                                        else
                                        {
                                            matrix[n - 1, l] = 'f';
                                        }
                                        hasMoved = true;
                                    }
                                    else
                                    {
                                        matrix[k, l] = '-';
                                        matrix[k - 2, l] = 'f';
                                        hasMoved = true;
                                    }
                                }
                                else if (matrix[k - 1, l] == '-')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k - 1, l] = 'f';
                                    hasMoved = true;
                                }
                                else if (matrix[k - 1, l] == 'F')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k - 1, l] = 'f';
                                    Console.WriteLine("Player won!");
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

                                if (hasMoved)
                                {
                                    break;
                                }
                            }
                            else if (move == "down")
                            {
                                if (k + 1 >= n)
                                {
                                    matrix[k, l] = '-';
                                    if (matrix[0, l] == 'F')
                                    {
                                        matrix[0, l] = 'f';
                                        Console.WriteLine("Player won!");
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
                                    else
                                    {
                                        matrix[0, l] = 'f';
                                    }
                                    hasMoved = true;
                                }
                                else if (matrix[k + 1, l] == 'B')
                                {
                                    if (k + 2 >= n)
                                    {
                                        matrix[k, l] = '-';
                                        if (matrix[0, l] == 'F')
                                        {
                                            matrix[0, l] = 'f';
                                            Console.WriteLine("Player won!");
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
                                        else
                                        {
                                            matrix[0, l] = 'f';
                                        }
                                        hasMoved = true;
                                    }
                                    else
                                    {
                                        matrix[k, l] = '-';
                                        matrix[k + 2, l] = 'f';
                                        hasMoved = true;
                                    }
                                }
                                else if (matrix[k + 1, l] == '-')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k + 1, l] = 'f';
                                    hasMoved = true;
                                }
                                else if (matrix[k + 1, l] == 'F')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k + 1, l] = 'f';
                                    Console.WriteLine("Player won!");
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

                                if (hasMoved)
                                {
                                    break;
                                }
                            }
                            else if (move == "left")
                            {
                                if (l - 1 < 0)
                                {
                                    matrix[k, l] = '-';
                                    if (matrix[k, n - 1] == 'F')
                                    {
                                        matrix[k, n - 1] = 'f';
                                        Console.WriteLine("Player won!");
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
                                    else
                                    {
                                        matrix[k, n - 1] = 'f';
                                    }
                                    hasMoved = true;
                                }
                                else if (matrix[k, l - 1] == 'B')
                                {
                                    if (l - 2 < 0)
                                    {
                                        matrix[k, l] = '-';
                                        if (matrix[k, n - 1] == 'F')
                                        {
                                            matrix[k, n - 1] = 'f';
                                            Console.WriteLine("Player won!");
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
                                        else
                                        {
                                            matrix[k, n - 1] = 'f';
                                        }
                                        hasMoved = true;
                                    }
                                    else
                                    {
                                        matrix[k, l] = '-';
                                        matrix[k, l - 2] = 'f';
                                        hasMoved = true;
                                    }
                                }
                                else if (matrix[k, l - 1] == '-')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k, l - 1] = 'f';
                                    hasMoved = true;
                                }
                                else if (matrix[k, l - 1] == 'F')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k, l - 1] = 'f';
                                    Console.WriteLine("Player won!");
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

                                if (hasMoved)
                                {
                                    break;
                                }
                            }
                            else if (move == "right")
                            {
                                if (l + 1 >= n)
                                {
                                    matrix[k, l] = '-';
                                    if (matrix[k, 0] == 'F')
                                    {
                                        matrix[k, 0] = 'f';
                                        Console.WriteLine("Player won!");
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
                                    else
                                    {
                                        matrix[k, 0] = 'f';
                                    }
                                    hasMoved = true;
                                }
                                else if (matrix[k, l + 1] == 'B')
                                {
                                    if (l + 2 >= n)
                                    {
                                        matrix[k, l] = '-';
                                        if (matrix[k, 0] == 'F')
                                        {
                                            matrix[k, 0] = 'f';
                                            Console.WriteLine("Player won!");
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
                                        else
                                        {
                                            matrix[k, 0] = 'f';
                                        }
                                        hasMoved = true;
                                    }
                                    else
                                    {
                                        matrix[k, l] = '-';
                                        matrix[k, l + 2] = 'f';
                                        hasMoved = true;
                                    }
                                }
                                else if (matrix[k, l + 1] == '-')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k, l + 1] = 'f';
                                    hasMoved = true;
                                }
                                else if (matrix[k, l + 1] == 'F')
                                {
                                    matrix[k, l] = '-';
                                    matrix[k, l + 1] = 'f';
                                    Console.WriteLine("Player won!");
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

                                if (hasMoved)
                                {
                                    break;
                                }
                            }
                        }
                    }

                    if (hasMoved)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Player lost!");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
