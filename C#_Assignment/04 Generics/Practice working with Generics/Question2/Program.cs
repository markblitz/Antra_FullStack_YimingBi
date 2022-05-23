namespace Question2
{
    public static class Program
    {
        public class MyList<T>
        {
            List<T> list;

            public MyList()
            {
                list = new List<T>();
            }

            public void Add(T element)
            {
                list.Add(element);
            }

            public T Remove(int index)
            {
                T removedElement = list[index];
                list.RemoveAt(index);
                return removedElement;
            }

            public bool Contains(T element)
            {
                return list.Contains(element);
            }

            public void Clear()
            {
                list.Clear();
            }

            public void IsertAt(T element, int index)
            {
                list.Insert(index, element);
            }

            public void DeleteAt(int index)
            {
                list.RemoveAt(index);
            }

            public T Find(int index)
            {
                return (T)list[index];
            }
        }

        public static void Main(string[] args)
        {
            var stack = new MyList<int>();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            Console.WriteLine(stack.Remove(2));
            Console.WriteLine(stack.Contains(3));
        }
    }
}