using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> data;
        public int Count
        {
            get { return this.data.Count; }
        }

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var rem = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return rem;
        }
    }
}
