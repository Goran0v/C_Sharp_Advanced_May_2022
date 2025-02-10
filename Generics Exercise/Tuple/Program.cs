using System;
using System.Linq;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(' ').ToArray();
            var fullName = personInfo[0] + " " + personInfo[1];
            var city = personInfo[2];

            var nameAndBeer = Console.ReadLine().Split(' ');
            var name = nameAndBeer[0];
            int liters = int.Parse(nameAndBeer[1]);

            var numbersInput = Console.ReadLine().Split(' ');
            var intNum = int.Parse(numbersInput[0]);
            var doubleNum = double.Parse(numbersInput[1]);

            Tuples<string, string> firstTuple = new Tuples<string, string>(fullName, city);
            Tuples<string, int> secondTuple = new Tuples<string, int>(name, liters);
            Tuples<int, double> thirdTuple = new Tuples<int, double>(intNum, doubleNum);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
