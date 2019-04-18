using System;

namespace DataStructures.LinkedList
{
    public class DoubleLinkedList<T>
        where T : struct
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
            if (node == null)
                return;

            var newNode = new LinkedListNode<T>(value)
            {
                Previous = node,
                Next = node.Next
            };

            if (node.Next != null)
                node.Next.Previous = newNode;

            node.Next = newNode;
        }

        public void AddBefore(LinkedListNode<T> node, T value)
        {
            if (node == null)
                return;

            var newNode = new LinkedListNode<T>(value)
            {
                Next = node,
                Previous = node.Previous
            };

            if (node.Previous != null)
                node.Previous.Next = newNode;
            else
                First = newNode;

            node.Previous = newNode;

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
                    if (currentStart == currentEnd || currentStart.Next == currentEnd)
                        return false;
                    currentStart = currentStart.Next;
                    currentEnd = currentEnd.Previous;
                }
            }

            return false;
        }

        public bool Remove(T value)
        {
            var removedNode = Find(value);

            if (removedNode == null)
                return false;

            if (removedNode == First)
            {
                RemoveFirst();
                return true;
            }

            if (removedNode == Last)
            {
                RemoveLast();
                return true;
            }

            removedNode.Previous.Next = removedNode.Next;
            removedNode.Next.Previous = removedNode.Previous;
            removedNode.Next = null;
            removedNode.Previous = null;
            return true;
        }

        public void RemoveFirst()
        {
            First = First?.Next;
            if (First != null)
                First.Previous = null;
        }

        public void RemoveLast()
        {
            if (Last?.Next == null && Last?.Previous == null)
            {
                First = null;
                return;
            }

            if (Last?.Previous != null)
                Last.Previous.Next = null;
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
