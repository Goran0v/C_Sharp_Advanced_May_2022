﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparatorsExercise
{
    public class ListyIterator<T>
    {
        private List<T> collection;
        private int currIndex;

        public ListyIterator(params T[] data)
        {
            collection = new List<T>(data);
            currIndex = 0;
        }

        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currIndex++;
            }
            return canMove;
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(collection[currIndex]);
        }

        public bool HasNext() => currIndex < collection.Count - 1;
    }
}
