using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Exercise_Liga_Mistru
{
    class LinkedList<T> : IEnumerable<T>, ICollection<T>, IList<T>
    {
        private NodeList first;
        private NodeList last;
        private int countNode;

        private class NodeList
        {
            public T Data { get; set; }
            public NodeList Next { get; set; }
            public NodeList Back { get; set; }

            public NodeList(T data, NodeList next, NodeList back)
            {
                Data = data;
                Next = next;
                Back = back;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = first;
            while (node != null)
            {
                yield return node.Next.Data;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            NodeList newNode;

            if (first == null)
            {
                newNode = new NodeList(item, null, null);
                newNode.Back = newNode;
                newNode.Next = newNode;
                last = newNode;
            }
            else
            {
                newNode = new NodeList(item, first, last);
            }

            first = newNode;
            countNode++;
        }

        public void Clear()
        {
            first = last = null;
            countNode = 0;
        }

        public bool Contains(T item)
        {
            NodeList tempNode = first;
            for (int i = 0; i < countNode; i++)
            {
                if (tempNode.Data.Equals(item))
                {
                    return true;
                }

                tempNode = tempNode.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("Neinicializované pole.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("Záporný index.");
            if (countNode > array.Length - arrayIndex + 1)
                throw new ArgumentException("Málo místa pro uložení položek spojového seznamu.");
            if (first == null)
                throw new ArgumentException("Prázdný spojový seznam!");

            NodeList tempNode = first;
            array = new T[countNode];

            do
            {
                array[arrayIndex++] = tempNode.Data;
                tempNode = tempNode.Next;
            } while (!tempNode.Equals(first));
        }

        public bool Remove(T item)
        {
            NodeList tempNode = first;
            for (int i = 0; i < countNode; i++)
            {
                if (tempNode.Data.Equals(item))
                {
                    tempNode.Back.Next = tempNode.Next;
                    tempNode.Next.Back = tempNode.Back;

                    return true;
                }

                tempNode = tempNode.Next;
            }

            return false;
        }

        public int Count { get; }
        public bool IsReadOnly { get; }

        public int IndexOf(T item)
        {
            NodeList tempNode = first;
            for (int i = 0; i < countNode; i++)
            {
                if (tempNode.Data.Equals(item))
                {
                    return i;
                }

                tempNode = tempNode.Next;
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index > countNode && index < 0)
                throw new ArgumentException("Index je mimo meze spojového seznamu!");

            NodeList tempNode = first;
            for (int i = 0; i < countNode; i++)
            {
                if (i == index)
                {
                    NodeList temp = tempNode.Next;
                    tempNode.Next = new NodeList(item, tempNode, tempNode.Next);
                    temp.Back = tempNode.Next;
                    return;
                }

                tempNode = tempNode.Next;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > countNode && index < 0)
                throw new ArgumentException("Index je mimo meze spojového seznamu!");

            NodeList tempNode = first;

            for (int i = 0; i < index; i++)
                tempNode = tempNode.Next;

            tempNode.Back.Next = tempNode.Next;
            tempNode.Next.Back = tempNode.Back;
        }

        public T this[int index]
        {
            get
            {
                if (index >= countNode || index < 0)
                    throw new ArgumentOutOfRangeException("index");

                NodeList node = this.first;
                for (int i = 0; i < index; i++)
                    node = node.Next;
                return node.Data;
            }

            set
            {
                if (index >= countNode || index < 0)
                    throw new ArgumentOutOfRangeException("index");

                NodeList node = this.first;
                for (int i = 0; i < index; i++)
                    node = node.Next;

                node.Data = value;
            }
        }
    }
}
