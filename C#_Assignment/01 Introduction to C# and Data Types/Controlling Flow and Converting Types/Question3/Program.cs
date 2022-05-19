namespace Question3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please enter you guess among 1, 2, and 3:");
            int guessedNumber = int.Parse(Console.ReadLine());
            if ((guessedNumber < 1) | (guessedNumber > 3))
            {
                Console.WriteLine($"Your guess {guessedNumber} is invalid!");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine($"Your guess {guessedNumber} is less than the correct number {correctNumber}!");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine($"Your guess {guessedNumber} is greater than the correct number {correctNumber}!");
            }
            else
            {
                Console.WriteLine($"Your guess {guessedNumber} is the same as the correct number {correctNumber}! Good job!");
            }

        }
    }
}