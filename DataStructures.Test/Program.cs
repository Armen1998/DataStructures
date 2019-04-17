using DataStructures.Implementation.LinkedList;
using System;
using System.Collections.Generic;

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
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();

            doubleLinkedList.AddLast(40);
            doubleLinkedList.AddLast(50);
            doubleLinkedList.AddLast(10);
            doubleLinkedList.AddLast(60);
            doubleLinkedList.AddFirst(10);
            doubleLinkedList.AddFirst(20);
            doubleLinkedList.AddFirst(30);
            doubleLinkedList.AddLast(70);
            //doubleLinkedList.RemoveLast();
            //doubleLinkedList.RemoveFirst();            
            //Console.WriteLine(doubleLinkedList.Last.Value);   
            doubleLinkedList.AddAfter(doubleLinkedList.Find(0), 100);
            doubleLinkedList.PrintList();

            //Console.WriteLine(doubleLinkedList.Find(70).Value);
            #endregion
            
            Console.ReadKey();
        }
    }
}