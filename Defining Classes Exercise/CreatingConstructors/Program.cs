using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int age = 30;
            string name = "Lyuben";
            Person person1 = new Person();
            Person person2 = new Person(age);
            Person person3 = new Person(name, age);
        }
    }
}