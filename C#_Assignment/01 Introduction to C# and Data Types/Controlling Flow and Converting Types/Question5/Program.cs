namespace Question5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int currHour = DateTime.Now.Hour;
            // Morning 6am - 12pm
            // Afternoon 12pm - 6pm
            // Evening 6pm - 12am
            // Night 12am - 6am
            if ((currHour >= 6) & (currHour < 12))
            {
                Console.WriteLine("Good Morning!");
            }
            if ((currHour >= 12) & (currHour < 18))
            {
                Console.WriteLine("Good Afternoon!");
            }
            if ((currHour >= 18) & (currHour < 24))
            {
                Console.WriteLine("Good Evening!");
            }
            if ((currHour >= 0) & (currHour < 6))
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}