using DataStructures.Implementation.Tree.Nodes;
using System;
using System.Collections.Generic;

namespace DataStructures.Implementation.Tree
{
    public class BinarySearchTree<T>
        where T : struct
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinarySearchTree()
        {
            if (typeof(T) == typeof(char))
                throw new NotImplementedException("Not implemented for char.");

            Root = null;
        }

        public void Insert(T value)
        {
            BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);

            if (Root is null)
            {
                Root = node;
            }
            else
            {
                BinaryTreeNode<T> currentNode = Root;
                BinaryTreeNode<T> parent;
                while (true)
                {
                    parent = currentNode;
                    if (Comparer<T>.Default.Compare(node.Value, currentNode.Value) == -1)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            parent.Left = node;
                            break;
                        }
                    }
                    else if (Comparer<T>.Default.Compare(node.Value, currentNode.Value) == 1)
                    {
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            parent.Right = node;
                            break;
                        }
                    }
                }
            }
        }

        public void InOrder(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                node.Display();
                InOrder(node.Right);
            }
        }

        public void InOrderIterative(BinaryTreeNode<T> node)
        {
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();

            var current = node;

            while (stack.Count > 0 || current != null)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else
                {
                    current = stack.Pop();
                    current.Display();
                    current = current.Right;
                }
            }
        }

        public void PreOrder(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                node.Display();
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public void PreOrderIterative(BinaryTreeNode<T> node)
        {
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();

            var current = node;

            while (stack.Count > 0 || current != null)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current.Display();
                    current = current.Left;
                }
                else
                {
                    current = stack.Pop();
                    current = current.Right;
                }
            }
        }

        public void PostOrder(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                node.Display();
            }
        }

        public void PostOrderIterative(BinaryTreeNode<T> node)
        {
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(node);

            Stack<T> output = new Stack<T>();

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                output.Push(current.Value);

                if (current.Left != null)
                    stack.Push(current.Left);

                if (current.Right != null)
                    stack.Push(current.Right);
            }

            while (output.Count > 0)
                Console.Write(output.Pop() + " ");
                
        }

        public T? FindMin(BinaryTreeNode<T> node)
        {
            if (node is null)
                throw new ArgumentNullException();

            var currentNode = node;

            while (currentNode.Left != null)
                currentNode = currentNode.Left;

            return currentNode.Value;
        }

        public T? FindMax(BinaryTreeNode<T> node)
        {
            if (node is null)
                throw new ArgumentNullException();

            var currentNode = node;

            while (currentNode.Right != null)
                currentNode = currentNode.Right;

            return currentNode.Value;
        }

        public BinaryTreeNode<T> Find(T value)
        {
            var currentNode = Root;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                if (Comparer<T>.Default.Compare(value, currentNode.Value) == -1)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            return null;
        }

        public bool Delete(T value)
        {
            var currentNode = Root;
            var parent = Root;
            bool isLeftChild = false;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    break;
                }

                if (Comparer<T>.Default.Compare(value, currentNode.Value) == -1)
                {
                    isLeftChild = true;
                    parent = currentNode;
                    currentNode = currentNode.Left;
                }
                else
                {
                    isLeftChild = false;
                    parent = currentNode;
                    currentNode = currentNode.Right;
                }
            }

            if (currentNode != null)
            {
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    if (isLeftChild)
                    {
                        parent.Left = null;
                    }
                    else
                    {
                        parent.Right = null;
                    }
                }
                else if (currentNode.Left != null)
                {

                }
                else if (currentNode.Right != null)
                {

                }

                return true;
            }
            else return false;

        }

        public int Height(BinaryTreeNode<T> node)
        {
            if (node == null)
                return 0;

            int lHeight = Height(node.Left);
            int rHeight = Height(node.Right);

            return 1 + Math.Max(lHeight, rHeight);
        }

    }
}
