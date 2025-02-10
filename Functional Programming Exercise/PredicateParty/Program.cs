using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            string input;
            
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] arr = input.Split(' ');
                string command = arr[0];
                if (command == "Double")
                {
                    string cmd = arr[1];
                    if (cmd == "StartsWith")
                    {
                        string letters = arr[2];
                        Predicate<string> doesStartWith = name => name.StartsWith(letters);
                        List<string> newNames = new List<string>();
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (doesStartWith(names[i]))
                            {
                                newNames.Add(names[i]);
                            }
                        }

                        foreach (var name in newNames)
                        {
                            names.Insert(names.IndexOf(name) + 1, name);
                        }
                    }
                    else if (cmd == "EndsWith")
                    {
                        string letters = arr[2];
                        Predicate<string> doesEndWith = name => name.EndsWith(letters);
                        List<string> newNames = new List<string>();
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (doesEndWith(names[i]))
                            {
                                newNames.Add(names[i]);
                            }
                        }

                        foreach (var name in newNames)
                        {
                            names.Insert(names.IndexOf(name) + 1, name);
                        }
                    }
                    else if (cmd == "Length")
                    {
                        int count = int.Parse(arr[2]);
                        Predicate<string> isLongEnough = name => name.Length == count;
                        List<string> newNames = new List<string>();
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (isLongEnough(names[i]))
                            {
                                newNames.Add(names[i]);
                            }
                        }

                        foreach (var name in newNames)
                        {
                            names.Insert(names.IndexOf(name) + 1, name);
                        }
                    }
                }
                else if (command == "Remove")
                {
                    string cmd = arr[1];
                    if (cmd == "StartsWith")
                    {
                        string letters = arr[2];
                        Predicate<string> doesStartWith = name => name.StartsWith(letters);
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (doesStartWith(names[i]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                    }
                    else if (cmd == "EndsWith")
                    {
                        string letters = arr[2];
                        Predicate<string> doesEndWith = name => name.EndsWith(letters);
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (doesEndWith(names[i]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                    }
                    else if (cmd == "Length")
                    {
                        int count = int.Parse(arr[2]);
                        Predicate<string> isLongEnough = name => name.Length == count;
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (isLongEnough(names[i]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                    }
                }
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
