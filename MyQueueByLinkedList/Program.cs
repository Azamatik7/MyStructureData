namespace MyQueueByLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        class MyQueueByLinkedList
        {

            private LinkedList<int> items;

            public MyQueueByLinkedList()
            {
                items = new LinkedList<int>();
            }
            
            public void Push(int item)
            {
                items.AddLast(item);
            }
            public int Pop()
            {
                if (items.Count == 0)
                {
                    throw new Exception("Очередь пустая.");
                }

                int firstItem = items.First.Value;
                items.RemoveFirst();
                return firstItem;
            }
            public int Peek()
            {
                if (items.Count == 0)
                {
                    throw new Exception("Очередь пустая.");
                }

                return items.First.Value;
            }
            public void Clear()
            {
                items.Clear();
            }

            public string Print()
            {
                string result = "";
                foreach (var item in items)
                {
                    result += item + " ";
                }

                return result;
            }

            public bool Empty()
            {
                return items.Count == 0;
            }

        }
    }
}
