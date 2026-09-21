using System.Threading;

namespace MyCyclicDoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCyclicDoublyLinkedList linkedList = new MyCyclicDoublyLinkedList();
            linkedList.AddFirst(new Node(1));
            linkedList.AddFirst(new Node(2));
            linkedList.AddFirst(new Node(3));
            linkedList.RemoveLast();
            linkedList.Print();
        }
    }
    class MyCyclicDoublyLinkedList
    {

        Node _head;
        
        public void AddFirst(Node newNode)
        {
            if (_head == null)
            {
                _head = newNode;
                _head.Previous = newNode;
                _head.Next = newNode;
            }
            else
            {
                newNode.Next = _head;
                newNode.Previous = _head.Previous;
                _head.Previous.Next = newNode;
                _head.Previous = newNode;
                _head = newNode;
            }
        }
        public void RemoveFirst()
        {
            if (_head == null)
                return;
            if (_head.Next == _head)
            {
                _head.Next = null;
                _head.Previous = null;
                _head = null;
                return;
            }
            _head.Next.Previous = _head.Previous;
            _head.Previous.Next = _head.Next;
            _head = _head.Next;
            
        }
        public void AddLast(Node newNode)
        {
            if (_head == null)
            {
                _head = newNode;
                _head.Next = newNode;
                _head.Previous = newNode;
                return;
            }
            newNode.Previous = _head.Previous;
            _head.Previous = newNode;
            _head.Previous.Previous.Next = newNode;
            newNode.Next = _head;

        }
        public void RemoveLast()
        {
            if (_head == null)
                return;
            if (_head.Next ==  _head)
            {
                _head = null;
            }
            else
            {
                _head.Previous.Previous.Next = _head;
                _head.Previous = _head.Previous.Previous;
            }
        }
        public void Print()
        {
            if (_head == null)
                return;

            Node current = _head;

            do
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            while (current != _head);

            Console.WriteLine();
        }
    }
    class Node
    {
        public Node Next;
        public int Value;
        public Node Previous;

        public Node(int value)
        {
            Value = value;
        }
    }
}