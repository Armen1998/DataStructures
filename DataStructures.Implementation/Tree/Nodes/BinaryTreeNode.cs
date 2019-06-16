using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Implementation.Tree.Nodes
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode() { }     

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public void Display() => Console.Write(Value + " ");     
    }
}
