using System.Drawing;

namespace MyStackByMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStackByMassive myStackByMassive = new MyStackByMassive();
            myStackByMassive.Push(5);
            myStackByMassive.Push(6);
            myStackByMassive.Push(7);
            Console.WriteLine(myStackByMassive.Peek());
        }
        public class MyStackByMassive
        {
            private int[] massive { get; set; } = new int[4];
            public int Count { get; private set; } = 0;
            public  bool IsEmpty()
            {
                return Count == 0;
            }
            private void IncreaseArray()
            {
                int newCount = Count * 2;

                int[] newArray = new int[newCount];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = massive[i];
                }

                massive = newArray;
            }
            public void Push(int value)
            {
                if (Count == massive.Length)
                    IncreaseArray();
                massive[Count] = value;
                Count++;
            }
            public int Pop()
            {
                if (Count == 0)
                    throw new Exception("Стек пустой");
                var last = massive[Count - 1];
                Count--;
                return last;
            }
            public int Peek()
            {
                return massive[Count - 1];
            }
            public void Clear()
            {
                Count = 0;
            }
        }
    }
}
