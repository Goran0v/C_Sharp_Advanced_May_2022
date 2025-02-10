using System;
using System.Linq;
using System.Collections.Generic;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            List<string> unfilteredNames = names.ToList();
            string input;
            
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] arr = input.Split(';');
                string command = arr[0];
                if (command == "Remove filter")
                {
                    string cmd = arr[1];
                    if (cmd == "Starts with")
                    {
                        string letters = arr[2];
                        Predicate<string> doesStartWith = name => name.StartsWith(letters);
                        List<string> newNames = new List<string>();
                        for (int i = 0; i < unfilteredNames.Count; i++)
                        {
                            if (doesStartWith(unfilteredNames[i]))
                            {
                                newNames.Add(unfilteredNames[i]);
                            }
                        }

                        foreach (var name in newNames)
                        {
                            names.Insert(unfilteredNames.IndexOf(name), name);
                        }
                    }
                    else if (cmd == "Ends with")
                    {
                        string letters = arr[2];
                        Predicate<string> doesEndsWith = name => name.EndsWith(letters);
                        List<string> newNames = new List<string>();
                        for (int i = 0; i < unfilteredNames.Count; i++)
                        {
                            if (doesEndsWith(unfilteredNames[i]))
                            {
                                newNames.Add(unfilteredNames[i]);
                            }
                        }

                        foreach (var name in newNames)
                        {
                            names.Insert(unfilteredNames.IndexOf(name), name);
                        }
                    }
                    else if (cmd == "Length")
                    {
                        int count = int.Parse(arr[2]);
                        Predicate<string> isLongEnough = name => name.Length == count;
                        List<string> newNames = new List<string>();
                        for (int i = 0; i < unfilteredNames.Count; i++)
                        {
                            if (isLongEnough(unfilteredNames[i]))
                            {
                                newNames.Add(unfilteredNames[i]);
                            }
                        }

                        foreach (var name in newNames)
                        {
                            names.Insert(unfilteredNames.IndexOf(name), name);
                        }
                    }
                    else if (cmd == "Contains")
                    {
                        string thingToContain = arr[2];
                        Predicate<List<string>> doesContain = list => list.Contains(thingToContain);
                        if (doesContain(unfilteredNames))
                        {
                            names.Insert(unfilteredNames.IndexOf(thingToContain), thingToContain);
                        }
                    }
                }
                else if (command == "Add filter")
                {
                    string cmd = arr[1];
                    if (cmd == "Starts with")
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
                    else if (cmd == "Ends with")
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
                    else if (cmd == "Contains")
                    {
                        string thingToContain = arr[2];
                        Predicate<List<string>> doesContain = list => list.Contains(thingToContain);
                        if (doesContain(names))
                        {
                            names.Remove(thingToContain);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
