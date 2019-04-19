using DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue
{
    public class Queue<T> 
        where T : struct
    {
        private DoubleLinkedList<T> list;
        public Queue()
        {
            list = new DoubleLinkedList<T>();
        }

        public int Count { get { return list.Count; } }

        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        public T Dequeue()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            var first = list.First.Value;
            list.RemoveFirst();

            return first;
        }

        public T Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return list.First.Value;
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
