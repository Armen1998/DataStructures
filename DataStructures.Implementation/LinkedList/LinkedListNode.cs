﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class LinkedListNode<T> 
        where T : struct
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
