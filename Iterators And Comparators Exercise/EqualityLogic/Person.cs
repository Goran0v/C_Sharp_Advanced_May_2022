using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

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
        
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo([AllowNull] Person other)
        {
            int comparer = this.Name.CompareTo(other.Name);
            if (comparer == 0)
            {
                comparer = this.Age.CompareTo(other.Age);
            }
            return comparer;
        }

        public override int GetHashCode() => Name.GetHashCode() ^ Age.GetHashCode();

        public override bool Equals(object? obj)
        {
            var other = obj as Person;
            if (other == null)
            {
                return false;
            }
            return Age == other.Age && Name == other.Name;
        }

        public override string ToString() => $"{Name} {Age}";
    }
}
