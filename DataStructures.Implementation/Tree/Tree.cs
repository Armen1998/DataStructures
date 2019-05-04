using DataStructures.Tree.Nodes;
using System;
using System.Collections.Generic;

namespace DataStructures.Tree
{
    public class Tree<T>
    {
        public Tree()
        {
            Root = new TreeNode<T>();
        }

        public Tree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }

        public TreeNode<T> Root { get; set; }

        public void Add(TreeNode<T> node, T value)
        {
            if (node is null)
                throw new ArgumentNullException();

            if (node.Childs is null)
                node.Childs = new List<TreeNode<T>>();

            node.Childs.Add(new TreeNode<T>() { Value = value });
        }

        public bool Remove(TreeNode<T> node)
        {
            return true;
        }

        public bool Remove(T value)
        {
            return true;
        }
      
        public TreeNode<T> Find(TreeNode<T> node, T value)
        {
            if (node is null)
                throw new ArgumentNullException();

            if (node.Value.Equals(value))
            {
                return node;
            }
            else
            {
                if (!(node?.Childs is null))
                    foreach (var child in node?.Childs)
                    {
                        var findedNode = Find(child, value);

                        if (findedNode != null)
                            return findedNode;
                    }
            }

            return null;
        }

        public bool IsEmpty()
        {
            return Root.Childs is null ? true : false;
        }
    }
}
