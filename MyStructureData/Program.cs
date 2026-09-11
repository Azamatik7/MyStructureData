namespace MyStructureData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            int[] ints = new int[] { 99, 89, 79 };
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.AddRange(ints);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }
    }
    class MyList
    {
        private int[] massive { get; set; } = new int[4];
        public int Count { get; private set; } = 0;
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return massive[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                massive[index] = value;
            }
        }

        public void Add(int value)
        {

            if (Count == massive.Length)
            {
                Resize();
            }
            massive[Count] = value;
            Count++;
        }
        public void Insert(int index, int value)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            if (massive.Length == Count)
            {
                Resize();
            }

            for (int j = Count - 1; j >= index; j--)
            {
                massive[j + 1] = massive[j];

            }
            massive[index] = value;
            Count++;

        }

        public void Remove(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (massive[i] == item)
                {
                    RemoveAt(i);
                    return;
                }

            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            for (int j = index; j < Count - 1; j++)
            {
                massive[j] = massive[j + 1];

            }
            Count--;

        }
        public void AddRange(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public void Clear()
        {
            Count = 0;
        }
        private void Resize()
        {
            int newSize = massive.Length == 0 ? 4 : massive.Length * 2;

            int[] newMassive = new int[newSize];

            for (int i = 0; i < massive.Length; i++)
            {
                newMassive[i] = massive[i];
            }

            massive = newMassive;
        }
    }
}
