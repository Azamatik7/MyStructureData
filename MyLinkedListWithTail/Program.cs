
using System.Xml.Linq;

namespace MyLinkedListWithTail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedListWithTail link = new MyLinkedListWithTail();
            link.AddFirst(new Node(1));
            link.AddFirst(new Node(2));
            link.AddFirst(new Node(2));
            Console.WriteLine(link.Print());


        }
        class MyLinkedListWithTail
        {
            private Node _head;
            private Node _tail;

            public  void AddFirst(Node newNode)
            {
                newNode.Next = _head;
                _head = newNode;
            }
            public void RemoveFirst()
            {
                if (_head == null)
                    return;
                _head = _head.Next;
            }
            public void AddLast(Node newNode)
            {
                if (_head == null)
                {
                    _head = newNode;
                    return;
                }
                _tail.Next = newNode;
                _tail = newNode;
            }
            public void RemoveLast()
            {
                if (_head == null)
                    return;
                if (_head.Next == null)
                {
                    _head = null;
                }
                else
                {
                    Node current = _head;
                    Node prev = null;
                    while (current.Next != null)
                    {
                        prev = current;
                        current = current.Next;
                    }
                    prev.Next = null;
                    _tail = prev;
                }
            }
            public void Print()
            {
                Node current = _head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

        }
        class Node
        {
            public Node Next;
            public int Value;

            public Node(int value)
            {
                Value = value;
            }
        }
    }
}
