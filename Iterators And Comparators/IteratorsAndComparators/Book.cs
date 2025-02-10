using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }

        public int CompareTo([AllowNull] Book other)
        {
            if (other == null)
            {
                return -1;
            }
            int titleCompare = this.Year.CompareTo(other.Year);

            if (titleCompare == 0)
            {
                titleCompare = this.Title.CompareTo(other.Title);
            }
            return titleCompare;
        }
    }
}
