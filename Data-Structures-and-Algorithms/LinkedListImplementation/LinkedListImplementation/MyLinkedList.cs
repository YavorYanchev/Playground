using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class MyLinkedList<T>
    {

        public MyLinkedList()
        {
            Head = null;
            Tail = null;
        }
        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddAtLast(T data)
        {
            var newNode = new Node<T>(data);
            //newNode.Value = data;

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        //public void AddAtStart(object data)
        //{
        //    Node newNode = new Node();
        //    newNode.Value = data;
        //    newNode.Next = head;
        //    head = newNode;
        //    Count++;
        //}

        //public void RemoveFromStart()
        //{
        //    if (Count)
        //    {

        //    }
        //}

        public void PrintAllNodes()
        {

            Node<T> curr = Head;
            while (curr != null)
            {

                Console.Write(curr.Value);
                if (curr.Next != null)
                {
                    Console.Write("->");

                }
                curr = curr.Next;
            }
            //Console.Write("NULL");
        }
    }
}
