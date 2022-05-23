namespace Question1
{
    public static class Program
    {
        public class MyStack<T>
        {
            List<T> stack;

            public MyStack()
            {
                stack = new List<T>();
            }

            public int Count()
            {
                if (stack == null)
                {
                    return 0;
                }
                return stack.Count;
            }

            public T Pop()
            {
                int lastIndex = stack.Count - 1;
                T lastElement = stack[lastIndex];
                stack.RemoveAt(lastIndex);
                return lastElement;
            }

            public void Push(T newElement)
            {
                stack.Add(newElement);
            }
        }

        public static void Main(string[] args)
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}