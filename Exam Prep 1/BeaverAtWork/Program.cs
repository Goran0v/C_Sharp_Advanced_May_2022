using System;
using System.Linq;
using System.Collections.Generic;

namespace BeaverAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> branches = new List<char>();
            List<char> beaversBranches = new List<char>();
            Dictionary<char, int[]> beaverBranches = new Dictionary<char, int[]>();
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] line = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                    if (char.IsLower(matrix[i, j]))
                    {
                        branches.Add(matrix[i, j]);
                    }
                }
            }

            int startingCount = branches.Count;

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                int currentFish = 0;
                bool isDone = false;
                if (beaversBranches.Count == branches.Count)
                {
                    break;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (char.IsLower(matrix[i, j]))
                        {
                            currentFish++;
                        }
                    }
                }

                if (currentFish == 0)
                {
                    break;
                }

                if (input == "up")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (isDone)
                        {
                            break;
                        }
                        for (int j = 0; j < n; j++)
                        {
                            if (isDone)
                            {
                                break;
                            }
                            if (matrix[i, j] == 'B')
                            {
                                if (i - 1 >= 0)
                                {
                                    if (matrix[i - 1, j] == '-')
                                    {
                                        matrix[i - 1, j] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                    }
                                    else if (char.IsLower(matrix[i - 1, j]))
                                    {
                                        beaversBranches.Add(matrix[i - 1, j]);
                                        beaverBranches.Add(matrix[i - 1, j], new int[2]);
                                        beaverBranches[matrix[i - 1, j]][0] = i - 1;
                                        beaverBranches[matrix[i - 1, j]][1] = j;
                                        matrix[i - 1, j] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                        
                                    }
                                    else if (matrix[i - 1, j] == 'F')
                                    {
                                        if (i - 1 != 0)
                                        {
                                            matrix[i - 1, j] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = i - 1; k > 0; k--)
                                            {
                                                matrix[k - 1, j] = 'B';
                                                matrix[k, j] = '-';
                                            }
                                            isDone = true;
                                        }
                                        else
                                        {
                                            matrix[0, j] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = 0; k < n - 1; k++)
                                            {
                                                matrix[k + 1, j] = 'B';
                                                matrix[k, j] = '-';
                                            }
                                            isDone = true;
                                        }
                                    }
                                }
                                else
                                {
                                    //if (beaversBranches.Count > 0)
                                    //{
                                    //    int I = beaverBranches[matrix[i - 1, j]][0];
                                    //    int J = beaverBranches[matrix[i - 1, j]][1];
                                    //    if (matrix[I, J] != 'B')
                                    //    {

                                    //        matrix[I, J] = beaverBranches[matrix[I, J]];
                                    //    }

                                    //}
                                    
                                    if (beaversBranches.Count > 0)
                                    {
                                        beaversBranches.RemoveAt(beaversBranches.Count - 1);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (input == "down")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (isDone)
                        {
                            break;
                        }
                        for (int j = 0; j < n; j++)
                        {
                            if (isDone)
                            {
                                break;
                            }
                            if (matrix[i, j] == 'B')
                            {
                                if (i + 1 < n)
                                {
                                    if (matrix[i + 1, j] == '-')
                                    {
                                        matrix[i + 1, j] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                    }
                                    else if (char.IsLower(matrix[i + 1, j]))
                                    {
                                        beaversBranches.Add(matrix[i + 1, j]);
                                        beaverBranches.Add(matrix[i + 1, j], new int[2]);
                                        beaverBranches[matrix[i + 1, j]][0] = i + 1;
                                        beaverBranches[matrix[i + 1, j]][1] = j;
                                        matrix[i + 1, j] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                        
                                    }
                                    else if (matrix[i + 1, j] == 'F')
                                    {
                                        if (i + 1 != n - 1)
                                        {
                                            matrix[i + 1, j] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = i + 1; k < n - 1; k++)
                                            {
                                                matrix[k + 1, j] = 'B';
                                                matrix[k, j] = '-';
                                            }
                                            isDone = true;
                                        }
                                        else
                                        {
                                            matrix[0, j] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = n - 1; k > 0; k--)
                                            {
                                                matrix[k - 1, j] = 'B';
                                                matrix[k, j] = '-';
                                            }
                                            isDone = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (beaversBranches.Count > 0)
                                    {
                                        beaversBranches.RemoveAt(beaversBranches.Count - 1);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (input == "left")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (isDone)
                        {
                            break;
                        }
                        for (int j = 0; j < n; j++)
                        {
                            if (isDone)
                            {
                                break;
                            }
                            if (matrix[i, j] == 'B')
                            {
                                if (j - 1 >= 0)
                                {
                                    if (matrix[i, j - 1] == '-')
                                    {
                                        matrix[i, j - 1] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                    }
                                    else if (char.IsLower(matrix[i, j - 1]))
                                    {
                                        beaversBranches.Add(matrix[i, j - 1]);
                                        beaverBranches.Add(matrix[i, j - 1], new int[2]);
                                        beaverBranches[matrix[i, j - 1]][0] = i;
                                        beaverBranches[matrix[i, j - 1]][1] = j - 1;
                                        matrix[i, j - 1] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                        
                                    }
                                    else if (matrix[i, j - 1] == 'F')
                                    {
                                        if (j - 1 != 0)
                                        {
                                            matrix[i, j - 1] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = j - 1; k > 0; k--)
                                            {
                                                matrix[i, k - 1] = 'B';
                                                matrix[i, k] = '-';
                                            }
                                            isDone = true;
                                        }
                                        else
                                        {
                                            matrix[i, 0] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = 0; k < n - 1; k++)
                                            {
                                                matrix[i, k + 1] = 'B';
                                                matrix[i, k] = '-';
                                            }
                                            isDone = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (beaversBranches.Count > 0)
                                    {
                                        beaversBranches.RemoveAt(beaversBranches.Count - 1);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (input == "right")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (isDone)
                        {
                            break;
                        }
                        for (int j = 0; j < n; j++)
                        {
                            if (isDone)
                            {
                                break;
                            }
                            if (matrix[i, j] == 'B')
                            {
                                if (j + 1 < n)
                                {
                                    if (matrix[i, j + 1] == '-')
                                    {
                                        matrix[i, j + 1] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                    }
                                    else if (char.IsLower(matrix[i, j + 1]))
                                    {
                                        beaversBranches.Add(matrix[i, j + 1]);
                                        beaverBranches.Add(matrix[i, j + 1], new int[2]);
                                        beaverBranches[matrix[i, j + 1]][0] = i;
                                        beaverBranches[matrix[i, j + 1]][1] = j + 1;
                                        matrix[i, j + 1] = 'B';
                                        matrix[i, j] = '-';
                                        isDone = true;
                                        
                                    }
                                    else if (matrix[i, j + 1] == 'F')
                                    {
                                        if (j + 1 != n - 1)
                                        {
                                            matrix[i, j + 1] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = j + 1; k < n - 1; k++)
                                            {
                                                matrix[i, k + 1] = 'B';
                                                matrix[i, k] = '-';
                                            }
                                            isDone = true;
                                        }
                                        else
                                        {
                                            matrix[i, j + 1] = 'B';
                                            matrix[i, j] = '-';
                                            for (int k = n - 1; k > 0; k--)
                                            {
                                                matrix[i, k - 1] = 'B';
                                                matrix[i, k] = '-';
                                            }
                                            isDone = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (beaversBranches.Count > 0)
                                    {
                                        beaversBranches.RemoveAt(beaversBranches.Count - 1);
                                    }
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (char.IsLower(matrix[i, j]))
                    {
                        counter++;
                    }
                }
            }

            if (counter > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {counter} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {beaversBranches.Count} wood branches: {string.Join(", ", beaversBranches)}.");
            }

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