using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();
            nums.Reverse();
            Stack<string> chars = new Stack<string>();
            foreach (var ch in nums)
            {
                chars.Push(ch);
            }

            int sum = 0;
            bool flag = false;
            while (chars.Count > 0)
            {
                if (flag == false)
                {
                    int firstNum = int.Parse(chars.Pop());
                    string @operator = chars.Pop();
                    int secondNum = int.Parse(chars.Pop());
                    if (@operator == "+")
                    {
                        sum += firstNum + secondNum;
                        flag = true;
                    }
                    else if (@operator == "-")
                    {
                        sum += firstNum - secondNum;
                        flag = true;
                    }
                    else if (@operator == "*")
                    {
                        sum += firstNum * secondNum;
                        flag = true;
                    }
                    else if (@operator == "/")
                    {
                        sum += firstNum / secondNum;
                        flag = true;
                    }
                }
                else
                {
                    string @operator = chars.Pop();
                    int secondNum = int.Parse(chars.Pop());
                    if (@operator == "+")
                    {
                        sum = sum + secondNum;
                    }
                    else if (@operator == "-")
                    {
                        sum = sum - secondNum;
                    }
                    else if (@operator == "*")
                    {
                        sum = sum * secondNum;
                    }
                    else if (@operator == "/")
                    {
                        sum = sum / secondNum;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
