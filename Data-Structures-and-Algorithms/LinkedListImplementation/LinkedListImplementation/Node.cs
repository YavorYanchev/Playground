﻿namespace LinkedListImplementation
{
    public class Node<T>
    {
        public T Value;

        public Node<T> Next;

        public Node(T value)
        {
            this.Value = value;
        }

        public Node()
        {

        }
    }
}
