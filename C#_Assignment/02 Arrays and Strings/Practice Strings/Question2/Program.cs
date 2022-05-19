namespace Question2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string phrase = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(Reverses(phrase));
        }

        public static string Reverses(string sentence)
        {
            string[] words = sentence.Split(' ', '.', ',', ':', ':', '=', '(', ')', '&', '[', ']', '\"', '\'', '/', '\\', '!', '?');
            return String.Join(" ", words.Reverse());
        }
    }
}