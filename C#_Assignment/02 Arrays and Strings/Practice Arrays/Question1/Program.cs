namespace Question1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            Console.Write("Array 1 has elements: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.Write("\n");
            Console.Write("Array 2 has elements: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
            Console.Write("\n");
        }
    }
}