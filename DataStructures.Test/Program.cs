using DataStructures.Implementation.LinkedList;
using System;

namespace DataStructures.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
            singleLinkedList.AddFront(10);
            singleLinkedList.AddFront(20);
            singleLinkedList.AddFront(30);
            singleLinkedList.InsertAfter(singleLinkedList.Find(20), 50);
            singleLinkedList.InsertAfter(singleLinkedList.Find(20), 40);
            singleLinkedList.InsertAfter(singleLinkedList.Find(30), 70);
            //var finded = singleLinkedList.Find(40);
            Console.WriteLine(singleLinkedList.First?.Value);
            Console.WriteLine(singleLinkedList.First?.Next?.Value);
            Console.WriteLine(singleLinkedList.Find(40)?.Value);
            Console.WriteLine(singleLinkedList.Find(90)?.Value);
            Console.WriteLine(singleLinkedList.Find(10)?.Value);
            Console.WriteLine(singleLinkedList.Find(10)?.Next?.Value);
            Console.WriteLine(singleLinkedList.Contains(70));
            Console.WriteLine(singleLinkedList.Contains(10));
            Console.WriteLine(singleLinkedList.Contains(90));
            singleLinkedList.PrintList();
            Console.WriteLine(singleLinkedList.Remove(30));
            Console.WriteLine(singleLinkedList.Find(30)?.Value);
            singleLinkedList.PrintList();
            Console.WriteLine(singleLinkedList.Remove(50));
            Console.WriteLine(singleLinkedList.Find(50)?.Value);
            singleLinkedList.PrintList();
            Console.WriteLine(singleLinkedList.Remove(70));
            Console.WriteLine(singleLinkedList.Remove(20));
            Console.WriteLine(singleLinkedList.Remove(10));
            singleLinkedList.PrintList();
            Console.WriteLine(singleLinkedList.Remove(40));
            singleLinkedList.PrintList();            
            Console.ReadKey();
        }
    }
}
