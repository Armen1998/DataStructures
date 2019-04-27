using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DataStructures.Sets
{
    public class HashSet<T>
        where T : struct
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
                if (!hashTable.ContainsValue(item))
                    hashTable.Add(Hash(item.ToString()), item);
            }
        }

        private string Hash(string item)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(item));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public int Count => hashTable.Count;

        public bool IsReadOnly => hashTable.IsReadOnly;

        public void Add(T item)
        {
            if (!hashTable.ContainsValue(item))
                hashTable.Add(Hash(item.ToString()), item);
        }

        public bool IsSupersetOf(ICollection<T> other)
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

        public bool IsSubsetOf(ICollection<T> other)
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
        
        public void Remove(T item)
        {
            hashTable.Remove(Hash(item.ToString()));
        }
    }
}
