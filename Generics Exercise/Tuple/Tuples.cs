using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Tuples<T1, T2>
    {
        public Tuples(T1 first, T2 second)
        {
            FirstElement = first;
            SecondElement = second;
        }

        public T1 FirstElement { get; private set; }
        public T2 SecondElement { get; private set; }
        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
