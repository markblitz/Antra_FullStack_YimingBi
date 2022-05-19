namespace Question4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime birthDate;
            DateTime currDate = DateTime.Now.Date;
            int birthYear, birthMonth, birthDay;
            Console.WriteLine("Please enter your bitrh year;");
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your bitrh month;");
            birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your bitrh day;");
            birthDay = Convert.ToInt32(Console.ReadLine());
            birthDate = new DateTime(birthYear, birthMonth, birthDay, 0, 0, 0).Date;
            int livingDays = (currDate - birthDate).Days;
            int daysToNextAnniversary = 10000 - (livingDays % 10000);
            DateTime nextAnniversary = currDate.AddDays(daysToNextAnniversary);
            Console.WriteLine($"Your birthday is {birthDate.ToString("d")}, you have lived {livingDays} days.");
            Console.WriteLine($"Your next 10000-day anniversary will be {nextAnniversary.ToString("d")}");

        }
    }
}