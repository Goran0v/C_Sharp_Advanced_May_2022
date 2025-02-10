using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
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
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    foreach (T item in Elements)
        //    {
        //        sb.AppendLine($"{item.GetType()}: {item}");
        //    }
        //    return sb.ToString().TrimEnd();
        //    //return $"{typeof(T)}: {Element}";
        //}

        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            var firstEl = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = firstEl;
        }


        public int Count<T>(List<T> list, T readline) where T : IComparable => list.Count(word => word.CompareTo(readline) > 0);

        public int CompareTo(T element) => Element.CompareTo(element);
    }
}
