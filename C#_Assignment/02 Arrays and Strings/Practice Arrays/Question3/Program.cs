namespace Question3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (int prime in FindPrimesInRange(1, 100))
            {
                Console.WriteLine(prime);
            }
        }

        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> result = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (PrimeCheck(i))
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }

        public static bool PrimeCheck(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}