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
            //singleLinkedList.InsertAfter(singleLinkedList.Find(10), 50);
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
            //console.writeline(doublelinkedlist.find(10).value);
            //Console.WriteLine(doubleLinkedList.FindLast(10).Value);
            Console.WriteLine(doubleLinkedList.Count);
            Console.WriteLine(doubleLinkedList.Contains(100));
            //doubleLinkedList.PrintList();
            #endregion
            
            Console.ReadKey();
        }
    }
}