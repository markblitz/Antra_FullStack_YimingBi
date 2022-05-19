namespace Question4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 3, 2, 4, -1 };
            int[] array2 = { 1, 2, 3, 4, 5 };
            int[] result = RotateSum(array2, 3);
            foreach (int i in result)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }

        public static int[] RotateSum(int[] array, int rotateNum)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {  
                for (int j = 1; j <= rotateNum; j++)
                {
                    int newPosition = i - j;
                    while (newPosition < 0)
                    {
                        newPosition += array.Length;
                    }
                    while (newPosition > array.Length)
                    {
                        newPosition -= array.Length;
                    }
                    result[i] += array[newPosition];
                }

            }
            return result;
        }
    }
}