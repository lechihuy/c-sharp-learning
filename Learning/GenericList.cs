using System;

namespace Learning;

public class GenericList<T>
{
    private Node? head;

    public GenericList()
    {
        head = null;
    }

    private	class Node
    {
        private Node? next;

        private T data;

        public Node(T t)
        {
            next = null;
            data = t;
        }

        public Node? Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }

    public void AddHead(T t)
    {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? current = head;

        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
}

