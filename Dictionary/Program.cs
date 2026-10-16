namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class MyHashSet
        {
            

            private const int N = 17;
            private List<Item>[] items;

            public MyHashSet()
            {
                this.items = new List<Item>[N];
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = new List<Item>();
                }
            }
            public void Add(string key, int value)
            {
                var hashCode = GetHashCode(key);
                var newItem = new Item(key, value);
                var itemsWithSameHashCode = items[hashCode];


                foreach (var item in itemsWithSameHashCode)
                {
                    if (item.Key == key)
                    {
                        throw new ArgumentException("Ключ " + key + " уже есть в таблице");
                    }
                }

                itemsWithSameHashCode.Add(newItem);
            }
            public void Delete(string key)
            {
                var hashCode = GetHashCode(key);
                var itemsWithSameHashCode = items[hashCode];

                for (var i = 0; i < itemsWithSameHashCode.Count; i++)
                {
                    var item = itemsWithSameHashCode[i];
                    if (item.Key == key)
                    {
                        itemsWithSameHashCode.RemoveAt(i);
                        return;
                    }
                }
            }
            public int Search(string key)
            {
                var hashCode = GetHashCode(key);
                foreach (var item in items[hashCode])
                {
                    if (item.Key == key)
                    {
                        return item.Value;
                    }
                }

                throw new Exception("Элемента с ключом " + key + " не существует в таблице");
            }

            private int GetHashCode(string key)
            {
                unchecked
                {
                    int hash = 17;

                    foreach (char c in key)
                    {
                        hash = hash * N + c;
                    }

                    return hash;
                }
            }

            public string Print()
            {
                var result = "";
                foreach (var list in items)
                {
                    foreach (var item in list)
                    {
                        result += item.Key + " " + item.Value + "\n";
                    }
                }

                return result;
            }

        }
        public class Item
        {
            public string Key { get; set; }
            public int Value { get; set; }

            public Item(string key, int value)
            {
                Key = key;
                Value = value;
            }
        }

    }
}
