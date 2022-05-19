namespace Question7
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            int[] array1 = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int[] array2 = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
            int[] array3 = { 0, 0, 0, 0, 2, 2, 2, 2, 2 };
            var result = mostFrequentNumber(array3);
            Console.WriteLine(result);
        }

        public static int mostFrequentNumber(int[] array)
        {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (myDict.ContainsKey(array[i]))
                {
                    myDict[array[i]]++;
                }
                else
                {
                    myDict.Add(array[i], 1);
                }
            }
            int maxCount = myDict.Values.Max();
            var maxNumber = myDict.FirstOrDefault(x => x.Value == maxCount).Key;
            
            return maxNumber;
        }
    }
}