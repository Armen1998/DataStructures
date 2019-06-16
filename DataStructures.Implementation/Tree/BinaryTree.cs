using DataStructures.Implementation.Tree.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Implementation.Tree
{
    public class BinaryTree<T>
        where T : struct
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTree()
        {
            if (typeof(T) == typeof(char))
                throw new NotImplementedException("Not implemented for char.");

            Root = null;
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

        public void PreOrder(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                node.Display();
                PreOrder(node.Left);
                PreOrder(node.Right);
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
        
        public int Height(BinaryTreeNode<T> node)
        {
            return 0;
        }
    }
}
