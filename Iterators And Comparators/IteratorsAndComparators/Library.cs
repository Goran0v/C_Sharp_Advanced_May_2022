﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books { get; set; }
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int position = -1;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                Reset();
            }

            public Book Current => this.books[position];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                this.position++;
                return position < books.Count;
            }

            public void Reset()
            {
                this.position = -1;
            }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            this.books.Sort();
            for (int i = 0; i < this.books.Count; i++)
            {
                yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
