using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Implementation.LinkedList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; } 
        public LinkedListNode<T> Previous { get; set; }
        public T Value { get; set; }
        
        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
