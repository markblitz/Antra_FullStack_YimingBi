namespace Question3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentence1 = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";

            string[] result = ExtractPalindrome(sentence1);
            for (int i = 0; i < result.Length; i++)
            {
                if (i == result.Length - 1)
                {
                    Console.WriteLine(result[i]);
                    break;
                }
                Console.Write($"{result[i]}, ");
            }
        }

        public static string[] ExtractPalindrome(string sentence)
        {
            List<string> palindrome = new List<string>();
            string[] words = sentence.Split(' ', ',', '?', ':', '.', '!');
            foreach (string word in words)
            {
                if (word == "") { continue; }
                string first = word.Substring(0, word.Length / 2);
                char[] arr = word.ToCharArray();

                Array.Reverse(arr);

                string temp = new string(arr);
                string second = temp.Substring(0, temp.Length / 2);

                if (first.Equals(second))
                {
                    palindrome.Add(word);
                }
            }
            palindrome.Distinct();
            palindrome.Sort();
            return palindrome.ToArray();
        }
    }
}