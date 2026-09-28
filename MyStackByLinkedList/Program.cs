namespace MyStackByLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class MyStackByMassive
        {
            public class StackOnLinkedList
            {
                private LinkedList<int> items;

                public void Push(int item)
                {
                    items.AddLast(item);
                }
                public int Pop()
                {
                    if (items.Count == 0)
                    {
                        throw new Exception("Стек пустой.");
                    }

                    int lastItem = items.Last.Value;
                    items.RemoveLast();
                    return lastItem;
                }

                public int Peek()
                {
                    if (items.Count == 0)
                    {
                        throw new Exception("Стек пустой.");
                    }
                    return items.Last.Value;
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
}
