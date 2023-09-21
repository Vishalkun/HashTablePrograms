using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    public class MapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        public struct KeyValue<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPoistion(key);
            LinkedList<KeyValue<K, V>> linkedList = getLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);

        }

        public V Get(K key)
        {
            int position = GetArrayPoistion(key);
            LinkedList<KeyValue<K, V>> linkedList = getLinkedList(position);

            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }

            }
            return default(V);
        }
        public int GetArrayPoistion(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public LinkedList<KeyValue<K, V>> getLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;

            }
            return linkedList;
        }

        public void Get_Frequency(V Values)
        {
            int frequency = 0;

            foreach (LinkedList<KeyValue<K, V>> list in items)
            {
                if (list == null)
                {
                    continue;
                }
                foreach (KeyValue<K, V> check in list)
                {
                    if (check.Equals(null))
                    {
                        continue;

                    }
                    if (check.Value.Equals(Values))
                    {
                        frequency++;
                    }

                }

            }
            Console.WriteLine("frequency of {0} is : {1}", Values, frequency);

        }


    }
    }
