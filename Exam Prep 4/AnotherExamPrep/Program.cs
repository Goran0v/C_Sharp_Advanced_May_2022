using System;
using System.Linq;
using System.Collections.Generic;

namespace AnotherExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] jaggedArr = new char[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArr[i] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            }

            int collectedTokens = 0;
            int opponentTokens = 0;
            string input;
            while ((input = Console.ReadLine()) != "Gong")
            {
                string[] arr = input.Split(' ').ToArray();
                string action = arr[0];
                if (action == "Find")
                {
                    int row = int.Parse(arr[1]);
                    int col = int.Parse(arr[2]);
                    if (row >= 0 && col >= 0 && row < jaggedArr.Length && col < jaggedArr[row].Length)
                    {
                        if (jaggedArr[row][col] == 'T')
                        {
                            collectedTokens++;
                            jaggedArr[row][col] = '-';
                        }
                    }
                }
                else if (action == "Opponent")
                {
                    int row = int.Parse(arr[1]);
                    int col = int.Parse(arr[2]);
                    string move = arr[3];
                    if (row >= 0 && col >= 0 && row < jaggedArr.Length && col < jaggedArr[row].Length)
                    {
                        if (jaggedArr[row][col] == 'T')
                        {
                            opponentTokens++;
                            jaggedArr[row][col] = '-';
                        }

                        if (move == "up")
                        {
                            if (row - 3 < 0)
                            {
                                for (int i = row; i >= 0; i--)
                                {
                                    if (jaggedArr[i][col] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[i][col] = '-';
                                    }
                                }
                            }
                            else
                            {
                                for (int i = row; i >= row - 3; i--)
                                {
                                    if (jaggedArr[i][col] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[i][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (move == "down")
                        {
                            if (row + 3 >= jaggedArr.Length)
                            {
                                for (int i = row; i < jaggedArr.Length; i++)
                                {
                                    if (jaggedArr[i][col] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[i][col] = '-';
                                    }
                                }
                            }
                            else
                            {
                                for (int i = row; i <= row + 3; i++)
                                {
                                    if (jaggedArr[i][col] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[i][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (move == "right")
                        {
                            if (col + 3 >= jaggedArr[row].Length)
                            {
                                for (int i = col; i < jaggedArr[row].Length; i++)
                                {
                                    if (jaggedArr[row][i] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[row][i] = '-';
                                    }
                                }
                            }
                            else
                            {
                                for (int i = col; i <= col + 3; i++)
                                {
                                    if (jaggedArr[row][i] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[row][i] = '-';
                                    }
                                }
                            }
                        }
                        else if (move == "left")
                        {
                            if (col - 3 < 0)
                            {
                                for (int i = col; i >= 0; i--)
                                {
                                    if (jaggedArr[row][i] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[row][i] = '-';
                                    }
                                }
                            }
                            else
                            {
                                for (int i = col; i >= col - 3; i--)
                                {
                                    if (jaggedArr[row][i] == 'T')
                                    {
                                        opponentTokens++;
                                        jaggedArr[row][i] = '-';
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j].ToString() + ' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
    }
}
