using System;
using System.Linq;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string fullName = arr[0] + " " + arr[1];
            string street = arr[2];
            string city = string.Empty;
            if (arr.Length == 4)
            {
                city = arr[3];
            }
            else
            {
                city = arr[3] + " " + arr[4];
            }
            Tuples<string, string, string> firstTuple = new Tuples<string, string, string>(fullName, street, city);

            string[] arr2 = Console.ReadLine().Split(' ');
            string name = arr2[0];
            int liters = int.Parse(arr2[1]);
            bool isDrunk = false;
            string word = arr2[2];
            if (word == "drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }
            Tuples<string, int, bool> secondTuple = new Tuples<string, int, bool>(name, liters, isDrunk);

            string[] arr3 = Console.ReadLine().Split(' ');
            string otherName = arr3[0];
            double balance = double.Parse(arr3[1]);
            string bankName = arr3[2];
            Tuples<string, double, string> thirdTuple = new Tuples<string, double, string>(otherName, balance, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}

