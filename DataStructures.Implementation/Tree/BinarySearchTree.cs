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

        private void LeftView(BinaryTreeNode<T> node, int level, Dictionary<int, T> dict)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(level))
                dict.Add(level, node.Value);

            LeftView(node.Left, level + 1, dict);
            LeftView(node.Right, level + 1, dict);
        }

        public void LeftView(BinaryTreeNode<T> node, int level = 1)
        {
            var dict = new Dictionary<int, T>();

            LeftView(node, level, dict);

            foreach (var value in dict.Values)
                Console.Write(value + " ");
        }

        private void RightView(BinaryTreeNode<T> node, int level, Dictionary<int, T> dict)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(level))
                dict.Add(level, node.Value);

            RightView(node.Right, level + 1, dict);
            RightView(node.Left, level + 1, dict);
        }

        public void RightView(BinaryTreeNode<T> node, int level = 1)
        {
            var dict = new Dictionary<int, T>();

            RightView(node, level, dict);

            foreach (var value in dict.Values)
                Console.Write(value + " ");
        }

        private void TopView(BinaryTreeNode<T> node, int level, int horizontalDistance, Dictionary<int, ValueTuple<int, T>> dict)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(horizontalDistance) || level < dict[horizontalDistance].Item1)
                dict.Add(horizontalDistance, (level, node.Value));

            TopView(node.Left, level + 1, horizontalDistance - 1, dict);
            TopView(node.Right, level + 1, horizontalDistance + 1, dict);
        }

        public void TopView(BinaryTreeNode<T> node, int level = 1, int horizontalDistance = 0)
        {
            var dict = new Dictionary<int, ValueTuple<int, T>>();

            TopView(node, level, horizontalDistance, dict);

            foreach (var value in dict.Values)
                Console.Write(value.Item2 + " ");
        }

        private void BottomView(BinaryTreeNode<T> node, int level, int horizontalDistance, Dictionary<int, ValueTuple<int, T>> dict)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(horizontalDistance))
                dict.Add(horizontalDistance, (level, node.Value));
            else if (level > dict[horizontalDistance].Item1)
                dict[horizontalDistance] = (level, node.Value);


            BottomView(node.Left, level + 1, horizontalDistance - 1, dict);
            BottomView(node.Right, level + 1, horizontalDistance + 1, dict);
        }

        public void BottomView(BinaryTreeNode<T> node, int level = 1, int horizontalDistance = 0)
        {
            var dict = new Dictionary<int, ValueTuple<int, T>>();

            BottomView(node, level, horizontalDistance, dict);

            foreach (var value in dict.Values)
                Console.Write(value.Item2 + " ");
        }

        private BinaryTreeNode<T> GetInOrderSuccessor(BinaryTreeNode<T> node)
        {
            var successor = node;
            var current = node.Right;

            while (current != null)
            {
                successor = current;
                current = current.Left;
            }

            if (successor != node.Right)
            {
                successor.Right = node.Right;
            }

            return successor;
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

        public ValueTuple<BinaryTreeNode<T>, bool?> FindParent(T value)
        {
            var currentNode = Root?.Value.Equals(value) == true ? null : Root;

            while (currentNode != null)
            {
                if (currentNode.Left != null && currentNode.Left.Value.Equals(value))
                {
                    return (currentNode, true);
                }

                if (currentNode.Right != null && currentNode.Right.Value.Equals(value))
                {
                    return (currentNode, false);
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

            return (null, null);
        }

        public bool Delete(T value)
        {
            var node = Find(value);

            if (node is null)
                return false;

            var parentData = FindParent(value);

            var parent = parentData.Item1;
            var isLeftOfParent = parentData.Item2;

            if (node.Left == null && node.Right == null)
            {
                node = null;
                if (isLeftOfParent.Value)
                    parent.Left = null;
                else
                    parent.Right = null;
            }
            else if (node.Left != null && node.Right != null)
            {
                var successor = GetInOrderSuccessor(node);
                var successorData = FindParent(successor.Value);

                if (node == Root)
                    Root = successor;
                else if (isLeftOfParent.Value)
                    parent.Left = successor;
                else
                    parent.Right = successor;

                successor.Left = node.Left;

                if (successorData.Item2.Value)
                    successorData.Item1.Left = null;
                else
                    successorData.Item1.Right = null;

            }
            else
            {
                if (isLeftOfParent.Value)
                    parent.Left = node.Left ?? node.Right;
                else
                    parent.Right = node.Left ?? node.Right;
            }

            return true;
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
