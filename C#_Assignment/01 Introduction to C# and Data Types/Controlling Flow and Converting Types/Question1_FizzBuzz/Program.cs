namespace Question1_FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz game from 1 too 100:");
            FizzBuzz game1 = new FizzBuzz(100);

            Console.WriteLine("part2, infinit loop and modification:");
            // directly execute the codes will lead to an infinit loop since the iterator has maxvalue 255
            // when i is 255, i++ brings it back to 0 and restrats the loop

            // DANGER! infinit loop!!!
            //Part2 tryExecute = new Part2();


            // the modification below will break the loop when the iterator reaches its maxvalue
            Part2Modified tryModification = new Part2Modified();

            // Part3 is the same as question 3, codes can be found in question 3
        }
    }
}