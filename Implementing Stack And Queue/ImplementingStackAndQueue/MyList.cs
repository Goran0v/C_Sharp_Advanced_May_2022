using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStackAndQueue
{
    class MyList
    {
        private int[] data;
        private int capacity;
        public int this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.data[index] = value;
            }
        }

        public MyList()
            :this (capacity: 4)
        {

        }

        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }

        public int Count { get; private set; }

        public void Add(int el)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = el;
            this.Count++;
        }

        public void Resize()
        {
            var newCapacity = this.data.Length * 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        public int RemoveAt(int index)
        {
            this.ValidateIndex(index);
            var result = this.data[index];
            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }

            this.Count--;
            return result;
        }

        public void ValidateIndex(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return;
            }

            var message = this.Count == 0 ? "This list is empty" : $"This list has {this.Count} elements and it's zero - based";
            throw new ArgumentException($"Index out of range. {message}");
        }

        public void Shift(int index)
        {
            for (int i = index; i > this.Count - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }

        public void Shrink()
        {
            var newCapacity = this.data.Length / 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        public void ShiftRight(int index)
        {
            for (int i = this.Count - 1; i >= index; i--)
            {
                this.data[i + 1] = this.data[i];
            }
        }

        public void Insert(int firstIndex, int value)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(value);
            var firstValue = this.data[firstIndex];
            this.data[firstIndex] = this.data[value];
            this.data[value] = firstValue;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void SwapMethod(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var firstValue = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstValue;
        }

        public void Clear()
        {
            this.Count = 0;
            this.data = new int[this.capacity];
        }


    }
}