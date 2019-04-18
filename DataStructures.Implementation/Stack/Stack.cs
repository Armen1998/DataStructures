using DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class Stack<T>
        where T : struct
    {
        private DoubleLinkedList<T> list;
        public Stack()
        {
            list = new DoubleLinkedList<T>();
        }
        public int Count { get { return list.Count; } }

        public void Push(T item)
        {
            list.AddLast(item);
        }

        public T Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            var last = list.Last;
            list.RemoveLast();

            return last.Value;
        }

        public T Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return list.Last.Value;
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
