﻿using DataStructures.Implementation.Tree;
using DataStructures.Tree;
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
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Pop();
            //stack.Pop();
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Count);
            //Console.WriteLine(stack.Contains(5));
            //Console.WriteLine(stack.Contains(1));
            //stack.Clear();
            //Console.WriteLine(stack.Count);            
            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Dequeue();
            //queue.Dequeue();
            //Console.WriteLine(queue.Count);
            //Console.WriteLine(queue.Contains(1));
            //Console.WriteLine(queue.Contains(3));
            //Console.WriteLine(queue.Peek());
            //queue.Clear();
            //Console.WriteLine(queue.Count);
            #endregion

            #region HashSet
            //Sets.HashSet<int> hashSet = new Sets.HashSet<int>(new List<int>() { 1, 2, 3, 8, 9, 15, 7, 1 });
            //Sets.HashSet<int> hashSet2 = new Sets.HashSet<int> { 1, 2, 3, 8, 9, 10, 6, 1 };
            //Console.WriteLine(hashSet.Contains(10));
            //hashSet.UnionWith(hashSet2);
            //hashSet.ExceptWith(new List<int>() { 8, 9 });            
            //hashSet.IntersectWith(new List<int> { 3, 8, 9, 10, 6, 1 });
            //Console.WriteLine(hashSet2.IsSupersetOf(new List<int> { 10, 6, 1 }));
            //Console.WriteLine(hashSet2.IsSubsetOf(new List<int> { 1, 2, 3, 8, 9, 10, 6, 11, 12 }));
            //hashSet.Remove(9);
            //Console.WriteLine(hashSet.RemoveWhere(item => item > 5));
            #endregion

            #region Tree
            //Tree<int> tree = new Tree<int>(5);
            //Console.WriteLine(tree.IsEmpty());
            //Console.WriteLine(tree.Find(tree.Root, 15) is null);
            //tree.Add(tree.Root, 10);
            //tree.Add(tree.Root, 20);
            //tree.Add(tree.Root, 30);
            //Console.WriteLine(tree.Find(tree.Root, 30) is null);
            //tree.Add(tree.Find(tree.Root, 20), 21);
            //tree.Add(tree.Find(tree.Root, 20), 22);
            //tree.Add(tree.Find(tree.Root, 20), 23);
            //tree.Add(tree.Find(tree.Root, 30), 31);
            //tree.Add(tree.Find(tree.Root, 30), 32);
            //tree.Add(tree.Find(tree.Root, 30), 33);
            //Console.WriteLine(tree.Find(tree.Root, 22) is null);
            #endregion

            #region BinarySearchTree
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(7);
            binarySearchTree.Insert(23);
            binarySearchTree.Insert(12);
            binarySearchTree.Insert(8);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(21);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(1);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(13);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(2);
            binarySearchTree.Insert(-1);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(19);
            binarySearchTree.InOrder(binarySearchTree.Root);
            Console.WriteLine();
            binarySearchTree.InOrderIterative(binarySearchTree.Root);
            Console.WriteLine();
            binarySearchTree.PreOrder(binarySearchTree.Root);
            Console.WriteLine();
            binarySearchTree.PreOrderIterative(binarySearchTree.Root);
            Console.WriteLine();
            binarySearchTree.PostOrder(binarySearchTree.Root);
            Console.WriteLine();
            binarySearchTree.PostOrderIterative(binarySearchTree.Root);
            Console.WriteLine();
            Console.WriteLine(binarySearchTree.Height(binarySearchTree.Find(7)));

            ////Console.WriteLine(binarySearchTree.FindMin(binarySearchTree.Root));            
            ////Console.WriteLine(binarySearchTree.FindMax(binarySearchTree.Root));
            ////Console.WriteLine(binarySearchTree.Find(21).Value);
            ////Console.WriteLine(binarySearchTree.Delete(4));
            #endregion

            Console.ReadKey();
        }
    }
}