namespace MyDoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        class MyDoublyLinkedList
        {
            Node _head;
            Node _tail;
            public void AddFirst(Node newNode)
            {
                if (_head == null)
                {
                    _head = newNode;
                    _tail = newNode;
                }
                else
                {
                    newNode.Next = _head;
                    _head.Previous = newNode;
                    _head = newNode;

                }

            }
            public void RemoveFirst()
            {
                if (_head == null)
                    return;
                if (_head.Next == null)
                {
                    _head = null;
                    _tail = null;
                    return;
                }
                _head = _head.Next;
                _head.Previous = null;
            }
            public void AddLast(Node newNode)
            {
                if (_head == null)
                {
                    _head = newNode;
                    _tail = newNode;
                    return;
                }
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
                
            }
            public void RemoveLast()
            {
                if (_head == null)
                    return;
                if (_head.Next == null)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    
                    _tail = _tail.Previous;
                    _tail.Next = null;
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
                Console.WriteLine($"tail {_tail.Value}");

            }
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
}
