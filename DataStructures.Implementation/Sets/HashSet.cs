using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DataStructures.Sets
{
    public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    {
        private Hashtable hashTable;
        public HashSet()
        {
            hashTable = new Hashtable();
        }

        public HashSet(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public int Count => hashTable.Count;

        public bool IsReadOnly => hashTable.IsReadOnly;

        private string Hash(string item)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(item));
                
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void Add(T item)
        {
            if (!hashTable.ContainsValue(item))
                hashTable.Add(Hash(item.ToString()), item);
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            if (other is null)
                throw new ArgumentNullException();

            var list = new List<T>();

            foreach(var item in hashTable.Values)
            {              
                if (!other.Contains((T)item))
                {
                    list.Add((T)item);
                }
            }

            list.ForEach(item => Remove(item));
        }

        public int RemoveWhere(Func<T, bool> predicate)
        {
            var array = new T[hashTable.Count];
            hashTable.Values.CopyTo(array, 0);

            var list = array.Where(predicate).ToList();

            list.ForEach(item => Remove(item));

            return list.Count;
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            if (other is null)
                throw new ArgumentNullException();

            var list = new List<T>();

            foreach (var item in hashTable.Values)
            {
                if (other.Contains((T)item))
                {
                    list.Add((T)item);
                }
            }

            list.ForEach(item => Remove(item));
        }

        public void UnionWith(IEnumerable<T> other)
        {
            if (other is null)
                throw new ArgumentNullException();

            foreach (var item in other)
            {
                Add(item);
            }
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            if (other is null)
                throw new ArgumentNullException();

            foreach(var item in other)
            {
                if (!hashTable.ContainsValue(item))
                    return false;
            }

            return true;
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            if (other is null)
                throw new ArgumentNullException();

            foreach (var key in hashTable.Keys)
            {
                if (!other.Contains((T)hashTable[key]))
                    return false;
            }

            return true;
        }

        public void Clear()
        {
            hashTable.Clear();
        }

        public bool Contains(T item)
        {
            return hashTable.ContainsValue(item);
        }       

        public void CopyTo(T[] array, int arrayIndex = 0)
        {  
            hashTable.Values.CopyTo(array, arrayIndex);
        }
    
        public bool Remove(T item)
        {
            if(hashTable.ContainsValue(item))
            {
                var b = hashTable.ContainsKey(Hash(item.ToString()));
                hashTable.Remove(Hash(item.ToString()));
                return true;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in hashTable.Values)
            {
                yield return (T)item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
