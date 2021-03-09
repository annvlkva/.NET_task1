using System;
using System.Collections;
using System.Collections.Generic;

namespace task1
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    
    public class LinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public void Reverse()
        {
            Node<T> p = head, n = null;
            while (p != null)
            {
                var tmp = p.Next;
                p.Next = n;
                n = p;
                p = tmp;
            }
            head = n;
        }

        public bool Remove(T data)
        {
            var current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {

                    if (previous != null)
                    {

                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Show()
        {
            Node<T> p = head;
            while (p != null)
            {
                Console.Write(p.Data + " ");
                p = p.Next;
            }
            Console.Write("\n");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}