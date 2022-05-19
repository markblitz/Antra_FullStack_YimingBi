namespace Question6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 25; j = j + i + 1)
                {
                    if (j == 24)
                    {
                        Console.Write(j.ToString() + "\n");
                    }
                    else 
                    {
                        Console.Write(j.ToString() + ",");
                    }  
                }
            }
        }
    }
}