namespace Question2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
