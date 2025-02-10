using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        private List<Person> members;

        private List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = this.Members.Max(x => x.Age);
            return this.Members.First(member => member.Age == maxAge);
        }

        public List<Person> OrderMembers(List<Person> people)
        {
            List<Person> sorted = new List<Person>();
            foreach (var person in people)
            {
                if (person.Age > 30)
                {
                    sorted.Add(person);
                }
            }
            sorted.OrderBy(member => member.Name);
            return sorted;
        }
    }
}
