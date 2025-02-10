using System;
using System.Linq;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songs = new Queue<string>(arr);
            while (songs.Count != 0)
            {
                string commands = Console.ReadLine();
                string command = commands.Substring(0, 4);
                if (command == "Play")
                {
                    if (songs.Count > 0)
                    {
                        songs.Dequeue();
                    }
                }
                else if (command == "Add ")
                {
                    string song = commands.Substring(4);
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    if (songs.Count > 0)
                    {
                        Console.WriteLine($"{string.Join(", ", songs)}");
                    }
                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}
