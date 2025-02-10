using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLinkedList
{
    public class DoublyLinkedList
    {
        public int Count { get; private set; }
        
        public LinkedListNode Head { get; private set; }

        public LinkedListNode Tail { get; private set; }

        public void AddHead(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new LinkedListNode(element);
            }
            else
            {
                var previousHead = this.Head;
                var newNode = new LinkedListNode(element);
                previousHead.Previous = newNode;
                newNode.Next = previousHead;
                this.Head = newNode;
            }

            this.Count++;
        }

        public void AddTail(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new LinkedListNode(element);
            }
            else
            {
                var previousTail = this.Tail;
                var newNode = new LinkedListNode(element);
                newNode.Previous = previousTail;
                previousTail.Next = newNode;
                this.Tail = newNode;
            }

            this.Count++;
        }

        public int RemoveHead()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove head because list is empty");
            }

            var removedHead = this.Head;
            var removedHeadValue = removedHead.Value;
            var nextHead = removedHead.Next;

            if (nextHead == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextHead.Previous = null;
                removedHead.Next = null;
                this.Head = nextHead;
            }

            this.Count--;
            return removedHeadValue;
        }

        public int RemoveTail()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove tail because list is empty");
            }

            var removedTail = this.Tail;
            var removedTailValue = removedTail.Value;
            var nextTail = removedTail.Previous;

            if (nextTail == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextTail.Next = null;
                removedTail.Previous = null;
                this.Tail = nextTail;
            }

            this.Count--;
            return removedTailValue;
        }

        public void ForEach(Action<int> action)
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public List<int> ToList()
        {
            var list = new List<int>();
            this.ForEach(n => list.Add(n));
            return list;
        }

        public int[] ToArray()
        {
            var arr = new int[this.Count];
            int counter = 0;
            var currentNode = this.Head;
            while (currentNode != null)
            {
                arr[counter] = currentNode.Value;
                counter++;
                currentNode = currentNode.Next;
            }

            return arr;
        }

        public class LinkedListNode
        {
            public LinkedListNode(int value)
            {
                this.Value = value;
            }

            public int Value { get; set; }

            public LinkedListNode Next { get; set; }

            public LinkedListNode Previous { get; set; }
        }
    }
}
