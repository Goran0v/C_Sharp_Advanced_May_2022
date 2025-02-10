using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStackAndQueue
{
    public class MyStack
    {
        private const int INITIAL_CAPACITY = 4;
        public int[] data;

        public int Count { get; private set; }

        public MyStack()
        {
            this.Count = 0;
            this.data = new int[INITIAL_CAPACITY];
        }

        public void Push(int element)
        {
            if (this.Count == data.Length)
            {
                this.ResizeStack();
            }
            this.data[this.Count] = element;
            this.Count++;
        }

        private void ResizeStack()
        {
            var newData = new int[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }

        public int Peek()
        {
            if (this.data.Length == 0)
            {
                throw new ArgumentException("The stack is empty");
            }

            int num = data[Count - 1];
            return num;
        }

        public int Pop()
        {
            CheckForElement();
            int num = data[this.Count - 1];
            data[this.Count - 1] = default(int);
            Count--;
            return num;
        }

        public void CheckForElement()
        {
            if (this.data.Length == 0)
            {
                throw new ArgumentException("The stack is empty");
            }
        }

        public void Clear()
        {
            this.Count = 0;
            this.data = new int[INITIAL_CAPACITY];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.data[i]);
            }
        }
    }
}
