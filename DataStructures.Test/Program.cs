using DataStructures.Stack;
using System;

namespace DataStructures.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SingleLinkedList
            //SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
            //singleLinkedList.AddFirst(10);
            //singleLinkedList.AddFirst(20);
            //singleLinkedList.AddAfter(singleLinkedList.Find(10), 50);
            //singleLinkedList.Remove(20);
            //singleLinkedList.PrintList();            
            #endregion

            #region DoubleLinkedList
            //DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();

            //doubleLinkedList.AddLast(40);
            //doubleLinkedList.AddLast(50);
            //doubleLinkedList.AddLast(10);
            //doubleLinkedList.AddLast(60);
            //doubleLinkedList.AddFirst(10);
            //doubleLinkedList.AddFirst(20);
            //doubleLinkedList.AddLast(70);
            //doubleLinkedList.RemoveLast();
            //doubleLinkedList.RemoveFirst();
            //doubleLinkedList.AddAfter(doubleLinkedList.Find(70), 100);
            //doubleLinkedList.AddBefore(doubleLinkedList.Find(100), 99);
            //doubleLinkedList.AddBefore(doubleLinkedList.First, 99);
            //doubleLinkedList.AddBefore(doubleLinkedList.Last, 99);
            //doubleLinkedList.PrintList();
            //Console.WriteLine(doubleLinkedList.Contains(99));           
            #endregion

            #region Stack            
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Contains(5));
            Console.WriteLine(stack.Contains(1));
            stack.Clear();
            Console.WriteLine(stack.Count);
            #endregion
            //System.Collections.Stack stack2 = new System.Collections.Stack();
            //stack2.
            Console.ReadKey();
        }
    }
}