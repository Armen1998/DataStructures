using System;

namespace DataStructures.Implementation.LinkedList
{
    public class DoubleLinkedList<T>
    {
        public DoubleLinkedList()
        {
            First = null;
            Last = null;
        }
        public LinkedListNode<T> First { get; set; }
        public LinkedListNode<T> Last
        {
            get
            {
                var current = First;

                while (current?.Next != null)
                    current = current.Next;

                return current;
            }
            set { }
        }
        public int Count
        {
            get
            {
                if (First == null)
                    return 0;

                var current = First;
                var count = 1;
                while (current?.Next != null)
                {
                    current = current.Next;
                    count++;
                }

                return count;
            }
        }

        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            if (First != null)
                First.Previous = node;
            node.Next = First;
            First = node;

        }

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            if (First == null)
            {
                First = node;
                return;
            }
            node.Previous = Last;
            Last.Next = node;

        }

        public void AddAfter(LinkedListNode<T> node, T value)
        {
            //var newNode = new LinkedListNode<T>(value);
            //newNode.Next = node.Next;
            //node.Next = newNode;
        }

        public void AddBefore(LinkedListNode<T> node, T value)
        {
            //var newNode = new LinkedListNode<T>(value);
            //newNode.Next = node.Next;
            //node.Next = newNode;
        }

        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> current = First;

            while (current != null && !current.Value.Equals(value))
                current = current.Next;

            return current;
        }

        public LinkedListNode<T> FindLast(T value)
        {
            LinkedListNode<T> current = Last;

            while (current != null && !current.Value.Equals(value))
                current = current.Previous;

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
            var currentStart = First;
            var currentEnd = Last;
            while (currentStart != null)
            {
                if (currentStart.Value.Equals(value) || currentEnd.Value.Equals(value))
                    return true;
                else
                {
                    currentStart = currentStart.Next;                 
                    currentEnd = currentEnd.Previous;
                    //TODO optymize
                }
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

        public void RemoveFirst()
        {

        }

        public void RemoveLast()
        {

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
