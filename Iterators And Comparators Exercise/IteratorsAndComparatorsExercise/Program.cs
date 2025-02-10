using System;
using System.Linq;

namespace IteratorsAndComparatorsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            ListyIterator<string> listy = null;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                if (action == "Create")
                {
                    listy = new ListyIterator<string>(tokens.Skip(1).ToArray());
                }
                else if (action == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (action == "Print")
                {
                    listy.Print();
                }
                else if (action == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
            }
        }
    }
}
