using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingOpjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Town
        {
            get { return town; }
            set { town = value; }
        }
        
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo([AllowNull] Person other)
        {
            int comparer = this.Name.CompareTo(other.Name);
            if (comparer == 0)
            {
                comparer = this.Age.CompareTo(other.Age);
                
            }

            if (comparer == 0)
            {
                comparer = this.Town.CompareTo(other.Town);
            }
            return comparer;
        }
    }
}
