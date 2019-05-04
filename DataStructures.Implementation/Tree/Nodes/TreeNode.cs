using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.Nodes
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Childs { get; set; }

        public TreeNode()
        {
            
        }

        public TreeNode(T value) : this()
        {
            Value = value;           
        }
    }
}
