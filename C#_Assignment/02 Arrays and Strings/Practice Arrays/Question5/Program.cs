namespace Question5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int[] array2 = { 1, 1, 1, 2, 3, 5, 5, 5, 5, 1, 3, 3, 3 };

            int[] result = LongestSequence(array2);
            foreach (int i in result)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }

        public static int[] LongestSequence(int[] array)
        {
            int count = 0;
            int maxCount = 0;
            int content = 0;
            int maxContent = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1] == array[i])
                {
                    content = array[i];
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxContent = content;
                }
            }
            int[] result = new int[maxCount+1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = maxContent;
            }
            return result;
        }
    }
}