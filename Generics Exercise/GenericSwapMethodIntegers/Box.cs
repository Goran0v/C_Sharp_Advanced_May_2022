using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box<T>
    {
        public Box(List<T> elements)
        {
            Elements = elements;
        }
        public Box(T element)
        {
            Element = element;
        }
        public T Element { get; }
        public List<T> Elements { get; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (T item in Elements)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
            //return $"{typeof(T)}: {Element}";
        }

        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            var firstEl = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = firstEl;
        }
    }
}
