using System;

namespace DataStructures.Implementation.LinkedList
{
    public class SingleLinkedList<T>
    {
        public SingleLinkedList()
        {
            First = null;
        }
        public LinkedListNode<T> First { get; set; }

        public void AddFront(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            node.Next = First;
            First = node;
        }

        public void InsertAfter(LinkedListNode<T> node, T value)
        {
            var newNode = new LinkedListNode<T>(value);
            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> current = First;

            while (current != null && !current.Value.Equals(value))
                current = current.Next;

            return current;
        }

        private LinkedListNode<T> FindPrevious(T value)
        {
            if (First == null || First.Value.Equals(value) || !Contains(value))
                return null;
         
            var current = First;

            while (current.Next != null && !current.Next.Value.Equals(value))
                current = current.Next;

            return current;
        }

        public bool Contains(T value)
        {
            var current = First;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return true;
                else
                    current = current.Next;
            }

            return false;
        }

        public bool Remove(T value)
        {
            if (!Contains(value))
                return false;

            if (First.Value.Equals(value))
            {                
                First = First?.Next;
            }
            else
            {
                var prevNode = FindPrevious(value);
                prevNode.Next = prevNode?.Next?.Next;
            }
           
            return true;
        }

        public void PrintList()
        {
            var current = First;

            while (current != null)
            {
                Console.Write(current.Value + "  ");
                current = current.Next;
            }            
        }
    }
}
